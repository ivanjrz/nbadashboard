import { Component, OnInit,Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-team',
  templateUrl: './add-edit-team.component.html',
  styleUrls: ['./add-edit-team.component.css']
})
export class AddEditTeamComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() team:any;
  TeamId:string;
  Name:string;

  ngOnInit(): void {
    this.TeamId=this.team.TeamId;
    this.Name=this.team.Name;
  }

  addTeam(){
    var val = {TeamId:this.TeamId,
                Name:this.Name};
    this.service.addTeam(val).subscribe(res=>{
      alert(res.toString());
    });
  }

  updateTeam(){
    var val = {TeamId:this.TeamId,
      Name:this.Name};
    this.service.updateTeam(val).subscribe(res=>{
    alert(res.toString());
    });
  }

}
