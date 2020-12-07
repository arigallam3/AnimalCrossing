import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './layout/NavMenu';
import  Header  from './layout/header';
import Footer from './layout/footer';
import Background from './img/backgroundimage.jpg';

import './Layout.css';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
      return (
          <div className="layout" style={{ backgroundColor: '#e6ffe6', height: '100%', backgroundImage: `url(${Background})` }}>

            <Container>
                <div className="page-container">
                    <Header />
                    <NavMenu />
                    {this.props.children}
                    <Footer />
                </div>
            </Container>
        </div>
    );
  }
}
