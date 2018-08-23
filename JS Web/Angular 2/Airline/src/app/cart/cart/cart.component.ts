import { Component, OnInit } from '@angular/core';
import { CartService } from '../cart-service';
import { CartFlightModel } from '../cartFlight-model';
import { trigger,
  style,
  transition,
  animate} from '@angular/animations';

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
export class CartComponent implements OnInit {
  cart: CartFlightModel[];
  total: number;

  constructor(private cartService: CartService) {}

  ngOnInit() {
    this.cart = this.cartService.getOrder();
    this.total = this.cartService.getTotal();
    this.cartService.cartState$.subscribe(state => (this.total = state));
    // console.log(this.cart);
    // this.total=this.cart.map(e=>e.tickets).reduce((a, b)=>a+b)

    console.log(this.cart);
  }

  delete(id: string, tickets: number) {
    let deletedOrder = this.cart.find(o => o.flightId === id);
    let sumToChange = deletedOrder.subTotal
    this.cartService.deleteOrder(id);
    this.cartService.setCartState(this.total-sumToChange)
  }
}
