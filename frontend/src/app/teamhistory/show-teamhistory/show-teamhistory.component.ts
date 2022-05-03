import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-show-teamhistory',
  templateUrl: './show-teamhistory.component.html',
  styleUrls: ['./show-teamhistory.component.css']
})
export class ShowTeamHistoryComponent implements OnInit {

  constructor(private service:SharedService) { }

  historyList:any=[];

  ModalTitle:string;
  ActivateAddEditHistoryComp:boolean=false;
  history:any;

  TeamFilter:string="";
  SeasonFilter:string="";
  TeamListWithoutFilter:any=[];

  ngOnInit(): void {
    this.refreshTeamHistoryList();
  }

  addClick(){
    this.history={
      TeamHistoryId:0,
      Name:"",
      Team:"",
      Joined:"",
      PhotoName:"anonymous.png"
    }
    this.ModalTitle="Add history";
    this.ActivateAddEditHistoryComp=true;

  }

  editClick(item){
    console.log(item);
    this.history=item;
    this.ModalTitle="Edit history";
    this.ActivateAddEditHistoryComp=true;
  }

  closeClick(){
    this.ActivateAddEditHistoryComp=false;
    this.refreshTeamHistoryList();
  }


  refreshTeamHistoryList(){
    this.service.getHistoryList().subscribe(data=>{
      this.historyList=data;
      this.TeamListWithoutFilter=data;
    });
  }


  FilterFn(){
    var TeamFilter = this.TeamFilter;
    // var SeasonFilter = this.SeasonFilter;

    this.historyList = this.TeamListWithoutFilter.filter(function (el){
        return el.Team.toString().toLowerCase().includes(
          TeamFilter.toString().trim().toLowerCase()
        )
        // &&
        // el.Season.toString().toLowerCase().includes(
        //   SeasonFilter.toString().trim().toLowerCase()
        // )
    });
  }

  sortResult(prop,asc){
    this.historyList = this.TeamListWithoutFilter.sort(function(a,b){
      if(asc){
          return (a[prop]>b[prop])?1 : ((a[prop]<b[prop]) ?-1 :0);
      }else{
        return (b[prop]>a[prop])?1 : ((b[prop]<a[prop]) ?-1 :0);
      }
    })
  }

}
