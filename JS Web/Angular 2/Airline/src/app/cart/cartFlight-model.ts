export class CartFlightModel {
  constructor(
    public flightId: string,
    public destination: string,
    public origin: string,
    public departureDate:string,
    public cost: number,
    public seats: number,
    public tickets: number,
    public subTotal:number
  ) {}
}
