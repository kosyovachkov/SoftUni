import observer from '../../scripts/observer';

let validate1 = data=>{
  
    if (data.destination.length < 3) {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Destination must be at least 3 characters'
      });
      return false;
    } else if (data.origin.length < 3) {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Origin must be at least 3 characters'
      });
      return false;
    } else if (data.departureDate === '') {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'You must set appropriate date'
      });
      return false;
    } else if (data.departureTime === '') {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'You must set appropriate time'
      });
      return false;
    } else if (data.seats < 10) {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Number of seat must be greater than 10'
      });
      return false;
    } else if (data.cost <= 0) {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Cost per seat must be greater than $0'
      });
      return false;
    } else if (data.public !== 'yes' && data.public !== 'no') {
      observer.trigger(observer.events.notification, {
        type: 'error',
        message: 'Write "yes" for public, or "no" for nonpublic'
      });
      return false;
    }
    return true;
  
};

export default validate1;
