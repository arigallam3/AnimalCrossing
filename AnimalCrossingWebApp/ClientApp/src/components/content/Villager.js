import React, { Component } from 'react';
import AnimalCrossingApi from '../../api/AnimalCrossingApi';
import { ModalButton } from '../modal/ModalButton';
import {
    Card, CardImg, CardTitle, CardText,
    CardBody, CardHeader, CardFooter, Row, Col, Container
} from 'reactstrap';
import modal_views from '../../constants/modal_views';
import SEARCH_CRITERIA from '../../constants/SEARCH_CRITERIA';
import SearchBar from '../SearchBar';
import Background from '../img/villagerwallpaper.jpg';

export class Villager extends Component {
    static displayName = Villager.name;

    constructor(props) {
        super(props);
        this.state = {
            query: "",
            criteria: SEARCH_CRITERIA.newID.value,
            searchFields: [
                SEARCH_CRITERIA.newID,
                SEARCH_CRITERIA.Name,
                SEARCH_CRITERIA.Personality,
                SEARCH_CRITERIA.Species,
                SEARCH_CRITERIA.Catchphrase
            ],
            villagers: [],
            loading: true,
            filteredVillagers: [],
            count: null
        };

        this.animalcrossingapi = new AnimalCrossingApi();
        this.handleSearch = this.handleSearch.bind(this);
        this.handleCriteria = this.handleCriteria.bind(this);
       
        this.handleRefresh = this.handleRefresh.bind(this);
    }

    componentDidMount() {
        return this.animalcrossingapi.GetAllAnimalCrossingVillagers()
            .then(data => {
                
                this.setState({ villagers: data, loading: false, count: data.length, filteredVillagers: data });
            });
    }

    handleCriteria = (event) => {
        this.setState({ criteria: event.target.value.toString(), query: "", filteredVillagers: this.state.villagers });
    }

    handleSearch = (event) => {
        const query = event.target.value.toString().toLowerCase();

        this.setState(prevState => {
            const filteredVillagers = prevState.villagers.filter(element => {
                if (element[this.state.criteria] !== null)
                    return element[this.state.criteria].toString().toLowerCase().includes(query);
            });
            const count = filteredVillagers.length;
            return { query, filteredVillagers, count };
        });
    };

    handleRefresh = () => {
        this.setState({ loading: true, count: null });
        return this.animalcrossingapi.GetAllAnimalCrossingVillagers()
            .then(data => {
                this.formatData(data);
                this.setState({ villagers: data, query: "", filteredVillagers: data, loading: false, count: data.length });
            });
    }

    render() {

        let allVillagers = this.state.filteredVillagers.map(villager => {
            return (
                <Col sm="4">
                    <Card style={{ marginBottom: "20px" }}>
                            <CardHeader>
                                <CardTitle><b>{villager.name}</b></CardTitle>
                            </CardHeader>
                            <CardBody>
                                <CardImg top width="100%" src={villager.picURL} alt="Villager" width="100" height="312" />
                                <CardText><b>Personality:</b> {villager.personality}</CardText>
                                <CardText><b>Species:</b> {villager.species}</CardText>
                                <CardText><b>Birthday:</b> {villager.dateOfBirth}</CardText>
                                <CardText><b>Catchphrase:</b> {villager.catchphrase}</CardText>
                            </CardBody>
                            <CardFooter>
                                <Row>
                                    <ModalButton view={modal_views.ViewVillagerInfo} dataPassed="true" data={villager} text="More Info" />
                                </Row>
                            </CardFooter>
                        </Card>
                </Col>
            )
        })
        return (
            <div style={{ backgroundImage: `url(${Background})`, marginTop: '20px' }}>
                <h1>Villagers</h1>
                <SearchBar
                    handleSearch={this.handleSearch}
                    handleCriteria={this.handleCriteria}
                    criteria={this.state.criteria}
                    query={this.state.query}
                    fields={this.state.searchFields}
                />
                <Container fluid>
                    <Row>
                        {allVillagers}
                    </Row>
                </Container>
            </div>
        );
    }
}
