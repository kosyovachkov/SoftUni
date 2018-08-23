import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { FlightService } from '../../flight.service';
import { SearchResultService } from '../serach-results.service';
import { FlightModel } from '../../models/flight.model';
import { Router } from '@angular/router';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-search-flight',
  templateUrl: './search-flight.component.html',
  styleUrls: ['./search-flight.component.css'],
  animations: [
    trigger('fieldFromTop', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(-20px)'
        }),
        animate(500)
      ])
    ])
  ]
})
export class SearchFlightComponent implements OnInit {
  //searchedPublicFlights: FlightModel[]
  searchForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private flightService: FlightService,
    private searchResults: SearchResultService,
    private route: Router
  ) {}

  ngOnInit() {
    this.searchForm = this.fb.group({
      destination: [''],
      origin: ['']
    });
  }

  search() {
    //console.log(this.searchForm.value);
    const searchDestination =
      this.searchForm.value['destination'].charAt(0).toUpperCase() +
      this.searchForm.value['destination'].slice(1).toLowerCase();

    const searchOrigin =
      this.searchForm.value['origin'].charAt(0).toUpperCase() +
      this.searchForm.value['origin'].slice(1).toLowerCase();

    // console.log(searchDestination);
    // console.log(searchOrigin);
    if (searchDestination || searchOrigin) {
      this.flightService
        .search(searchDestination, searchOrigin)
        .subscribe(res => {
          // console.log(res);
          //this.searchedPublicFlights=res
          this.searchResults.setSearchResults(res);
          this.route.navigate(['flight/search/results']);
        });
    }
  }
}
