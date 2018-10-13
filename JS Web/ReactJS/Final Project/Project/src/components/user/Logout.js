import React, { Component } from 'react';
import { Redirect } from 'react-router-dom';

import requester from '../../scripts/requester';
import observer from '../../scripts/observer';

class Logout extends Component {
  componentDidMount() {
    requester.post('user', '_logout', 'kinvey').then(res => {
      observer.trigger(observer.events.notification, { type: 'success', message: 'Logout successful!' });
      sessionStorage.clear();
      observer.trigger(observer.events.loggedInUser, null);
    });
  }
  render() {
    return <Redirect to="/" />;
  }
}

export default Logout;
