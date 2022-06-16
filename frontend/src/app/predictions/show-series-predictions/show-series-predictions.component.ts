import { Component, Input, OnInit } from '@angular/core';
import {SharedService} from '../../shared.service';

@Component({
  selector: 'app-show-series-predictions',
  templateUrl: './show-series-predictions.component.html',
  styleUrls: ['./show-series-predictions.component.css']
})
export class ShowSeriesPredictionsComponent implements OnInit {

  constructor(private service:SharedService) { }

  Prediction:any=[];
  ModalTitle:string;
  ActivateAddEditTeamComp:boolean=false;
  @Input('teamName') teamName: string;
  @Input('result') result: string;
  @Input('selectedId') selectedId: number;
  @Input('winArray') winArray: any=[];

  ngOnInit(): void {
    console.log(this.winArray);
    // this.refreshPrediction();
  }

  // refreshPrediction(){
  //   this.service.getPredictionListById(this.selectedId).subscribe(data=>{
  //     this.Prediction=data;
  //   });
  //   console.log(this.Prediction);
  // }

  
}
