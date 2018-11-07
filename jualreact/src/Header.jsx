import React, { Component } from 'react';
import { HashRouter as Router, Link } from "react-router-dom";

class Header extends Component {

  render() {
    return (
      <Router>
        <header>
          <h1 className="title"><Link exact to="/">jual<i class="fas fa-bolt lightning" />overflow</Link></h1>
          <form className="search">
            <input placeholder="How Can We Help?" />
            <button>Search <i class="fas fa-search" /></button>
          </form>
        </header>
      </Router>
    );
  }
}

export default Header;