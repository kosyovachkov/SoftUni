import React, { Component } from 'react';
import {Link} from 'react-router-dom'

export default class UserNavigation extends Component {
  render() {
    let adminButton = '';
    if (sessionStorage.getItem('isAdmin') === 'true') {
      adminButton = (
        <li>
          <Link to="/all">All Flights</Link>
        </li>
      );
    }
    return (
        <div className="left-container">
          <ul>
            <li>
              <Link to="/list">Home</Link>
            </li>
            <li>
              <Link to="/myFlights">My Flights</Link>
            </li>
            {adminButton}
          </ul>
        </div>
    );
  }
}
