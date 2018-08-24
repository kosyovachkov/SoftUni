import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegisterComponent } from './authentication/register/register.component';
import { LoginComponent } from './authentication/login/login.component';
import { HomeComponent } from './home/home.component';
import { FlightModule } from './flights/flight.module';
import { CartComponent } from './cart/cart/cart.component';
import { AuthenticationGuard } from './flights/guards/authentication.guard';

const routes: Routes = [
  { path: '', pathMatch:'full', component:HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'cart', component: CartComponent, canActivate:[AuthenticationGuard] },
  { path: 'flight', loadChildren: () => FlightModule},
  { path: '**', component: RegisterComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  providers: [ AuthenticationGuard ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
