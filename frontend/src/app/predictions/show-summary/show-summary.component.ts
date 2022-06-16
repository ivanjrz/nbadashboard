import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-show-summary',
  templateUrl: './show-summary.component.html',
  styleUrls: ['./show-summary.component.css']
})
export class ShowPredictionsSummaryComponent implements OnInit {

  constructor(private service:SharedService, private router: Router) { }

  SummaryList:any=[];
  ModalTitle:string;
  ActivateAddEditTeamComp:boolean=false;
  selectedId: number;
  teamName: string;
  winArray: any;
  result: string;

  TeamListWithoutFilter:any=[];

  ngOnInit(): void {
    this.refreshSummaryList();
  }

  closeClick(){
    this.ActivateAddEditTeamComp=false;
    this.refreshSummaryList();
  }

  gotoPredictionDetails(id, team, result) {
    this.clearDetails();
    this.selectedId = id;
    this.teamName = team.toUpperCase() ;
    this.service.getPredictionListById(this.selectedId).subscribe(data=>{
      this.winArray=data.map(t=>t.Win);
    });
    this.result = this.getResult(this.winArray);
  }

  openPredictionsModal(item){
    this.selectedId=item;
    this.ModalTitle="Edit Team";
    this.ActivateAddEditTeamComp=true;
  }

  refreshSummaryList(){
    this.service.getPredictionSummaryList().subscribe(data=>{
      this.SummaryList=data;
      this.TeamListWithoutFilter=data;
    });
    this.ModalTitle="Results";
    this.ActivateAddEditTeamComp=true;
  }

  getResult(winArray) : any{
    let sum = winArray.reduce(
      (previousValue, currentValue) => previousValue + currentValue,0
      );
    if(sum>=4){
      this.result = 'WON! 🏆🎊🎉'
    }
    else{
      this.result = 'LOST! 💔❌'
    }
    return this.result;
  }

  clearDetails(){
    this.selectedId = null;
    this.teamName = null;
    // this.winArray= null;
    // this.result = null;
  }

}
