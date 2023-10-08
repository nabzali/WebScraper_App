import { Component, OnInit } from '@angular/core';
import { searchResponse } from 'src/app/models/searchResponse';
import { ApplicationService } from 'src/app/services/applicationService';

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html'
})
export class HistoryComponent implements OnInit{
  
  // Initialised variables
  searchHistoryData : searchResponse[] = []
  dataLoaded = false;

  constructor(private applicationService: ApplicationService){}
  
  // Populate and show table when search data has been retrieved
  ngOnInit(): void {
    this.applicationService.getSearchHistory().subscribe((response) => {
      this.searchHistoryData = response;
      this.dataLoaded = true;
    });
    
  }
}
