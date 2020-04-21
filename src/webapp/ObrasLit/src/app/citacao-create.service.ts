import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { CitacaoRequest } from "./models/citacaoRequest";
import { CitacaoResponse } from "./models/citacaoResponse";

@Injectable({
  providedIn: 'root'
})
export class CitacaoCreateService {

  myAppUrl: string;
  myApiUrl: string;

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json; charset=utf-8'
    })
  };

  constructor(private http: HttpClient) {
    this.myAppUrl = "http://localhost:5000/";
    this.myApiUrl = 'api/ObrasLiterarias/citacoes';
  }

  create(request: CitacaoRequest): Observable<CitacaoResponse> {
    var data = this.http.post<CitacaoResponse>(this.myAppUrl + this.myApiUrl, JSON.stringify(request), this.httpOptions);
    return data;
  }

}
