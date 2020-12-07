import React, { useState } from 'react';
import classnames from 'classnames';
import { TabContent, TabPane, Nav, NavItem, NavLink } from 'reactstrap';
import { NorthFish } from './tabs/NorthFish';
import { SouthFish } from './tabs/SouthFish';
import './museumstyle.css';

const Fish = (props) => {
    const [activeTab, setActiveTab] = useState('1');

    const toggle = tab => {
        if (activeTab !== tab) setActiveTab(tab);
    }

    return (
        <div className="tabstyle">
            <Nav tabs>
                <NavItem>
                    <NavLink
                        className={classnames({ active: activeTab === '1' })}
                        onClick={() => { toggle('1'); }}
                    >
                        <strong>Northern Hemisphere</strong>
                    </NavLink>
                </NavItem>
                <NavItem>
                    <NavLink
                        className={classnames({ active: activeTab === '2' })}
                        onClick={() => { toggle('2'); }}
                    >
                        <strong>Southern Hemisphere</strong>
                    </NavLink>
                </NavItem>
            </Nav>
            <TabContent activeTab={activeTab}>
                <TabPane tabId="1">
                    <NorthFish />
                </TabPane>
                <TabPane tabId="2">
                    <SouthFish />
                </TabPane>
            </TabContent>
        </div>
    );
}

export default Fish;