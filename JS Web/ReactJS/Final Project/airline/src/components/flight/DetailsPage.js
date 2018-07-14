import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import requester from '../../scripts/requester';

export default class Details extends Component {
  constructor(props) {
    super(props);

    this.state = {
      flight: {}
    };
  }

  componentDidMount() {
    let flightId = this.props.match.params.id;
    requester.get('appdata', `flights/${flightId}`, 'kinvey').then(res => {
      sessionStorage.setItem('creator', res._acl.creator);
      this.setState({ flight: res });
    });
  }

  componentWillUnmount(){
    sessionStorage.removeItem('creator');
  }

  render() {
    let edit = '';
    if (sessionStorage.getItem('userId') === sessionStorage.getItem('creator') || sessionStorage.getItem('isAdmin')==='true') {
      edit = <Link to={`/edit/${this.state.flight._id}`} className="edit-flight-detail" />;
    }
    return (
      <section id="viewFlightDetails">
        <div className="ticket-area">
          <div className="ticket-area-left">
            <img src={this.state.flight.img} alt={this.state.flight.destination} />
          </div>
          <div className="ticket-area-right">
            <h3>{this.state.flight.destination}</h3>
            <div>from {this.state.flight.origin}</div>
            <div className="data-and-time">
              {this.state.flight.departureDate} {this.state.flight.departureTime}
              {edit}
            </div>
            <div>
              {this.state.flight.seats} Seats ({this.state.flight.cost} per seat)
            </div>
          </div>
        </div>
      </section>
    );
  }
}
