import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DetailedModel } from '../models/detailed.model';
import { CartFlightModel } from '../../cart/cartFlight-model';
import { FlightService } from '../flight.service';
import { AuthService } from '../../authentication/auth.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';
import { CartService } from '../../cart/cart-service';

@Component({
  selector: 'app-details-flight',
  templateUrl: './details-flight.component.html',
  styleUrls: ['./details-flight.component.css'],
  animations: [
    trigger('flightImage', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(-100px)'
        }),
        animate(300)
      ])
    ]),
    trigger('flightInfo', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(+100px)'
        }),
        animate(300)
      ])
    ])
  ]
})
export class DetailsFlightComponent implements OnInit {
  id = this.route.snapshot.params.id;

  constructor(
    private flightService: FlightService,
    private route: ActivatedRoute,
    private router: Router,
    private auth: AuthService,
    private fb: FormBuilder,
    private cartService: CartService
  ) {}

  singleFlight: DetailedModel;
  orderFlight: CartFlightModel;
  cartForm: FormGroup; //to purchase tickets
  isCreator: boolean = false; //to show pencil.gif for editing
  subtotal: number;
  isAvailableSeats: boolean;

  ngOnInit() {
    this.flightService.details(this.id).subscribe(res => {
      this.singleFlight = res;
      if (res['_acl']['creator'] === this.auth.userId) {
        this.isCreator = true;
      }
      
      this.subtotal = this.singleFlight.cost

      this.cartForm = this.fb.group({
        numberOfTickets: ['1', [Validators.max(this.singleFlight.seats), Validators.min(1)]]
      });
      
      this.isAvailableSeats = this.singleFlight.seats > 0;

      this.cartForm.valueChanges.subscribe(response => {
        this.subtotal = response.numberOfTickets * this.singleFlight.cost; // to update the subtotal field next to cartForm
      });
    });
  }

  buy(value) {
    let flightId = this.id;
    let tickets = value.numberOfTickets;

    const {
      destination,
      origin,
      departureDate,
      departureTime,
      seats,
      cost,
      image,
      isPublished
    } = this.singleFlight;

    let subTotal = this.subtotal;

    let order = {
      flightId,
      destination,
      origin,
      departureDate,
      departureTime,
      seats,
      cost,
      image,
      isPublished,
      tickets,
      subTotal
    };

    this.cartService.insertOrder(order);
    
    this.router.navigateByUrl('/flight/public');
  }
}
