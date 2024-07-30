import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Customer } from '../Model/customerModel';
import { Offers } from '../Model/offerModel';
 

@Injectable({
    providedIn: 'root',
   })
   export class CapstoneService {
    private baseUrl = 'https://localhost:7164/api/Capstone';
   
   constructor(private http: HttpClient) {}
   
   getCustomers(): Observable<Customer[]> {
    return this.http.get<Customer[]>(`${this.baseUrl}/getcustomerdata`);
    }

    validateSimandservice(customer:Customer): Observable<string> {
        return this.http.post(`${this.baseUrl}/validate-sim`,customer,{ responseType: 'text'});
    }
    validatecustomer(customer:Customer): Observable<string> {
        return this.http.post(`${this.baseUrl}/validate-customer`,customer,{ responseType: 'text'});
    }
    validatecustomerdetails(customer:Customer): Observable<string> {
        return this.http.post(`${this.baseUrl}/validate-customer-details`,customer,{ responseType: 'text'});
    }
    validateidproof(customer:Customer): Observable<string> {
        return this.http.post(`${this.baseUrl}/validate-id-proof`,customer,{ responseType: 'text'});
    }  
    getallOffers(offers:Offers): Observable<Offers[]> {
        return this.http.post<Offers[]>(`${this.baseUrl}/special-offers`,offers);
    }   
   }