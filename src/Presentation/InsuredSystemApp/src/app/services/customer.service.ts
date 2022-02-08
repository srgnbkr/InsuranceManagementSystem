import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ResponseModel } from '../models/resposeModel';
import { Customer } from '../models/customer';



@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  apiUrl = 'https://localhost:5001/api/';

  constructor(private httpClient : HttpClient) { }


  customerAdd(customer : Customer):Observable<ResponseModel>{
    return this.httpClient.post<ResponseModel>(this.apiUrl+'customers/add',customer);


  }
}
