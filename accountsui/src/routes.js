import React from 'react';
import {
    BrowserRouter as Router,
    Route
} from 'react-router-dom';
import App from './App' ;
import SignIn from './Account/sign-in';
import SignUp from './Account/sign-up';
import Navbar from './navbar'


const CustomRoutes = () => (
<Router>
    <div>
        
        <Navbar/>
        <Route exact path='/' component={App}/>
        <Route exact path='/sign-in' component={SignIn} />
        <Route exact path='/sign-up' component={SignUp} />

        
    </div>
</Router> 
)
export default CustomRoutes;