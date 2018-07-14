import React, { Component } from 'react';
import './App.css';
import Header from './components/common/Header';
import Footer from './components/common/Footer';
import AppRoutes from './components/common/Routes';
import Notification from './components/common/Notification';

class App extends Component {
  render() {
    return (
      <div className="App">
        <Header />
        <Notification />
        <AppRoutes />
        <Footer />
      </div>
    );
  }
}

export default App;
