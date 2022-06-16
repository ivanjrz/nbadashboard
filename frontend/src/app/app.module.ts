import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TeamComponent } from './team/team.component';
import { ShowTeamComponent} from './team/show-team/show-team.component';
import { AddEditTeamComponent} from './team/add-edit-team/add-edit-team.component';
import { SharedService } from './shared.service';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PlayerComponent } from './player/player.component';
import { TeamHistoryComponent } from './teamhistory/teamhistory.component';
import { ShowPlayerComponent } from './player/show-player/show-player.component';
import { AddEditPlayerComponent } from './player/add-edit-player/add-edit-player.component';
import { ShowTeamHistoryComponent } from './teamhistory/show-teamhistory/show-teamhistory.component';
import { AddEditTeamHistoryComponent } from './teamhistory/add-edit-teamhistory/add-edit-teamhistory.component';
import { ShowSeriesPredictionsComponent } from './predictions/show-series-predictions/show-series-predictions.component';
import { PredictionsComponent } from './predictions/predictions.component';
import { ShowPredictionsSummaryComponent } from './predictions/show-summary/show-summary.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';

// import { MatCard } from '@angular/material/card';
import { MatSliderModule } from '@angular/material/slider';
import { MatCardModule } from '@angular/material/card';
import { AboutComponent } from './about/about.component';

@NgModule({
  declarations: [
    AppComponent,
    TeamComponent,
    ShowTeamComponent,
    AddEditTeamComponent,
    DashboardComponent,
    PlayerComponent,
    ShowPlayerComponent,
    AddEditPlayerComponent,
    TeamHistoryComponent,
    ShowTeamHistoryComponent,
    AddEditTeamHistoryComponent,
    PredictionsComponent,
    ShowPredictionsSummaryComponent,
    ShowSeriesPredictionsComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NoopAnimationsModule,
    MatSliderModule,
    MatCardModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
