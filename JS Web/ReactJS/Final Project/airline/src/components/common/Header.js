import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import UserNavigation from './navigation/UserNavigation';
import GuestNavigation from './navigation/GusetNavigation';
// import requester from '../../scripts/requester';
import observer from '../../scripts/observer';
import '../../static/css/style.css';

export default class Header extends Component {
  constructor(props) {
    super(props);

    this.state = {
      username: ''
    };

    observer.subscribe(observer.events.loggedInUser, this.userLoggedIn);
  }

  userLoggedIn = username => {
    this.setState({ username });
  };

  // logOut=()=>{
  //   requester.post('user', '_logout', 'kinvey').then(res => {
  //     observer.trigger(observer.events.notification, {type: 'success', message:'Logout successful!'});
  //     observer.trigger(observer.events.loggedInUser, null);
  //     sessionStorage.clear();
  //   });
  // }

  render() {
    let navbar = '';
    if (this.state.username || sessionStorage.getItem('authtoken')) {
      navbar = (
        <nav>
          <UserNavigation />
          <div className="right-container">
            <span>Welcome, {this.state.username}</span>
            <Link to="/logout" className="log-out">
              Logout
            </Link>
          </div>
        </nav>
      );
    } else {
      navbar = (
        <nav>
          <GuestNavigation />
        </nav>
      );
    }
    return <div>{navbar}</div>;
  }
}
