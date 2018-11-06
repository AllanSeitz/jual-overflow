import React, { Component } from 'react';
import { HashRouter as Router, Link } from "react-router-dom";

class Header extends Component {

  render() {
    return (
      <Router>
        <header>
          <h1 className="title"><Link exact to="/">jual overflow</Link></h1>
          <form className="search">
            <input />
            <button>Search</button>
          </form>
        </header>
      </Router>
    );
  }
}

export default Header;