import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { AdminData } from './components/AdminData';
import { GettingInfoFromDatabase } from './components/GettingInfoFromDatabase';
import { TicketComponent } from './components/TicketComponent';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
         <Route path='/fetchdata' component={FetchData} />
            <Route path='/admindata' component={AdminData} />
            <Route path='/databaseinfo' component={GettingInfoFromDatabase}/>
            <Route path='/TicketInfo' component={TicketComponent}/>
      </Layout>
    );
  }
}
