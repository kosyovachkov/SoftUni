import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { RegisterModel } from './models/register.model';
import { LoginModel } from './models/login.model';

import {kinveyAuth} from './kinvey.auth'

const registerUrl = `https://baas.kinvey.com/user/${kinveyAuth.appKey}`;
const loginUrl = `https://baas.kinvey.com/user/${kinveyAuth.appKey}/login`;
const logoutUrl = `https://baas.kinvey.com/user/${kinveyAuth.appKey}/_logout`;

@Injectable()
export class AuthService {
    constructor(private http: HttpClient) { }

    register(body: RegisterModel) {
      return  this.http.post(registerUrl, body)
    }

    login(body: LoginModel) {
        return  this.http.post(loginUrl, body)
    }

    logout() {
        this.http.post(logoutUrl, '')
       localStorage.clear()
    }

    isAuthenticated() {
        return localStorage.getItem('authtoken') !== null;
    }

    // get user(){
    //     return JSON.parse(localStorage.getItem('loggedInUser'))
    // }

    isAdmin(){
        if(this.isAuthenticated()){
            return JSON.parse(localStorage.getItem('isAdmin'))
        }
        return false
    }

    isOperator(){
        if(localStorage.getItem('isOperator')==='true'){
            return true
        }
        return false
    }

    get username(){
        return localStorage.getItem('username');
    }

    get userId(){
        return localStorage.getItem('id');
    }
}