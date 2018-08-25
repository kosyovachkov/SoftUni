import { Component, OnInit, OnDestroy } from '@angular/core';
import { CartService } from '../cart-service';
import { CartFlightModel } from '../cartFlight-model';
import { trigger, style, transition, animate} from '@angular/animations';
import { FlightService } from '../../flights/flight.service';
import { FlightModel } from '../../flights/models/flight.model';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
  animations: [
    trigger('fieldFromLeft', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(-100px)'
        }),
        animate(300)
      ])
    ]),
    trigger('fieldFromRight', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(+100px)'
        }),
        animate(300)
      ]),
    ]),
    trigger('fieldToRight', [
      transition('*=>void', [
        animate(300, style({
        opacity: 0,
        transform: 'translateX(-100px)'
      }))
    ])
    ])
  ]
})
export class CartComponent implements OnInit, OnDestroy {
  cart: CartFlightModel[];
  total: number; //to show total cost of all orders in the cart
  entity: FlightModel; // to update the entity if seats are taken

  constructor(private cartService: CartService, private flightService: FlightService) {}

  ngOnInit() {
    this.cart = this.cartService.getOrders();
    this.total = this.cartService.getTotal();

    this.cartService.cartState$.subscribe(state => (this.total = state));

    localStorage.setItem('displayCart', 'true'); //I`m using this for request with super credentilas in interceptor
    // console.log(this.cart);
    // this.total=this.cart.map(e=>e.tickets).reduce((a, b)=>a+b)
  }

  delete(id: string, tickets: number) {
    let deletedOrder = this.cart.find(o => o.flightId === id);
    let sumToChange = deletedOrder.subTotal;
    
    this.cartService.deleteOrder(id);
    
    this.cartService.setCartState(this.total - sumToChange);
  }
  
  checkout(){
    for (let order of this.cart) {
      order.seats -= order.tickets;

      const {destination, origin, departureDate, departureTime, seats, cost, image, isPublished} = order;
        this.entity = {destination, origin, departureDate, departureTime, seats, cost, image, isPublished};
        this.flightService.edit(order.flightId, this.entity).subscribe();
      }

      this.cart = [];
      this.cartService.allOrders = [];
      this.cartService.setCartState(0);
      this.cartService.checkout();
  }

  ngOnDestroy(){
    localStorage.removeItem('displayCart');
  }
}
