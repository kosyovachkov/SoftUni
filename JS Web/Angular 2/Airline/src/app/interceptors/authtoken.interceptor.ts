import { Injectable } from '@angular/core';
import {
  HttpEvent,
  HttpInterceptor,
  HttpHandler,
  HttpRequest,
  HttpResponse
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';

import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

import { kinveyAuth } from '../authentication/kinvey.auth';

@Injectable()
export class AuthTokenInterceptor implements HttpInterceptor {
  constructor(private toastr: ToastrService, private router: Router) {}
  intercept(
    request: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    let authtoken = localStorage.getItem('authtoken');

    if (authtoken) {
      request = request.clone({
        setHeaders: {
          Authorization: `Kinvey ${authtoken}`
        }
      });
    }  else if(!authtoken && request.url.endsWith(`?query={"isPublished":true}&limit=3`)) {
      request = request.clone({
        setHeaders:{
          Authorization:`Basic ${btoa(
            kinveyAuth.appKey + ':' + kinveyAuth.appMasterSecret
          )}`
        }
      })
    }else {
      request = request.clone({
        setHeaders: {
          Authorization: `Basic ${btoa(
            kinveyAuth.appKey + ':' + kinveyAuth.appSecret
          )}`
        }
      });
    }

    return next.handle(request).pipe(
      tap((res: any) => {
        if (res instanceof HttpResponse && res.ok === true) {

          if (res.url.endsWith(`/${kinveyAuth.appKey}`) && res.status === 201) {
            this.toastr.success('User successfully created.', 'Success!', { timeOut: 1300 });
            this.saveToken(res.body);
            this.router.navigateByUrl('flight/public')
          }
          if (res.url.endsWith(`/login`)) {
            this.toastr.success('User successfully logged in.', 'Success!', { timeOut: 1300 });
            this.saveToken(res.body);
            this.router.navigateByUrl('flight/public')
          }
          if (res.url.endsWith(`/flights`) && res.status === 201) {
            this.toastr.success('Flight successfully created.', 'Success!');
            this.router.navigateByUrl('flight/public')
          }
          if (res.body.count === 1) {
           //window.location.reload();
            this.toastr.success('Item removed successfully.', 'Success!');
            this.router.navigateByUrl('flight/public')
          }
        }
      })
    );
  }

  private saveToken(data) {
    localStorage.setItem('id', data._id);
    localStorage.setItem('username', data.username);
    localStorage.setItem('authtoken', data._kmd.authtoken);
    localStorage.setItem('isAdmin', data.isAdmin);
    localStorage.setItem('isOperator', data.isOperator);
  }
}
