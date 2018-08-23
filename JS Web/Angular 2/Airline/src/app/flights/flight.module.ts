import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { flightComponents } from '.';
import { FlightService } from './flight.service';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { FlighRoutingModule } from './flight-routing.module';
import { NgxPaginationModule } from 'ngx-pagination';
import { SearchResultService } from './search/serach-results.service';

@NgModule({
  declarations: [...flightComponents],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    FlighRoutingModule,
    NgxPaginationModule
  ],
  providers: [FlightService, SearchResultService]
})
export class FlightModule {}
