import React, { Component } from 'react';

export class TicketComponent extends Component {
  displayName = TicketComponent.name

  constructor(props) {
    super(props);
    this.state = { tickets: [], loading: true };

    fetch('api/Ticket/GetAlls')
      .then(response => response.json())
      .then(data => {
          this.setState({ tickets: data, loading: false });
          console.log(this.state)
      });
  }

  static renderTicketTable(tickets) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>ID</th>
            <th>URL</th>
            <th>Status(F)</th>
          </tr>
        </thead>
        <tbody>
          {tickets.map(data =>
            <tr key={data.id}>
              <td>{data.id}</td>
              <td>{data.url}</td>
              <td>{data.status}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : TicketComponent.renderTicketTable(this.state.tickets);

    return (
      <div>
        <h1>Tickets</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }
}

