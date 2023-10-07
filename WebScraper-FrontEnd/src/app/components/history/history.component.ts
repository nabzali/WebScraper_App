import { Component } from '@angular/core';
import { searchResponse } from 'src/app/models/searchResponse';

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})
export class HistoryComponent {
  searchResults: searchResponse[] = [
    {
      id: 1, url: "helloworld.com",
      searchTerms: "Apple", 
      occurrences: "1, 38, 67", 
      timestamp: "timestamp"
    },
    {
      id: 2, url: "example.co.uk",
      searchTerms: "Banana", 
      occurrences: "4, 92", 
      timestamp: "timestamp2"
    }
  ]
}
