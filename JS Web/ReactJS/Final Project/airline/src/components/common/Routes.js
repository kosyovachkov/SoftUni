import React from 'react';
import { Route} from 'react-router-dom';

import ListFlights from './../flight/ListFlights'
import AllFlights from './../flight/AllFlights'
import MyFlights from './../flight/MyFlights'
import LoginForm from './../user/LoginForm'
import RegisterForm from './../user/RegisterForm'
import AddForm from '../flight/AddFormPage'
import EditForm from '../flight/EditFormPage'
import Details from './../flight/Details'
import Logout from '../user/Logout';

const AppRoutes = ()=>(
    <div>
    <Route path='/' exact component={LoginForm}/>
    <Route path='/login'  component={LoginForm}/>
    <Route path='/register'  component={RegisterForm}/>
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