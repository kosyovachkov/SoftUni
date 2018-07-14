import React from 'react';
import { Route} from 'react-router-dom';

import LoginPage from '../user/LoginPage'
import RegisterPage from './../user/RegisterPage'
import Logout from '../user/Logout';

import ListFlights from '../flight/ListFlightsPage'
import AllFlights from '../flight/AllFlightsPage'
import MyFlights from '../flight/MyFlightsPage'
import AddForm from '../flight/AddFormPage'
import EditForm from '../flight/EditFormPage'
import Details from '../flight/DetailsPage'

const AppRoutes = ()=>(
    <div>
    <Route path='/' exact component={LoginPage}/>
    <Route path='/login'  component={LoginPage}/>
    <Route path='/register'  component={RegisterPage}/>
    <Route path='/logout'  component={Logout}/>
    <Route path='/list'  component={ListFlights}/>
    <Route path='/add'  component={AddForm}/>
    <Route path='/all'  component={AllFlights}/>
    <Route path='/myFlights'  component={MyFlights}/>
    <Route path='/edit/:id'  component={EditForm}/>
    <Route path='/details/:id'  component={Details}/>
    </div>
)

export default AppRoutes;