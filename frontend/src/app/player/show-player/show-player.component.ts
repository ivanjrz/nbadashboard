import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-show-player',
  templateUrl: './show-player.component.html',
  styleUrls: ['./show-player.component.css'],
  providers: [DatePipe]
})
export class ShowPlayerComponent implements OnInit {

  constructor(private service:SharedService, private datePipe: DatePipe) { }

  playerList:any=[];

  ModalTitle:string;
  ActivateAddEditPlayerComp:boolean=false;
  player:any;

  ngOnInit(): void {
    this.refreshplayerList();
  }

  addClick(){
    this.player={
      PlayerId:0,
      Name:"",
      Team:"",
      Joined:"",
      PhotoName:"anonymous.png"
    }
    this.ModalTitle="Add player";
    this.ActivateAddEditPlayerComp=true;

  }

  editClick(item){
    console.log(item);
    this.player=item;
    this.ModalTitle="Edit player";
    this.ActivateAddEditPlayerComp=true;
  }

  deleteClick(item){
    if(confirm('Are you sure??')){
      this.service.deletePlayer(item.playerId).subscribe(data=>{
        alert(data.toString());
        this.refreshplayerList();
      })
    }
  }

  closeClick(){
    this.ActivateAddEditPlayerComp=false;
    this.refreshplayerList();
  }


  refreshplayerList(){
    this.service.getPlayerList().subscribe(data=>{
      this.playerList=data;
    });
  }

}
