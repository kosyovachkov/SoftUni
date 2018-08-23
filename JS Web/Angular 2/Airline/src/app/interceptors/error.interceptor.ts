import { Injectable } from '@angular/core';
import {
  HttpEvent,
  HttpInterceptor,
  HttpHandler,
  HttpRequest,
  HttpResponse,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';

import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  constructor(private toastr: ToastrService) {}
  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    return next.handle(req).pipe(
      catchError((err: HttpErrorResponse) => {
        switch (err.status) {
          case 400:
            this.toastr.error(err.error.description, 'Warning');
            break;
          case 401:
            this.toastr.error(err.error.description, 'Warning');
            break;
          case 403:
            this.toastr.error(err.error.description, 'Warning');
            break;
          case 404:
            this.toastr.error(err.error.description, 'Warning');
            break;
          case 500:
            this.toastr.error(err.error.description, 'Warning');
            break;
        }
        return throwError(err);
      })
    );
  }
}
