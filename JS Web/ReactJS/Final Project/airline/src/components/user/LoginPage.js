import React, { Component } from 'react';

import LoginForm from './forms/LoginForm'

import requester from '../../scripts/requester';
import observer from '../../scripts/observer';
import '../../static/css/style.css';

export default class LoginPage extends Component {
  constructor(props) {
    super(props);

    this.state = {
      username: '',
      password: ''
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
    requester.post('user', 'login', 'basic', this.state)
      .then(res => {
        observer.trigger(observer.events.notification, {type: 'success', message:'Login successful!'});
        observer.trigger(observer.events.loggedInUser, res.username);
        sessionStorage.setItem('authtoken', res._kmd.authtoken);
        sessionStorage.setItem('userId', res._id);
        sessionStorage.setItem('isAdmin', res.isAdmin)
        this.props.history.push('/list')
      })
      .catch(err => {
        observer.trigger(observer.events.notification, {type:'error', message: err.responseJSON.description});
      });
  };

  render() {
    return (
      <LoginForm submitHandler={this.submitHandler} changeHandler={this.changeHandler} />
    );
  }
}
