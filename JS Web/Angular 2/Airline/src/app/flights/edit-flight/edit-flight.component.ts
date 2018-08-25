import { Component, OnInit } from '@angular/core';
import { FlightModel } from '../models/flight.model';
import {
  FormGroup,
  FormControl,
  Validators,
  FormBuilder
} from '@angular/forms';
import { FlightService } from '../flight.service';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-edit-flight',
  templateUrl: './edit-flight.component.html',
  styleUrls: ['./edit-flight.component.css'],
  animations: [
    trigger('fieldFromLeft', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(-100px)'
        }),
        animate(300)
      ])
    ]),
    trigger('fieldFromRight', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(+100px)'
        }),
        animate(300)
      ])
    ]),
    trigger('fieldFromTop', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(-20px)'
        }),
        animate(300)
      ])
    ]),
    trigger('fieldFromBottom', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(+100px)'
        }),
        animate(300)
      ])
    ])
  ]
})
export class EditFlightComponent implements OnInit {
  flightToEdit: FlightModel;
  editForm: FormGroup;
  id: string;

  constructor(
    private flightService: FlightService,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private toastr: ToastrService,
    private router: Router
  ) {}

  ngOnInit() {
    this.id = this.route.snapshot.params.id;
    this.flightService.flight(this.id).subscribe(res => {
      this.flightToEdit = res;

      // this.editForm = new FormGroup({
      //   destination: new FormControl(res.destination, [Validators.required, Validators.minLength(3)]),
      //   origin: new FormControl(res.origin, [Validators.required, Validators.minLength(3)]),
      //   departureDate: new FormControl(res.departureDate, [Validators.required]),
      //   departureTime: new FormControl(res.departureTime, [Validators.required]),
      //   seats: new FormControl(res.seats, [Validators.required, Validators.min(10)]),
      //   cost: new FormControl(res.cost, [Validators.required, Validators.min(0.99)]),
      //   image: new FormControl(res.image),
      //   isPublished: new FormControl(res.isPublished)
      // })

      this.editForm = this.fb.group({
        destination: [res.destination,[Validators.required, Validators.minLength(3)]],
        origin: [res.origin, [Validators.required, Validators.minLength(3)]],
        departureDate: [res.departureDate, [Validators.required]],
        departureTime: [res.departureTime, [Validators.required]],
        seats: [res.seats, [Validators.required]],
        cost: [res.cost, [Validators.required, Validators.min(0.99)]],
        image: [res.image],
        isPublished: [res.isPublished]
      });
    });
  }

  edit() {
    // const {
    //   destination,
    //   origin,
    //   departureDate,
    //   departureTime,
    //   seats,
    //   cost,
    //   image,
    //   isPublished
    // } = this.editForm.value;

    // this.flightToEdit = new FlightModel(
    //   destination,
    //   origin,
    //   departureDate,
    //   departureTime,
    //   seats,
    //   cost,
    //   image,
    //   isPublished
    // );

    this.flightService.edit(this.id, this.editForm.value).subscribe(res => {
      this.toastr.success('Flight successfully edited', 'Success!', { timeOut: 1300 });
      this.router.navigateByUrl('/flight/my');
    });
  }
}
