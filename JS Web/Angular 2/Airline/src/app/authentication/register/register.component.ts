import { Component, OnInit } from '@angular/core';
import { RegisterModel } from '../models/register.model';
import { AuthService } from '../auth.service';
import {
  FormGroup,
  Validators,
  FormBuilder
} from '@angular/forms';
import { NavBarService } from '../../navigation/navbar.service';
import { PasswordValidation } from '../passwordValidation';
import {
  trigger,
  style,
  transition,
  animate
} from '@angular/animations';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  animations: [
    trigger('fieldFromLeft', [
      transition('void=>*', [
        style({
          opacity: 0,
          transform: 'translateX(-100px)'
        }),
        animate(300)
      ])
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
export class RegisterComponent implements OnInit {
  inputData: RegisterModel;
  registerForm: FormGroup;

  // registerForm = new FormGroup({
  //   'username': new FormControl('', [Validators.required, Validators.minLength(4)]),
  //   'email': new FormControl('', [Validators.required, Validators.email]),
  //   'password': new FormControl('', [Validators.required, Validators.minLength(4)]),
  //   'checkPass': new FormControl('', [Validators.required, Validators.minLength(4)]),
  // }, PasswordValidation.MatchPassword)

  constructor(
    private auth: AuthService,
    private fb: FormBuilder,
    private navBarService: NavBarService
  ) {
    //this.inputData = new RegisterModel('', '', '', false);
  }

  ngOnInit() {
    this.registerForm = this.fb.group({
      username: ['', [Validators.required, Validators.minLength(4)]],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(4)]],
      checkPass: ['', [Validators.required, Validators.minLength(4)]]
    },  {validator: PasswordValidation.MatchPassword});
  }

  register() {
    // console.log(this.inputData);
    // console.log(this.registerForm);

    const { username, email, password } = this.registerForm.value;
    this.inputData = new RegisterModel(username, email, password, false, false);

    this.auth.register(this.inputData).subscribe(res => {
      this.navBarService.setNavBarState(this.inputData.username);
    });
  }
}
