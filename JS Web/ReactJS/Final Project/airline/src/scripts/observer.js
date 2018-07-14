let subscriptions = {
  'loggedInUser': [],
  'notification':[] 
};

export default {
  events: {
    loggedInUser: 'loggedInUser',
    notification: 'notification'
  },
  subscribe: (eventName, func) => {
    subscriptions[eventName].push(func);
  },
  trigger: (eventName, data) => {
    subscriptions[eventName].forEach(fn => fn(data));
  }
};
