import { Component, OnInit } from '@angular/core';
import { ApplicationService } from 'src/app/services/applicationService';
import { searchRequest } from 'src/app/models/searchRequest';
import { searchResponse } from 'src/app/models/searchResponse';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit{

  // Initialising the inputs
  loadingText: string = ""
  url: string = "";
  searchTerms: string = "";
  resultText: string = "";
  searchComplete: boolean = false;
  
  
  constructor(private applicationService: ApplicationService){
    this.getValues();
  }
  ngOnInit(): void {
    
  }

  getValues(){
    console.log(this.url);
    console.log(this.searchTerms);
  }

  onClickRun() {
    this.searchComplete = false;
    this.loadingText = "Processing search. Please wait..."
    
    var newRequest : searchRequest =  {
      url: this.url,
      searchTerms : this.searchTerms
    }
    this.applicationService.createSearchRequest(newRequest)
      .subscribe((response : searchResponse) => {
          this.searchComplete = true;
          this.loadingText = "Results are in!";
          if (response.occurrences.length == 0){
            this.resultText = 
              `There were no occurrences of the URL '${this.url}
              for the search term(s) '${this.searchTerms}'
            `;
          }
          else {
            this.resultText = `
              For the search term(s) '${this.searchTerms}', the URL '${this.url}'
              was found at positions '${response.occurrences}' at time
              '${response.timestamp}'. \nSee the history page for a detailed
              log of all searches.
          `;
          }
          
        }
      )

  }


}
