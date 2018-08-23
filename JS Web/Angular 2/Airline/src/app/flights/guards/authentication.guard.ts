import { Injectable } from '@angular/core'
import { CanActivate, Router } from '@angular/router'
import { AuthService } from '../../authentication/auth.service';

@Injectable()
export class AuthenticationGuard implements CanActivate {
    constructor(private auth: AuthService, private route: Router) { }
    canActivate() {
        if (this.auth.isAuthenticated()) {
            return true
        }
        this.route.navigateByUrl('login')
        return false
    }
}