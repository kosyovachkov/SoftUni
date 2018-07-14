import React, {Component} from 'react';
import { Link } from 'react-router-dom';

export default class MyFlight extends Component {
  render(){
    let deleteLink = ''

    if(sessionStorage.getItem('isAdmin')==='true'){
      deleteLink = <Link  to='/all' className="remove" onClick={()=>this.props.removeFlight(this.props._id)}>REMOVE</Link>
    }else{
      deleteLink = <Link  to='/myFlights' className="remove" onClick={()=>this.props.removeFlight(this.props._id)}>REMOVE</Link>
    }
    
    return(
    <div className="flight-ticket">
      <div className="flight-left">
        <img src={this.props.img} alt={this.props.destination} />
      </div>
      <div className="flight-right">
        <div>
          <h3>{this.props.destination}</h3>
          <span>{this.props.departureDate}</span>
        </div>
        <div>
          from {this.props.origin} <span>{this.props.departureTime}</span>
        </div>
        <p>{this.props.seats} Seats ({this.props.cost}$ per seat) </p>
        {deleteLink}
        <Link to={`/details/${this.props._id}`} className="details">Details</Link>
      </div>
    </div>
    )
  }
};