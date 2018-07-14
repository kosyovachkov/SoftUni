import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import requester from '../../scripts/requester';
import '../../static/css/style.css';

import PublicFlight from './PublicFlight';

export default class ListFlights extends Component {
  constructor(props) {
    super(props);

    this.state = {
      flights: []
    };
  }

  componentDidMount() {
    requester.get('appdata', 'flights?query={"public":"yes"}', 'Kinvey').then(res => {
      this.setState({ flights: res });
    });
  }

  render() {
    let allFlights = this.state.flights.map(f => (
      <span className="added-flights" key={f._id}><PublicFlight {...f} /></span>
    ));

    let addFlight = sessionStorage.getItem('authtoken') ? (
      <Link to="/add"><span className="add-flight">Add Flight +</span></Link>
    ) : null;

    return (
      <section id="viewCatalog" className="background-img">
        {addFlight}
        {allFlights}
      </section>
    );
  }
}
