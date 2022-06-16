import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PlayerComponent } from './player/player.component';
import { TeamComponent } from './team/team.component';
import { TeamHistoryComponent } from './teamhistory/teamhistory.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PredictionsComponent } from './predictions/predictions.component';
import { ShowSeriesPredictionsComponent } from './predictions/show-series-predictions/show-series-predictions.component';
import { AboutComponent } from './about/about.component';

const routes: Routes = [
{path:'player',component:PlayerComponent},
{path:'team',component:TeamComponent},
{path:'teamhistory', component:TeamHistoryComponent},
{path:'predictionsummary', component:PredictionsComponent},
{path:'prediction', component:ShowSeriesPredictionsComponent},
{path:'about', component:AboutComponent},
{path:'', component:DashboardComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
