import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms' // под въпрос...
import { AppRoutingModule } from './routing.module'
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AuthModule} from './authentication/auth.module'
import { CartComponent} from './cart/cart/cart.component'

import { AppComponent } from './app.component';
import { NavigationComponent } from './navigation/navigation.component';
import { HomeComponent} from './home/home.component'

import { AuthTokenInterceptor } from './interceptors/authtoken.interceptor'
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { AuthService } from './authentication/auth.service';
import { NavBarService } from './navigation/navbar.service';
import { CartService } from './cart/cart-service'

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    HomeComponent,
    CartComponent
  ],
  imports: [
    BrowserModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    AuthModule
  ],
  providers: [
    AuthService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthTokenInterceptor,
      multi: true
    }, 
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ErrorInterceptor,
      multi: true
    }, 
    NavBarService,
    CartService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
