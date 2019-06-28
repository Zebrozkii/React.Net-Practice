
import React, { Component } from 'react';

export class AdminData extends Component {
  displayName = AdminData.name

  constructor(props) {
    super(props);
    this.state = { admindatas: [], loading: true };
     
      fetch('api/Home/AdminEntrys')
      .then(response => response.json())
      .then(data => {
          this.setState({ admindatas: data, loading: false });
          console.log(this.state);
      });
  }

  static renderAdminDatasTable(admindatas) {
    return (
      <table className='table'>
        <thead>
            <tr>
            <th>Date</th>
            <th>Id</th>
            <th>Username</th>
            <th>Password</th>
          </tr>
        </thead>
        <tbody>
          {admindatas.map(admin =>
                    <tr key={admin.dateFormatted}>
                        <td>{admin.dateFormatted}</td>
              <td>{admin.id}</td>
              <td>{admin.userName}</td>
              <td>{admin.passWord}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }
  render() {
      let contents = this.state.loading
      
      ? <p><em>Loading...</em></p>
      : AdminData.renderAdminDatasTable(this.state.admindatas);

    return (
      <div>
        <h1>AdminData</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }
}
