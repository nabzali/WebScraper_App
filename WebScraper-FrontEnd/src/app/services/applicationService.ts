import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { searchRequest } from '../models/searchRequest';
import { searchResponse } from '../models/searchResponse';
import { Observable, catchError } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ApplicationService {

    private baseUrl = "https://localhost:44380/";

    constructor(private http: HttpClient) {
    }

    createSearchRequest(searchRequest: searchRequest) : Observable<searchResponse>{
        return this.http.post<searchResponse>(this.baseUrl + "api/search", searchRequest)
            .pipe(
                catchError((error: any) => {
                    // Handling error
                    console.error('Error occurred:', error);
                    throw error;
                })
            );
    }

    getSearchHistory(): Observable<searchResponse[]>{
       return this.http.get<searchResponse[]>("https://localhost:44380/api/history"); 
    }

}