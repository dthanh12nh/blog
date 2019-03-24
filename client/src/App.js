import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component {
  render() {
    return (
      <nav id="navigation">
        <div id="navigation-title">
          <a href="http://localhost:3000">
            TH Blog
          </a>
        </div>
        <div id="navigation-search">
          <input type="text" id="navigation-search-input" />
          <button id="navigation-search-button">Search</button>
        </div>
      </nav>
    );
  }
}

export default App;
