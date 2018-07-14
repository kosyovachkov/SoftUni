import observer from '../../scripts/observer';

let messages = {
  username: 'Username must be at least 4 characters',
  password: 'Password can`t be an empty string or les than 5 characters',
  checkPass: 'Passwords don`t match'
};

let obs = mes => observer.trigger(observer.events.notification, { type: 'error', message: mes });

let validate = data => {
  if (data.username.length < 4) {
    obs(messages['username']);
    return false;
  } else if (data.password === '' || data.password.length < 5) {
    obs(messages['password']);
    return false;
  } else if (data.password !== data.checkPass) {
    obs(messages['checkPass']);
    return false;
  }
  return true;
};

export default validate;
