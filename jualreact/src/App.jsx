import React, { Component } from 'react';
import { HashRouter as Router, Switch, Route } from "react-router-dom";

import Header from './Header.jsx'
import Home from './Home.jsx'
import Details from './Details.jsx'

class App extends Component {
  render() {
    return (
      <Router>
        <>
          <Header />
          <main>
            <Switch>
              <Route exact path="/" component={Home} />
              <Route exact path="/details" component={Details} />
            </Switch>
          </main>
        </>
      </Router>
    );
  }
}

export default App;
