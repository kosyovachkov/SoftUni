import { Component, OnInit } from '@angular/core';
import { FlightModel } from '../../models/flight.model';
import { FlightService } from '../../flight.service';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-all-flight',
  templateUrl: './all-flight.component.html',
  styleUrls: ['./all-flight.component.css'],
  animations: [
    trigger('allFlightInitialize', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(-100px)'
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
export class AllFlightComponent implements OnInit {
  allFlights: FlightModel[];
  pageSize: number = 3;
  currentPage: number = 1;

  constructor(private flightService: FlightService) {}
  ngOnInit() {
    this.flightService.all().subscribe(res => {
      this.allFlights = res;
    });
  }

  delete(id) {
    this.flightService.delete(id).subscribe();
  }

  pageChanged(event) {
    this.currentPage = event;
  }
}
