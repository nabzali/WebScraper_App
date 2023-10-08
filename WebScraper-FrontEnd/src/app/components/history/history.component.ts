import { Component, OnInit } from '@angular/core';
import { searchResponse } from 'src/app/models/searchResponse';
import { ApplicationService } from 'src/app/services/applicationService';

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})
export class HistoryComponent implements OnInit{

  constructor(private applicationService: ApplicationService){}

  searchHistoryData : searchResponse[] = []
  dataLoaded = false;
  

  ngOnInit(): void {
    this.applicationService.getSearchHistory().subscribe((response) => {
      this.searchHistoryData = response;
      console.log(this.searchHistoryData);
      this.dataLoaded = true;
    });
    
  }
}
