import React, { Component } from 'react';
import { HashRouter as Router, Switch, Route, Link } from "react-router-dom";

class Home extends Component {

  render() {
    return (
      <Router>
        <div>
          <section className="qs">
            <h2><Link to="/details">How do you solve 1 + 1</Link></h2>
            <aside>
              <h2>4 votes</h2>
              <h2>4 answers</h2>
            </aside>
          </section>
          <section>
            <form>
              <aside>
                <input className="q-title" placeholder="Title" />
                <button className="ask">Submit</button>
              </aside>
              <textarea className="qa-form" placeholder="Ask away..." />
            </form>
          </section>
        </div>
      </Router>
    );
  }
}

export default Home;