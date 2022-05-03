import { Component, OnInit } from '@angular/core';
import {SharedService} from '../shared.service'

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private service:SharedService) { }

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
