import React from 'react';

const FlightForm = props => (
  <form id="formAddFlight" onSubmit={props.submitHandler}>
    <label>Destination:</label>
    <input type="text" name="destination" onChange={props.changeHandler} placeholder="Destination" defaultValue={props.destination} />
    <label>Origin:</label>
    <input type="text" name="origin" onChange={props.changeHandler} placeholder="Origin" defaultValue={props.origin} />
    <label>Departure Date:</label>
    <input type="date" name="departureDate" onChange={props.changeHandler} defaultValue={props.departureDate} />
    <label>Departure Time:</label>
    <input type="time" name="departureTime" onChange={props.changeHandler} defaultValue={props.departureTime} />
    <label>Number of Seats:</label>
    <input type="number" name="seats" onChange={props.changeHandler} placeholder={0} defaultValue={props.seats} />
    <label>Cost per seat:</label>
    <input type="number" step={1} name="cost" onChange={props.changeHandler} placeholder={0.0} defaultValue={props.cost} />
    <label>Image:</label>
    <input type="text" name="img" onChange={props.changeHandler} placeholder="Image" defaultValue={props.img} />
    <label>Is Public:</label>
    <input type="text" name="public" onChange={props.changeHandler} placeholder="yes / no" defaultValue={props.public} />
    <input type="submit" className="create" defaultValue="Submit" />
  </form>
);

export default FlightForm;
