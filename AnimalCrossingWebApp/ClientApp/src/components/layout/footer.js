import React from 'react';
import './footer.css';

const Footer = () => {
    const year = new Date().getFullYear();
    return (
        <footer>
            <div className="row">
                <div className="left-col">
                    Copyright {year} |
                    All rights reserved by Arianna Gallamoza |&nbsp;
                   
                </div>
                <div className="right-col">
                   ITEC.423 Final Project
                  
                </div>
            </div>
        </footer>
    );
}
export default Footer;