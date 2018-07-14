import React from 'react';
import { Link } from 'react-router-dom';

import '../../static/css/style.css';

const Flight = props => (
  <span className="added-flight">
    <Link to={`/details/${props._id}`}>
      <img src={props.img} alt={props.destination} className="picture-added-flight" />
      <h3>{props.destination}</h3>
      <span>{props.origin}</span>
      <span>{props.departureDate}</span>
    </Link>
  </span>
);

export default Flight;
