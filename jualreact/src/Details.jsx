import React, { Component } from 'react';
import { HashRouter as Router, Switch, Route, Link } from "react-router-dom";

class Details extends Component {

  render() {
    return (
      <div>
        <section>
          <h2>title here</h2>
          <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam, distinctio ut commodi ex odit magnam accusamus quis dignissimos maiores vero provident fuga debitis minima laudantium rerum voluptate vel quo beatae.</p>
        </section>
        <section>
          <p>answer</p>
        </section>
      </div>
    );
  }
}

export default Details;