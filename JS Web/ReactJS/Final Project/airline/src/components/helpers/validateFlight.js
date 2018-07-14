import observer from '../../scripts/observer';

let messages = {
  destination: 'Destination must be at least 3 characters',
  origin: 'Origin must be at least 3 characters',
  departureDate: 'You must set appropriate date',
  departureTime: 'You must set appropriate time',
  seats: 'Number of seat must be greater than 10',
  cost: 'Cost per seat must be greater than $0',
  public: 'Write "yes" for public, or "no" for nonpublic'
};

let obs = mes => observer.trigger(observer.events.notification, { type: 'error', message: mes });

let validate = data => {
  if (data.destination.length < 3) {
    obs(messages['destination']);
    return false;
  } else if (data.origin.length < 3) {
    obs(messages['origin']);
    return false;
  } else if (data.departureDate === '') {
    obs(messages['departureDate']);
    return false;
  } else if (data.departureTime === '') {
    obs(messages['departureTime']);
    return false;
  } else if (data.seats < 10) {
    obs(messages['seats']);
    return false;
  } else if (data.cost <= 0) {
    obs(messages['cost']);
    return false;
  } else if (data.public !== 'yes' && data.public !== 'no') {
    obs(messages['public']);
    return false;
  }
  return true;
};

export default validate;
