import { Component, OnInit,Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-player',
  templateUrl: './add-edit-player.component.html',
  styleUrls: ['./add-edit-player.component.css']
})
export class AddEditPlayerComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() player:any;
  PlayerId:string;
  Name:string;
  Team:string;
  Joined:string;
  PhotoPath:string;

  teamList:any=[];

  ngOnInit(): void {
    this.loadTeamsList();
  }

  loadTeamsList(){
    this.service.getAllTeamNames().subscribe((data:any)=>{
      this.teamList=data;
      this.PlayerId=this.player.PlayerId;
      this.Name=this.player.Name;
      this.Team=this.player.Team;
      this.Joined=this.player.Joined;
      this.PhotoPath=this.player.PhotoPath;
      this.PhotoPath=this.service.PhotoUrl+this.PhotoPath;
    });
  }

  addPlayer(){
    var val = {PlayerId:this.PlayerId,
                Name:this.Name,
                Team:this.Team,
              Joined:this.Joined,
            PhotoPath:this.PhotoPath};

    this.service.addPlayer(val).subscribe(res=>{
      alert(res.toString());
    });
  }

  updatePlayer(){
    var val = {PlayerId:this.PlayerId,
      Name:this.Name,
      Team:this.Team,
      Joined:this.Joined,
      PhotoPath:this.PhotoPath};
      
      this.service.updatePlayer(val).subscribe(res=>{
        alert(res.toString());
      });
    }


  uploadPhoto(event){
    var file=event.target.files[0];
    const formData:FormData=new FormData();
    formData.append('uploadedFile',file,file.name);

    this.service.UploadPhoto(formData).subscribe((data:any)=>{
      this.PhotoPath=data.toString();
      this.PhotoPath=this.service.PhotoUrl+this.PhotoPath;
    })
  }

}


