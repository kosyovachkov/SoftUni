export class CartFlightModel {
  constructor(
    public flightId: string,
    public destination: string,
    public origin: string,
    public departureDate: string,
    public departureTime: string,
    public seats: number,
    public cost: number,
    public image: string,
    public isPublished: boolean,
    public tickets: number,
    public subTotal: number
  ) {}
}
