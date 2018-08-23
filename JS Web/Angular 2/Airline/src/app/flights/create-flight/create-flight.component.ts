import { Component, OnInit } from '@angular/core';
import { FlightModel } from '../models/flight.model';
import {
  FormGroup,
  FormControl,
  Validators,
  FormBuilder
} from '@angular/forms';
import { FlightService } from '../flight.service';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-create-flight',
  templateUrl: './create-flight.component.html',
  styleUrls: ['./create-flight.component.css'],
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
export class CreateFlightComponent implements OnInit {
  

// flight: FlightModel;

//   createForm = new FormGroup({
//     destination: new FormControl('', [Validators.required, Validators.minLength(3)]),
//     origin: new FormControl('', [Validators.required, Validators.minLength(3)]),
//     departureDate: new FormControl('', [Validators.required]),
//     departureTime: new FormControl('', [Validators.required]),
//     seats: new FormControl('', [Validators.required, Validators.min(10)]),
//     cost: new FormControl('', [Validators.required, Validators.min(0.99)]),
//     image: new FormControl(''),
//     isPublished: new FormControl('')
//   });

  createForm: FormGroup;

  constructor(private flightService: FlightService, private fb: FormBuilder) {
    //this.flight = new FlightModel('', '', '', '', 0, 0, '', false);
  }

  ngOnInit() {
    this.createForm = this.fb.group({
      destination: ['', [Validators.required, Validators.minLength(3)]],
      origin: ['', [Validators.required, Validators.minLength(3)]],
      departureDate: ['', [Validators.required]],
      departureTime: ['', [Validators.required]],
      seats: ['', [Validators.required, Validators.min(10)]],
      cost: ['', [Validators.required, Validators.min(0.99)]],
      image: [''],
      isPublished: ['']
    });
  }

  create() {
    // const {
    //   destination,
    //   origin,
    //   departureDate,
    //   departureTime,
    //   seats,
    //   cost,
    //   image,
    //   isPublished
    // } = this.createForm.value;

    // this.flight = new FlightModel(
    //   destination,
    //   origin,
    //   departureDate,
    //   departureTime,
    //   seats,
    //   cost,
    //   image,
    //   isPublished
    // );
    this.flightService.create(this.createForm.value).subscribe();
  }
}