import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {PlayerComponent} from './player/player.component';
import {TeamComponent} from './team/team.component';
import {TeamHistoryComponent} from './teamhistory/teamhistory.component';
import { DashboardComponent } from './dashboard/dashboard.component';

const routes: Routes = [
{path:'player',component:PlayerComponent},
{path:'team',component:TeamComponent},
{path:'teamhistory', component:TeamHistoryComponent},
{path:'', component:DashboardComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
