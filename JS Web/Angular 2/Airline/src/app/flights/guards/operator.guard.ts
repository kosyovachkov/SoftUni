import { Injectable } from '@angular/core'
import { CanActivate, Router } from '@angular/router'
import { AuthService } from '../../authentication/auth.service';

@Injectable()
export class OperatorGuard implements CanActivate {
    constructor(private auth: AuthService, private route: Router) { }
    canActivate() {
        console.log(this.auth.isOperator());
        
        if (this.auth.isAuthenticated() && this.auth.isOperator()) {
            return true
        }
        this.route.navigateByUrl('flight/public')
        return false
    }
}