import React, { Component } from 'react';

import observer from '../../scripts/observer';
import '../../static/css/style.css';

const DEFAULT_STATE = {
  message: null,
  success: null,
  error: null,
  loading: null
};

export default class Notification extends Component {
  constructor(props) {
    super(props);

    this.state = DEFAULT_STATE;

    observer.subscribe(observer.events.notification, this.showNotification);
  }

  showNotification = data => {
    let message = data.message;
    let type = data.type;
    this.setState({ [type]: type, message: message });
  };

  hideNotification = ev => {
    setTimeout(() => {
      this.setState(DEFAULT_STATE);
    }, 2000);
  };

  render() {
    let notificationId;
    if (this.state.success) {
      notificationId = 'infoBox';
    } else if (this.state.error) {
      notificationId = 'errorBox';
    } else if (this.state.loading) {
      notificationId = 'loadingBox';
    }

    if (this.state.message) {
      return (
        <div id="notifications">
          <div id={notificationId} className="notification" onLoad={this.hideNotification()}>
            <span>{this.state.message}</span>
          </div>
        </div>
      );
    } else {
      return null;
    }
  }
}
