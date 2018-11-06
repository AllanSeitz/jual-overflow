import React, { Component } from 'react';

class Header extends Component {

  render() {
    return (
      <header>
        <h1 className="title">jual overflow</h1>
        <form className="search">
          <input />
          <button>Search</button>
        </form>
      </header>
    );
  }
}

export default Header;