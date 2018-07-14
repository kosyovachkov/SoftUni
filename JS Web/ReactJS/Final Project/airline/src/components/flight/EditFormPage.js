import React, { Component } from 'react';

import requester from '../../scripts/requester';
import validate from '../helpers/validateFlight';

import FlightForm from './forms/FlightForm';

export default class EditForm extends Component {
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
      public: ''
    };

    this.changeHandler = this.changeHandler.bind(this);
  }

  componentDidMount() {
    let flightId = this.props.match.params.id;
    requester.get('appdata', `flights/${flightId}`, 'kinvey').then(res => {
      this.setState({ ...res });
    });
  }

  changeHandler(event) {
    const name = event.target.name;
    const value = event.target.value;

    this.setState({ [name]: value });
  }

  submitHandler = event => {
    event.preventDefault();
    if (!validate(this.state)) {
      return;
    } else {
      requester.update('appdata', `flights/${this.props.match.params.id}`, 'kinvey', this.state).then(res => {
        if(sessionStorage.getItem('isAdmin')==='true'){
          this.props.history.push('/all');
        }else{
          this.props.history.push('/MyFlights');
        }
      });
    }
  };

  render() {
    return (
      <section id="viewEditFlight">
        <h2>Edit existing flight</h2>
        <FlightForm changeHandler={this.changeHandler} submitHandler={this.submitHandler} {...this.state} />
      </section>
    );
  }
}
