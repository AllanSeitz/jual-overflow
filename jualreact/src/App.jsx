import React, { Component } from 'react';
import Header from './Header.jsx'

class App extends Component {
  render() {
    return (
      <>
        <Header />
        <main>
          <section className="qs">
            <h2><a href="/">How do you solve 1 + 1</a></h2>
            <aside>
              <h2>4 votes</h2>
              <h2>4 answers</h2>
            </aside>
          </section>
        </main>
      </>
    );
  }
}

export default App;
