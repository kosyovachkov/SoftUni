import { Injectable } from '@angular/core'
import { Subject } from 'rxjs'

@Injectable()
export class NavBarService {
    private navStateUsername = new Subject<string>();
    private navStateOrders = new Subject<number>();
    
    navState$ = this.navStateUsername.asObservable();
    navState2$ = this.navStateOrders.asObservable();

    setNavBarState(username: string) {
        this.navStateUsername.next(username);
    }
    setNavBarStateOrders(orders: number) {
        this.navStateOrders.next(orders);
    }
}