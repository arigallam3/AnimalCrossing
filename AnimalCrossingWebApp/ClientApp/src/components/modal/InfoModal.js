import React, { Component } from 'react';
import { Modal, ModalBody } from 'reactstrap';
import modal_views from '../../constants/modal_views';
import { MoreInfo } from '../popup/MoreInfo';

export class InfoModal extends Component {
    constructor(props) {
        super(props);
        this.close = this.close.bind(this);
    }

    close = (props) => {
        return (<button type="button" className="btn btn-danger" onClick={props.handleClose}> Close </button>);
    }

    render() {
        return (
            <Modal isOpen={this.props.show} className={this.props.loadingModal}>
                <span className="top-close" onClick={this.props.handleClose}>X</span>
                <ModalBody>
                    {this.props.view === modal_views.ViewVillagerInfo ? <MoreInfo villager={this.props.villager} /> : null}
                    <button type="button" className="bottom-close" onClick={this.props.handleClose}> Close </button>
                </ModalBody>

            </Modal>
        );
    }
}