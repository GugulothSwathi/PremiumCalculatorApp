import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


export interface PremiumRequest {
name: string;
ageNextBirthday: number;
dateOfBirth: string; // MM/YYYY
occupation: string;
deathSumInsured: number;
}
export interface PremiumResponse {
monthlyPremium: number;
occupation: string;
factor: number;
age: number;
}
@Injectable({
  providedIn: 'root',
})
export class PremiumService {
  private apiUrl = 'https://localhost:5001/api/Premium'; 


constructor(private http: HttpClient) {}


calculate(req: PremiumRequest): Observable<PremiumResponse> {
return this.http.post<PremiumResponse>(`${this.apiUrl}/calculate`, req);
}
}
