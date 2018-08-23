import { Injectable } from '@angular/core'
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from "@angular/router"
import { AuthService } from '../../authentication/auth.service';
import { FlightService } from '../flight.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class AuthorGuard implements CanActivate {
    constructor(private auth: AuthService, private flight: FlightService, private route: Router) { }

    canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {

        const flightId = next.params['id']

        return this.flight.details(flightId).pipe(map(res => {
            if(this.auth.isAdmin() || this.auth.userId === res['_acl']['creator']){
                return true;
            }
            this.route.navigateByUrl('flight/public')
            return false;
        }));
    }
}