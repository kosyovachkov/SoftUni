import React, { Component } from 'react';

import requester from '../../scripts/requester';
import observer from '../../scripts/observer';
import '../../static/css/style.css';

export default class RegisterForm extends Component {
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
    if (this.state.username.length < 4) {
      observer.trigger(observer.events.notification, { type: 'error', message: 'Username must be at least 4 characters' });
    } else if (this.state.password === '' || this.state.password.length < 5) {
      observer.trigger(observer.events.notification, { type: 'error', message: 'Password can`t be an empty string or les than 5 characters' });
    } else if (this.state.password !== this.state.checkPass) {
      observer.trigger(observer.events.notification, { type: 'error', message: 'Passwords don`t match' });
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
      <section id="viewRegister">
        <h2>Create your account:</h2>
        <form id="formRegister" onSubmit={this.submitHandler}>
          <label>Username:</label>
          <input type="text" name="username" onChange={this.changeHandler} placeholder="Username" />
          <label>Password:</label>
          <input type="password" name="password" onChange={this.changeHandler} placeholder="Password" />
          <label>Repeat Password:</label>
          <input type="password" name="checkPass" onChange={this.changeHandler} placeholder="Repeat Password" />
          <input type="submit" className="register" value="Register" />
        </form>
      </section>
    );
  }
}
