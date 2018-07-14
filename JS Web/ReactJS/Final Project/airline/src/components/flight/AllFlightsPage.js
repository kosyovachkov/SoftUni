import React, { Component } from 'react';

import requester from '../../scripts/requester';
import '../../static/css/style.css';

import MyFlight from './entities/MyFlight';

export default class MyFlights extends Component {
  constructor(props) {
    super(props);

    this.state = {
      flights: []
    };
  }

  removeFlightFromState = flightId => {
    requester.remove('appdata', `flights/${flightId}`, 'kinvey').then(r=>{
      this.setState(prevState => {
        prevState.flights = prevState.flights.filter(obj=>obj._id !== flightId)
        return prevState
        })

      })
  }

  getAllFlights = () => {
    requester.get('appdata', 'flights', 'Kinvey').then(res => {
      this.setState({ flights: res });
    });
  };

  componentDidMount() {
    this.getAllFlights();
  }

  render() {
    let allFlights = this.state.flights.map(f => <MyFlight key={f._id} {...f} removeFlight={this.removeFlightFromState}/>);
    return (
      <section id="viewMyFlights">
        <h3>All Flights</h3>
        {allFlights}
      </section>
    );
  }
}
