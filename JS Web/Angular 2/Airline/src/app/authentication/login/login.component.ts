import { Component, OnInit } from '@angular/core';
import { LoginModel } from '../models/login.model';
import { AuthService } from '../auth.service';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { NavBarService } from '../../navigation/navbar.service';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  animations: [
    trigger('fieldFromLeft', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(-100px)'
        }),
        animate(300)
      ]),
    ]),
    trigger('fieldFromRight', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(+100px)'
        }),
        animate(300)
      ])
    ]),
    trigger('fieldFromTop', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(-20px)'
        }),
        animate(300)
      ])
    ]),
    trigger('fieldFromBottom', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateY(+100px)'
        }),
        animate(300)
      ])
    ])
  ]
})
export class LoginComponent implements OnInit {
  inputData: LoginModel;
  loginForm: FormGroup

  // loginForm = new FormGroup({
  //   username: new FormControl('', [Validators.required]),
  //   password: new FormControl('', [Validators.required])
  // });

  constructor(private auth: AuthService,private fb: FormBuilder, private navBarService: NavBarService) {
   // this.inputData = new LoginModel('', '');

  }

  ngOnInit() { 
    this.loginForm = this.fb.group({
      username:['', [Validators.required]],
      password:['', [Validators.required]]
    })
  }

  login() {
    //const {username, password} = this.loginForm.value
    this.inputData = this.loginForm.value;

    this.auth.login(this.inputData).subscribe(res => {
      this.navBarService.setNavBarState(this.inputData.username);
    });
  }
}
