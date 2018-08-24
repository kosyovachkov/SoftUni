import { Component, OnInit } from '@angular/core';
import { FlightService } from '../flights/flight.service';
import { FlightModel } from '../flights/models/flight.model';
import { trigger, style, transition, animate } from '@angular/animations';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [FlightService],
  animations: [
    trigger('homeflights', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(-100px)'
        }),
        animate(200)
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
export class HomeComponent implements OnInit {
  flights: FlightModel[];

  constructor(private flightService: FlightService) {}
  ngOnInit() {
    this.flightService.publicForHome().subscribe(res => {
      this.flights = res.sort((a, b) => a.departureDate.localeCompare(b.departureDate));
    });
  }
}
