import React from 'react';
import {Link} from 'react-router-dom';

const Navbar = () => (

    <div className="App">
        <header className="App-header">
            <ul>
                <li><Link  to="/">Home </Link></li>
                <li><Link  to="/sign-in">Sign In </Link></li>
                <li><Link  to="/sign-up">Sign Up</Link></li>
            </ul>
        </header>
    </div>
    
)
export default Navbar