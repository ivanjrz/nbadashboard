import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-show-team',
  templateUrl: './show-team.component.html',
  styleUrls: ['./show-team.component.css']
})
export class ShowTeamComponent implements OnInit {

  constructor(private service:SharedService) { }

  TeamList:any=[];

  ModalTitle:string;
  ActivateAddEditTeamComp:boolean=false;
  team:any;

  TeamIdFilter:string="";
  NameFilter:string="";
  TeamListWithoutFilter:any=[];

  ngOnInit(): void {
    this.refreshTeamList();
  }

  addClick(){
    this.team={
      TeamId:0,
      Name:""
    }
    this.ModalTitle="Add Team";
    this.ActivateAddEditTeamComp=true;

  }

  editClick(item){
    this.team=item;
    this.ModalTitle="Edit Team";
    this.ActivateAddEditTeamComp=true;
  }

  deleteClick(item){
    if(confirm('Are you sure??')){
      this.service.deleteTeam(item.TeamId).subscribe(data=>{
        alert(data.toString());
        this.refreshTeamList();
      })
    }
  }

  closeClick(){
    this.ActivateAddEditTeamComp=false;
    this.refreshTeamList();
  }


  refreshTeamList(){
    this.service.getTeamList().subscribe(data=>{
      this.TeamList=data;
      this.TeamListWithoutFilter=data;
    });
  }

  FilterFn(){
    var TeamIdFilter = this.TeamIdFilter;
    var NameFilter = this.NameFilter;

    this.TeamList = this.TeamListWithoutFilter.filter(function (el){
        return el.Name.toString().toLowerCase().includes(
          TeamIdFilter.toString().trim().toLowerCase()
        )&&
        el.City.toString().toLowerCase().includes(
          NameFilter.toString().trim().toLowerCase()
        )
    });
  }

  sortResult(prop,asc){
    this.TeamList = this.TeamListWithoutFilter.sort(function(a,b){
      if(asc){
          return (a[prop]>b[prop])?1 : ((a[prop]<b[prop]) ?-1 :0);
      }else{
        return (b[prop]>a[prop])?1 : ((b[prop]<a[prop]) ?-1 :0);
      }
    })
  }

}
