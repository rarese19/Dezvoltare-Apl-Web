import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private apiUrl = 'https://localhost:7065/swagger/';

  constructor(private http: HttpClient) { }

  getProfesori(): Observable<any> {
    return this.http.get(`${this.apiUrl}/api/Profesor/getAllProf`);
  }

  getMaterii(): Observable<any> {
    return this.http.get(`${this.apiUrl}/api/Materie/getAllMaterii`);
  }

  asignareMaterie(profesorId: number, materieId: number): Observable<any> {
    return this.http.post(`${this.apiUrl}/api/ProfesorMaterie/assign`, { profesorId, materieId });
  }
}
