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
    private orderService: CartService
  ) {}

  singleFlight: DetailedModel;
  orderFlight: CartFlightModel;
  cartForm: FormGroup;
  isCreator: boolean = false;
  subtotal: number;
  // isAvailableSeats: boolean;
  // availableSeats: number;

  ngOnInit() {
    this.flightService.details(this.id).subscribe(res => {
      this.singleFlight = res;
      if (res['_acl']['creator'] === this.auth.userId) {
        this.isCreator = true;
      }
      // localStorage.setItem('seats', `${res.seats}`);
      // this.availableSeats = Number(localStorage.getItem('seats'));
      this.subtotal = this.singleFlight.cost

      this.cartForm = this.fb.group({
        numberOfTickets: ['1', [Validators.max(this.singleFlight.seats), Validators.min(1)]]
      });

      // this.isAvailableSeats =
      //   this.singleFlight.seats >= Number(localStorage.getItem('seats'));
      // this.subtotal = this.singleFlight.cost;

      this.cartForm.valueChanges.subscribe(res => {
        this.subtotal = res.numberOfTickets * this.singleFlight.cost;
      });
      // console.log(res['_acl']['creator']);
    });
  }

  buy(value) {
    // console.log(this.singleFlight);
    let flightId = this.id;
    let tickets = value.numberOfTickets;
    // let availableTickets = Number(localStorage.getItem('seats'))

    // if (tickets >= availableTickets) {
    //   tickets = availableTickets;
    // }
    // this.singleFlight.seats -= tickets;

    const {
      destination,
      origin,
      departureDate,
      cost,
      seats
    } = this.singleFlight;

    let subTotal = this.subtotal;

    let order = {
      flightId,
      destination,
      origin,
      departureDate,
      cost,
      seats,
      tickets,
      subTotal
    };
    // let updatedSeatsInModel = this.singleFlight;

    this.orderService.insertOrder(order);
    this.router.navigateByUrl('/flight/public');
  }
}
