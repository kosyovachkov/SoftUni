export class FlightModel {
  constructor(
    public destination: string,
    public origin: string,
    public departureDate: string,
    public departureTime: string,
    public seats: number,
    public cost: number,
    public image: string,
    public isPublished: boolean
  ) {}
}
