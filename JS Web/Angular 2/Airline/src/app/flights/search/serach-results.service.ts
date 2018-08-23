import { Injectable } from '@angular/core';
import { FlightModel } from '../models/flight.model';

@Injectable()
export class SearchResultService {
  searchResults: FlightModel[];

  constructor() {}
  getSearchResults() {
    return this.searchResults;
  }

  setSearchResults(data: FlightModel[]) {
    this.searchResults = data;
  }
}
