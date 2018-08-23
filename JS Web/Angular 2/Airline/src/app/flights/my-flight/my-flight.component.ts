import { Component, OnInit } from '@angular/core';
import { FlightService } from '../flight.service';
import { FlightModel } from '../models/flight.model';
import { ToastrService } from 'ngx-toastr';
import {
  trigger,
  state,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-my-flight',
  templateUrl: './my-flight.component.html',
  styleUrls: ['./my-flight.component.css'],
  animations: [
    trigger('myFlightInitialize', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(-100px)'
        }),
        animate(300)
      ])
    ]),
    trigger('noFlight', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(+10px)'
        }),
        animate(300)
      ])
    ]),
    trigger('titleInitialize', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(0px)'
        }),
        animate(500)
      ])
    ])
  ]
})
export class MyFlightComponent implements OnInit {
  myFlights: FlightModel[];
  pageSize: number = 3;
  currentPage: number = 1;

  constructor(private flightService: FlightService, private toastr: ToastrService) {}

  ngOnInit() {
    const id = localStorage.getItem('id');

    this.flightService.myFlights(id).subscribe(res => {
      this.myFlights = res;
    });
  }

  delete(id) {
    this.flightService.delete(id).subscribe()
  }

  pageChanged(event){
    this.currentPage = event
  }
}
