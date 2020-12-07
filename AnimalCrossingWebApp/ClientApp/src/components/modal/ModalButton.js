import './ModalButton.css';
import React, { Component } from 'react';
import { InfoModal } from './InfoModal';

export class ModalButton extends Component {
    constructor(props) {
        super(props);
        this.state = {
            isModalVisible: false,
            loading: true,
        };

        this.handleOpenModal = this.handleOpenModal.bind(this);
        this.handleCloseModal = this.handleCloseModal.bind(this);
    }

    handleOpenModal = () => {
        this.setState({ isModalVisible: true });
    }
    handleCloseModal = () => {
        this.setState({ isModalVisible: false });
    }

    render() {
        const { data, dataPassed } = this.props;

        return (
            <div>
                <button type="button" className="btn btn-link" id={this.props.view} onClick={this.handleOpenModal}> {this.props.text} </button>
                <InfoModal
                    show={this.state.isModalVisible}
                    handleClose={this.handleCloseModal}
                    view={this.props.view}
                    villager={dataPassed ? data : undefined}
                />
            </div>
        );
    }
}