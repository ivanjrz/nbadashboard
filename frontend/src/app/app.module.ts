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
import { PlayerComponent } from './player/player.component';
import { GameComponent } from './game/game.component';
import { ShowPlayerComponent } from './player/show-player/show-player.component';
import { AddEditPlayerComponent } from './player/add-edit-player/add-edit-player.component';
import { ShowGameComponent } from './game/show-game/show-game.component';
import { AddEditGameComponent } from './game/add-edit-game/add-edit-game.component';

@NgModule({
  declarations: [
    AppComponent,
    TeamComponent,
    ShowTeamComponent,
    AddEditTeamComponent,
    PlayerComponent,
    GameComponent,
    ShowPlayerComponent,
    AddEditPlayerComponent,
    ShowGameComponent,
    AddEditGameComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
