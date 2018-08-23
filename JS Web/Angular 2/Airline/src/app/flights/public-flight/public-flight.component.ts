import { Component, OnInit } from '@angular/core';
import { FlightService } from '../flight.service';
import { FlightModel } from '../models/flight.model';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-public-flight',
  templateUrl: './public-flight.component.html',
  styleUrls: ['./public-flight.component.css'],
  animations: [
    trigger('publicFlightInitialize', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(-100px)'
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
export class PublicFlightComponent implements OnInit {
  publicFlights: FlightModel[];
  pageSize: number = 3;
  currentPage: number = 1;

  constructor(private flightService: FlightService) {}

  ngOnInit() {
    this.flightService.allPublic().subscribe(res => {
      this.publicFlights = res.sort((a,b)=>a.departureDate.localeCompare(b.departureDate));
    });
  }

  pageChanged(event) {
    this.currentPage = event;
  }
}
