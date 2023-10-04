import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'URL Searcher WebScraper';
  searchSelected: boolean = true;

  onClickHistory() {
    this.searchSelected = false;
    console.log(this.searchSelected)
  }

  onClickSearch() {
    this.searchSelected = true;
    console.log(this.searchSelected)
  }

  getSearchTabClass() {
    return this.searchSelected ? "nav-link active" : "nav-link";
  }

  getHistoryTabClass() {
    return this.searchSelected ? "nav-link" : "nav-link active";
  }

}
