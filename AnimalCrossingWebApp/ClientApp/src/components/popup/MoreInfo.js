import React, { Component } from 'react';
import {
    Card, CardHeader, CardFooter, CardBody, CardImg,
    Row, ListGroup, ListGroupItem, Col
} from 'reactstrap';

export class MoreInfo extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        const villager = this.props.villager;
        return (
            <div>
                <Card>
                    <CardHeader><b>{villager.name}</b></CardHeader>
                    <CardBody>
                        <Row>
                            <Col xs="6" sm="4">
                                <CardImg top width="100%" src={villager.picURL} alt="Villager" width="80" height="312" />
                            </Col>
                        <Col xs="6" sm="4">
                            <ListGroup style={{ textAlign: "center", fontWeight: "bold" }}>
                                        <ListGroupItem>Personality</ListGroupItem>
                                        <ListGroupItem>Species</ListGroupItem>
                                        <ListGroupItem>Birthday</ListGroupItem>
                                        <ListGroupItem>Hobby</ListGroupItem>
                                        <ListGroupItem>Favorite Colors</ListGroupItem>
                                        <ListGroupItem>Styles</ListGroupItem>
                                    </ListGroup>
                                </Col>
                                <Col xs="6" sm="4">
                            <ListGroup style={{ textAlign: "center" }}>
                                <ListGroupItem>{villager.personality}</ListGroupItem>
                                <ListGroupItem>{villager.species}</ListGroupItem>
                                <ListGroupItem>{villager.dateOfBirth}</ListGroupItem>
                                <ListGroupItem>{villager.hobby}</ListGroupItem>
                                <ListGroupItem>{villager.color}</ListGroupItem>
                                <ListGroupItem>{villager.styles}</ListGroupItem>
                            </ListGroup>
                                </Col>   
                        </Row>
                      <br /> 
                        <Row> 
                            <Col sm="12" md={{ size: 6, offset: 3 }}><legend>House</legend>
                                <CardImg src={villager.house} alt="Villager House" width="500" height="300" /></Col>
                            
                        </Row>
                    </CardBody>
                    <CardFooter></CardFooter>
                </Card>
               
            </div>
        );
    }
}