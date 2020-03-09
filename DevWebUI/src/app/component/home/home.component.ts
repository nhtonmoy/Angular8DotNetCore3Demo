import { Component, OnInit } from '@angular/core';
import { HomeService } from 'src/app/service/home.service';
import { Router } from '@angular/router';
import { StudentList } from 'src/app/model/studentList';
import { ChartType, ChartOptions, ChartDataSets } from 'chart.js';
import { SingleDataSet, Label, Colors, Color, monkeyPatchChartJsLegend, monkeyPatchChartJsTooltip } from 'ng2-charts';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  studentList: StudentList[];
  m= 0;
  f= 0;
  constructor(private homeService: HomeService, private router: Router) {
    monkeyPatchChartJsTooltip();
    monkeyPatchChartJsLegend();
   }

  ngOnInit() {
    this.getStudents();
  }



  public pieChartOptions: ChartOptions = {
    responsive: true,
  };
  public pieChartLabels: Label[] = ["Male", "Female"];
  public pieChartData: SingleDataSet = [this.m, this.f];
  public pieChartLegend = true;
  public pieChartType: ChartType = 'pie';
  public pieChartPlugins = [];


  public getStudents() {
    
    this.homeService.getAll().
      subscribe((data) => {
        this.studentList = data;
        //var i;
        for (let i in this.studentList) {
          if (this.studentList[i].gender === 'Female') {
            (this.f)++;
          }
          else (this.m)++;
        }
        
        console.log(this.m + '   ' + this.f);
        this.getNum(this.m, this.f);
  
      });
  }

  getNum(m, f) {
    this.m = m;
    this.f = f;
    console.log(this.m + '   ' + this.f);
    
    this.pieChartData = [m, f];


  }
}
