import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { searchRequest } from '../models/searchRequest';
import { searchResponse } from '../models/searchResponse';
import { Observable } from 'rxjs';

@Injectable()
export class applicationService {

    baseUrl = 'http://localhost:5000/';

    constructor(private http: HttpClient) {
    }

    createSearchRequest(searchRequest: searchRequest) {
        this.http.post<searchResponse>(this.baseUrl + 'Search/Search', searchRequest);
    }

    getSearchResponse(): Observable<searchResponse> {
        return this.http.get<searchResponse>(this.baseUrl + 'Search/History');
    }

    getSearchHistory(): Observable<searchResponse[]>{
       return this.http.get<searchResponse[]>(this.baseUrl + 'Search/History');; 
    }

}