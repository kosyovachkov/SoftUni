import React, { Component } from 'react';

import requester from '../../scripts/requester';
import '../../static/css/style.css';

import MyFlight from './MyFlight';

export default class MyFlights extends Component {
  constructor(props) {
    super(props);

    this.state = {
      flights: []
    };
  }

  removeFlightFromState = flightId => {
    requester.remove('appdata', `flights/${flightId}`, 'kinvey').then(res => {
      this.setState(prevState => {
        prevState.flights = prevState.flights.filter(obj => obj._id !== flightId);
        return prevState;
      });
    });
  };

  getAllFlights = userId => {
    requester.get('appdata', `flights?query={"_acl.creator":"${userId}"}`, 'Kinvey').then(res => {
      this.setState({ flights: res });
    });
  };

  componentDidMount() {
    this.getAllFlights(sessionStorage.getItem('userId'));
  }

  render() {
    let myFlights = this.state.flights.map(f => <MyFlight key={f._id} {...f} removeFlight={this.removeFlightFromState} />);
    return (
      <section id="viewMyFlights">
        <h3>My Flights</h3>
        {myFlights}
      </section>
    );
  }
}
