import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:53535/api";
readonly PhotoUrl = "http://localhost:53535/Photos/";

  constructor(private http:HttpClient) { }

  getTeamList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Team');
  }

  addTeam(val:any){
    return this.http.post(this.APIUrl+'/Team',val);
  }

  updateTeam(val:any){
    return this.http.put(this.APIUrl+'/Team',val);
  }

  deleteTeam(val:any){
    return this.http.delete(this.APIUrl+'/Team/'+val);
  }

  getPlayerList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Player');
  }

  addPlayer(val:any){
    return this.http.post(this.APIUrl+'/Player',val);
  }

  updatePlayer(val:any){
    return this.http.put(this.APIUrl+'/Player',val);
  }

  deletePlayer(val:any){
    return this.http.delete(this.APIUrl+'/Player/'+val);
  }


  UploadPhoto(val:any){
    return this.http.post(this.APIUrl+'/Player/SaveFile',val);
  }

  getAllTeamNames():Observable<any[]>{
    return this.http.get<any[]>(this.APIUrl+'/Player/GetAllTeamNames');
  }

  getHistoryList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/TeamHistory');
  }

}
