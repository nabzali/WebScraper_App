import { Component } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {

  url: string = "";
  searchTerms: string = "";
  searchEngine: string = "Google";
  
  constructor(){
    this.getValues();
  }

  getValues(){
    console.log(this.url);
    console.log(this.searchTerms);
    console.log(this.searchEngine);
  }

}
