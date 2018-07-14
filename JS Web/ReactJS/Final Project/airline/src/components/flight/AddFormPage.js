import React, { Component } from 'react';

import request from '../../scripts/requester';
import validate from '../helpers/validateFlight';

import FlightForm from './FlightForm';

export default class AddForm extends Component {
  constructor(props) {
    super(props);

    this.state = {
      destination: '',
      origin: '',
      departureDate: '',
      departureTime: '',
      seats: '',
      cost: '',
      img: '',
      public: '',
      checkbox: ''
    };
  }

  changeHandler = event => {
    const name = event.target.name;
    const value = event.target.value;

    this.setState({ [name]: value });
  };

  submitHandler = event => {
    event.preventDefault();
    if (!validate(this.state)) {
      return;
    } else {
      request.post('appdata', 'flights', 'kinvey', this.state).then(res => {
        this.props.history.push('/list');
      });
    }
  };

  render() {
    return (
      <section id="viewAddFlight">
        <h2>Add new flight</h2>
        <FlightForm changeHandler={this.changeHandler} submitHandler={this.submitHandler} toggle={this.toggle} />
      </section>
    );
  }
}
