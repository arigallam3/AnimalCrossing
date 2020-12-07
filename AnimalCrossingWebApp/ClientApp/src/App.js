import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Villager } from './components/content/Villager';

import './custom.css'
import Fish from './components/Fish';
import Bug from './components/Bug';
import { SpecialCharacter } from './components/content/SpecialCharacter';



export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/fish' component={Fish} />
            <Route path='/bug' component={Bug} />
            <Route path='/villager' component={Villager} />
            <Route path='/special-character' component={SpecialCharacter} />
      </Layout>
    );
  }
}
