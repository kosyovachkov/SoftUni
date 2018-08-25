import { Injectable } from '@angular/core';
import { CartFlightModel } from './cartFlight-model';
import { Router } from '@angular/router';
import { NavBarService } from '../navigation/navbar.service';
import { ToastrService } from 'ngx-toastr';
import { Subject } from '../../../node_modules/rxjs';

@Injectable()
export class CartService {
  allOrders: CartFlightModel[] = [];
  // total: number = 0

  constructor(private router: Router, private navBarService: NavBarService, private toastr: ToastrService) { }

  private cartStateTotalSum = new Subject<number>();
  cartState$ = this.cartStateTotalSum.asObservable();

  setCartState(total: number) {
      this.cartStateTotalSum.next(total);
  }

  getOrders() {
    return this.allOrders;
  }

  getTotal() {
    return this.totalPrice();
  }

  insertOrder(order: CartFlightModel) {

    let allOrdersId = this.allOrders.map(e => e.flightId);
    let purchasedId = order.flightId;

    if (allOrdersId.indexOf(purchasedId) > -1) {
      let indexOfOrder = allOrdersId.indexOf(purchasedId);
      let count = this.allOrders.find(e => e.flightId === purchasedId).tickets;
      let subTotal = this.allOrders.find(e => e.flightId === purchasedId).subTotal;

      order.tickets += count;
      order.subTotal+=subTotal;

      this.allOrders.splice(indexOfOrder, 1)
      this.allOrders.push(order);

    } else {
      this.allOrders.push(order);
    }

    this.toastr.success('Order added to your cart.', 'Success!', {timeOut: 1300});
    
    this.navBarService.setNavBarStateOrders(this.allOrders.length);
  }

  deleteOrder(orderId: string) {
    let orderToDel = this.allOrders.find(o => o.flightId === orderId);
    let orderIndex = this.allOrders.indexOf(orderToDel);
    this.allOrders.splice(orderIndex, 1);

    this.toastr.success('Order deleted from your cart.', 'Success', {timeOut: 1300});

    this.navBarService.setNavBarStateOrders(this.allOrders.length);
    this.router.navigateByUrl('/cart');
  }

  checkout(){
    this.navBarService.setNavBarStateOrders(0);
  }

  totalPrice() {
    let sum = 0;
    for (const order of this.allOrders) {
      sum += (order.tickets * order.cost); //sum+=order.subTotal
    }
    return sum
  }
}
