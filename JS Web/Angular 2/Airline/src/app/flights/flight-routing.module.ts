import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { RouterModule, Routes } from '@angular/router'
import { AllFlightComponent } from './administration/all-flight/all-flight.component';
import { CreateFlightComponent } from './create-flight/create-flight.component';
import { EditFlightComponent } from './edit-flight/edit-flight.component';
import { MyFlightComponent } from './my-flight/my-flight.component';
import { DetailsFlightComponent } from './details-flight/details-flight.component';
import { PublicFlightComponent } from './public-flight/public-flight.component';
import { SearchFlightComponent } from './search/search-flight/search-flight.component';
import { SearchResultsComponent } from './search/search-results/search-results.component';

import { AuthenticationGuard } from './guards/authentication.guard';
import { AdminGuard } from './guards/admin.guard';
import { AuthorGuard } from './guards/author.guard';
import { OperatorGuard } from './guards/operator.guard';

const flightRoutes: Routes = [
    { path: 'public', component: PublicFlightComponent, canActivate: [AuthenticationGuard] },
    { path: 'create', component: CreateFlightComponent, canActivate: [OperatorGuard] },
    { path: 'edit/:id', component: EditFlightComponent, canActivate: [AuthorGuard, OperatorGuard] },
    { path: 'my', component: MyFlightComponent, canActivate: [OperatorGuard] },
    { path: 'details/:id', component: DetailsFlightComponent, canActivate: [AuthenticationGuard] },
    { path: 'all', component: AllFlightComponent, canActivate: [AdminGuard] },
    { path: 'search', component: SearchFlightComponent, canActivate: [AuthenticationGuard] },
    { path: 'search/results', component: SearchResultsComponent, canActivate: [AuthenticationGuard] }
]

@NgModule({
    imports: [
        RouterModule.forChild(flightRoutes)
    ],
    providers: [
        AdminGuard,
        AuthenticationGuard,
        AuthorGuard,
        OperatorGuard
    ],
    exports: [RouterModule]

})

export class FlighRoutingModule { }