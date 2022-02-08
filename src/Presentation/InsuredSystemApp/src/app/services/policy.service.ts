import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListResponseModel } from '../models/listResponseModel';
import { Policy } from '../models/policy';

@Injectable({
  providedIn: 'root'
})
export class PolicyService {

  apiUrl = 'https://localhost:5001/api/';

  constructor(private httpClient : HttpClient) { }


  getAllPolicies():Observable<ListResponseModel<Policy>>{
    let newPath = this.apiUrl + "policies/getall"
    return this.httpClient.get<ListResponseModel<Policy>>(newPath);

  }


}
