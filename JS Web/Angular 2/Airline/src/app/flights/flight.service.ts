import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FlightModel } from './models/flight.model';
import { kinveyAuth } from '../authentication/kinvey.auth';
import { DetailedModel } from './models/detailed.model';

const flightUrl = `https://baas.kinvey.com/appdata/${kinveyAuth.appKey}/flights`;


@Injectable()
export class FlightService {
  constructor(private http: HttpClient) { }

  create(data: FlightModel) {
    return this.http.post(flightUrl, data);
  }

  allPublic() {
    return this.http.get<FlightModel[]>(flightUrl + '?query={"isPublished":true}')
  }
  publicForHome() {
    return this.http.get<FlightModel[]>(flightUrl + '?query={"isPublished":true}&limit=3')
  }

  all() {
    return this.http.get<FlightModel[]>(flightUrl)
  }

  edit(id: string, data: FlightModel) {
    return this.http.put(flightUrl +'/' + id, data)
  }

  details(id: string) {
    return this.http.get<DetailedModel>(flightUrl +'/' + id)
  }

  flight(id: string) {
    return this.http.get<FlightModel>(flightUrl +'/' + id)
  }

  myFlights(id:string){
    return this.http.get<FlightModel[]>(flightUrl + `?query={"_acl.creator":"${id}"}`)
  }

  delete(id:string){
  return this.http.delete(flightUrl + '/' + id)
  }

  search(destination?: string, origin?: string){
    if(destination && origin){
      return this.http.get<FlightModel[]>(flightUrl + `?query={"$and":[{"destination":"${destination}"}, {"origin":"${origin}"}, {"isPublished":true}]}`)
    }else if(destination){
        return this.http.get<FlightModel[]>(flightUrl + `?query={"$and":[{"destination":"${destination}"}, {"isPublished":true}]}`)
      }else if(origin){
        return this.http.get<FlightModel[]>(flightUrl + `?query={"$and":[{"origin":"${origin}"}, {"isPublished":true}]}`)
      }
  }
}
