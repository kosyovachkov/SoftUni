import { Component, OnInit } from '@angular/core';
import { SearchResultService } from '../serach-results.service';
import { FlightModel } from '../../models/flight.model';
import { trigger, style, transition, animate } from '@angular/animations';

@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.css'],
  animations: [
    trigger('searchedResultFlights', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(-100px)'
        }),
        animate(300)
      ])
    ])
  ]
})
export class SearchResultsComponent implements OnInit {
  searchedPublicFlights: FlightModel[];
  isResult: boolean;
  pageSize: number = 3;
  currentPage: number = 1;
  constructor(private searchResults: SearchResultService) {}

  ngOnInit() {
    this.searchedPublicFlights = this.searchResults.getSearchResults();
    if (this.searchedPublicFlights.length > 0) {
      this.isResult = true;
    }
  }
}
