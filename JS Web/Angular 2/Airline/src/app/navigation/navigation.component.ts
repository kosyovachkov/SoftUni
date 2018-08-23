import { Component, OnInit } from '@angular/core';
import { AuthService } from '../authentication/auth.service';
import { NavBarService } from './navbar.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {
  name: string;
  orders:number = 0

  constructor(
    private auth: AuthService,
    private navBarService: NavBarService,
    private toastr: ToastrService
  ) {
    this.navBarService.navState$.subscribe(state => (this.name = state));
    this.navBarService.navState2$.subscribe(state => (this.orders = state));
  }

  ngOnInit() {
    if (this.auth.isAuthenticated) {
      this.name = localStorage.getItem('username');
    }
  }

  // isAdmin(){
  //   if(this.auth.isAdmin){
  //     return true
  //   }
  //   return false
  // }

  // isAuthenticated(){
  //   if(this.auth.isAuthenticated){
  //     return true
  //   }
  //   return false
  // }

  // getCurrentLoggedInUsername(){
  //   if (this.auth.isAuthenticated()) {
  //     this.name = this.auth.username
  //   }
  // }

  logout() {
    this.toastr.success('Logout successfull.', 'Success!');
    this.auth.logout();
  }
}
