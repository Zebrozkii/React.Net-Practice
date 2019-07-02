
import React, { Component } from 'react';

export class GettingInfoFromDatabase extends Component {
  displayName = GettingInfoFromDatabase.name

  constructor(props) {
    super(props);
    this.state = {datastuff: [], loading: true };
     
      fetch('api/Database/GetAlls')
      .then(response => response.json())
          .then(data => {
              console.log("indata")
          this.setState({ datastuff: data, loading: false });
          console.log(this.state);
      });
  }

  static renderAdminDatasTable(datastuff) {
    return (
      <table className='table'>
        <thead>
            <tr>
            <th>Id</th>
            <th>Username</th>
            <th>Password</th>
          </tr>
        </thead>
        <tbody>
          {datastuff.map(data =>
                    <tr key={data.id}>
                        <td>{data.id}</td>
              <td>{data.userName}</td>
              <td>{data.passWord}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }
  render() {
      let contents = this.state.loading
      
      ? <p><em>Loading...</em></p>
      : GettingInfoFromDatabase.renderAdminDatasTable(this.state.datastuff);

    return (
      <div>
        <h1>From the Database</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }
}
