import observer from '../../scripts/observer';

let validate = {
  destination: data => {
    if (data.destination.length < 3) {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Destination must be at least 3 characters'
      });
      return false;
    }
    return true;
  },
  origin: data => {
    if (data.origin.length < 3) {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Origin must be at least 3 characters'
      });
      return false;
    }
    return true;
  },
  departureDate: data => {
    if (data.departureDate === '') {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'You must set appropriate date'
      });
      return false;
    }
    return true;
  },
  departureTime: data => {
    if (data.departureTime === '') {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'You must set appropriate time'
      });
      return false;
    }
    return true;
  },
  seats: data => {
    if (data.seats < 10) {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Number of seat must be greater than 10'
      });
      return false;
    }
    return true;
  },
  cost: data => {
    if (data.cost === '') {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Cost per seat must be greater than $0'
      });
      return false;
    }
    return true;
  },
  public: data => {
    if (data.public !== 'yes' && data.public !== 'no') {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Write "yes" for public, or "no" for nonpublic'
      });
      return false;
    }
    return true;
  }
};

export default validate;
