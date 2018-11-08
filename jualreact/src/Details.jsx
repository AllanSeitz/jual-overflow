import React, { Component } from 'react';
import { HashRouter as Router, Switch, Route, Link } from "react-router-dom";

class Details extends Component {

  render() {
    return (
      <div className="main-div">
        <section>
          <h2>title here</h2>
          <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam, distinctio ut commodi ex odit magnam accusamus quis dignissimos maiores vero provident fuga debitis minima laudantium rerum voluptate vel quo beatae.</p>
        </section>
        <section>
          <p>answer</p>
        </section>
        <section>
          <form className="ask-form">
            <textarea className="qa-form" placeholder="" />
            <aside>
              <button className="ask">Submit</button>
            </aside>
          </form>
        </section>
      </div>
    );
  }
}

export default Details;