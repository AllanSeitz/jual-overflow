import React, { Component } from 'react';
import { HashRouter as Router, Link } from "react-router-dom";

class Header extends Component {

  render() {
    return (
      <Router>
        <header>
          <h1 className="title"><Link to="/">jual<i className="fas fa-bolt lightning" />overload</Link></h1>
          <form className="search">
            <input placeholder="How Can We Help?" />
            <button>Search <i className="fas fa-search" /></button>
          </form>
        </header>
      </Router>
    );
  }
}

export default Header;