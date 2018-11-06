import React, { Component } from 'react';
import { HashRouter as Router, Switch, Route, Link } from "react-router-dom";

class Home extends Component {

  render() {
    return (
      <Router>
        <>
          <section className="qs">
            <h2><Link to="/details">How do you solve 1 + 1</Link></h2>
            <aside>
              <h2>4 votes</h2>
              <h2>4 answers</h2>
            </aside>
          </section>
        </>
      </Router>
    );
  }
}

export default Home;