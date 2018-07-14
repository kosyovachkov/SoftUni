import React, { Component } from 'react';

import requester from '../../scripts/requester';
import observer from '../../scripts/observer';
import '../../static/css/style.css';

export default class LoginForm extends Component {
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
      <section id="viewLogin">
        <h2>Login to your account:</h2>
        <form id="formLogin" onSubmit={this.submitHandler}>
          <label>Username:</label>
          <input type="text" name="username" onChange={this.changeHandler} placeholder="Enter your Email" />
          <label>Password:</label>
          <input type="password" name="password" onChange={this.changeHandler} placeholder="Enter your Password" />
          <input type="submit" className="login" value="Login" />
        </form>
      </section>
    );
  }
}
