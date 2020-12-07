import React, { Component } from 'react';
import AnimalCrossingApi from '../../api/AnimalCrossingApi';
import {
    Card, CardImg, CardTitle, CardText, 
    CardBody, CardHeader, Row, Col, Container
} from 'reactstrap';



export class SpecialCharacter extends Component {
    static displayName = SpecialCharacter.name;

    constructor(props) {
        super(props);
        this.state = { specialchars: [], loading: true };

        this.animalcrossingapi = new AnimalCrossingApi();
    }

    componentDidMount() {
        return this.animalcrossingapi.GetAllAnimalCrossingSpecialCharacters()
            .then(data => {

                this.setState({ specialchars: data, loading: false });
            });
    }


    render() {

        let allSpecialCharacters = this.state.specialchars.map(record => {
            return (
                <Col sm="4">
                    <Card style={{ marginBottom: "20px" }}>
                        <CardHeader>
                            <CardTitle>{record.name}</CardTitle>
                        </CardHeader>
                        <CardBody>
                            <CardImg top width="100%" src={record.image} alt="Villager" width="80" height="312" />
                            <CardText><b>Service:</b> {record.service}</CardText>
                        </CardBody>
                        
                    </Card>
                </Col>
            )
        })
        return (
            <div>
                <h1>Special Characters</h1>
                <Container fluid>
                    <Row>
                        {allSpecialCharacters}
                    </Row>
                </Container>
            </div>
        );
    }
}
