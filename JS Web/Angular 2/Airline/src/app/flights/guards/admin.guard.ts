import { Injectable } from '@angular/core'
import { CanActivate, Router } from '@angular/router'
import { AuthService } from '../../authentication/auth.service';

@Injectable()
export class AdminGuard implements CanActivate {
    constructor(private auth: AuthService, private route: Router) { }
    canActivate() {
        if (this.auth.isAdmin()) {
            return true
        }
        this.auth.logout()
        this.route.navigateByUrl('login')
        return false
    }
}