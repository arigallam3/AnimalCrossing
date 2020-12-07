import React, { Component } from 'react';
import { DataGrid } from '@material-ui/data-grid';

const columns = [
    { field: 'id', headerName: 'Daily Checklist', width: 400 }
    
];
const rows = [
    { id: 'Talk to villagers' },
    { id: 'Hit every rock with shovel' },
    { id: 'Dig up Fossils' },
    { id: 'Plant a Money Tree' },
    { id: 'Shake all trees for branches, bells, and furniture' },
    { id: 'Find message bottle on the beach' },
    { id: 'Check in at Nook Stop inside Resident Services' },
    { id: 'Look for Island Visitors' }
];

export class Home extends Component {
    static displayName = Home.name;
    constructor(props) {
        super(props);
        this.state = {
            currentDateTime: Date().toLocaleString()
        };

        
    }

  render () {
      return (
          <div className="homestyle" style={{ height: 600, width: '100%', backgroundColor: "#e6ffe6", marginTop: "20px" }}>
              <div style={{ backgroundColor: "#ffffff", paddingLeft: "20px" }}>
                  <h1>Animal Crossing - New Horizons</h1>
                  <h5><u>Current Time:</u> {this.state.currentDateTime}</h5>
                  <p>Check off each task once accomplished</p>
                </div>
              <DataGrid rows={rows} columns={columns} pageSize={10} checkboxSelection />
            <br />
            <br />
            <br />
            <br />
        </div>
    );
  }
}
