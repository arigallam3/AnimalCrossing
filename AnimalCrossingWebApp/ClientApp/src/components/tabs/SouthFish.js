import React, { Component } from 'react';
import AnimalCrossingApi from '../../api/AnimalCrossingApi';
import { Table } from 'reactstrap';
import './table.css';


export class SouthFish extends Component {
    constructor(props) {
        super(props);
        this.state = {
            loading: true,
            southfishes: [],
            count: null
        };

        this.animalcrossingapi = new AnimalCrossingApi();
    }

    componentDidMount() {
        return this.animalcrossingapi.GetAllAnimalCrossingSouthFishes()
            .then(data => {

                this.setState({ southfishes: data, loading: false });
            });
    }

    render() {
        return (
            <React.Fragment>
                <Table className="tablestyle" bordered striped>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Image</th>
                            <th>Price</th>
                            <th>Location</th>
                            <th>Shadow Size</th>
                            <th>Time</th>
                            <th>Jan</th>
                            <th>Feb</th>
                            <th>Mar</th>
                            <th>Apr</th>
                            <th>May</th>
                            <th>Jun</th>
                            <th>Jul</th>
                            <th>Aug</th>
                            <th>Sep</th>
                            <th>Oct</th>
                            <th>Nov</th>
                            <th>Dec</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.southfishes.map(record =>
                            <tr key={record.id}>
                                <td>{record.name}</td>
                                <td><img src={record.image} alt="southfish" /></td>
                                <td>{record.price}</td>
                                <td>{record.location}</td>
                                <td>{record.shadowSize}</td>
                                <td>{record.time}</td>
                                <td>{record.jan ? "Yes" : "No"}</td>
                                <td>{record.feb ? "Yes" : "No"}</td>
                                <td>{record.mar ? "Yes" : "No"}</td>
                                <td>{record.apr ? "Yes" : "No"}</td>
                                <td>{record.may ? "Yes" : "No"}</td>
                                <td>{record.jun ? "Yes" : "No"}</td>
                                <td>{record.jul ? "Yes" : "No"}</td>
                                <td>{record.aug ? "Yes" : "No"}</td>
                                <td>{record.sep ? "Yes" : "No"}</td>
                                <td>{record.oct ? "Yes" : "No"}</td>
                                <td>{record.nov ? "Yes" : "No"}</td>
                                <td>{record.dec ? "Yes" : "No"}</td>
                            </tr>
                        )}
                    </tbody>
                </Table>
            </React.Fragment>
        );
    }

}