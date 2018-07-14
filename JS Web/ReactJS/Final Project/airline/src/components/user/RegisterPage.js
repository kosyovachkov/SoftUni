import React, { Component } from 'react';

import RegisterForm from './forms/RegisterForm'

import requester from '../../scripts/requester';
import observer from '../../scripts/observer';
import '../../static/css/style.css';

import validate from '../helpers/validateRegister';

export default class RegisterPage extends Component {
  constructor(props) {
    super(props);

    this.state = {
      username: '',
      password: '',
      isAdmin: false
    };
  }

  changeHandler = event => {
    let fieldName = event.target.name;
    let fieldValue = event.target.value;

    this.setState({
      [fieldName]: fieldValue
    });
  };

  submitHandler = event => {
    event.preventDefault();
    if (!validate(this.state)) {
      return;
    } else {
      let data = { username: this.state.username, password: this.state.password };
      requester
        .post('user', '', 'basic', data)
        .then(res => {
          observer.trigger(observer.events.notification, { type: 'success', message: 'Registration successful!' });
          observer.trigger(observer.events.loggedInUser, res.username);
          sessionStorage.setItem('authtoken', res._kmd.authtoken);
          sessionStorage.setItem('userId', res._id);
          sessionStorage.setItem('isAdmin', res.isAdmin);
          this.props.history.push('/list');
        })
        .catch(err => {
          observer.trigger(observer.events.notification, { type: 'error', message: err.responseJSON.description });
        });
    }
  };

  render() {
    return (
      <RegisterForm submitHandler={this.submitHandler} changeHandler={this.changeHandler}/>
    );
  }
}
