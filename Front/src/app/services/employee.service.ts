import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Employee } from '../interfaces/interfaces';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private _httpClient:HttpClient) { }


  getEmployees(){
    return this._httpClient.get<Employee[]>(`${environment.url}`);
  }

  createEmployee(emp:Employee){
    
    return this._httpClient.post<Employee>(`${environment.url}`,emp);
  }

  editEmployee(emp:Employee){
    return this._httpClient.put(`${environment.url}/${emp.empid}`,emp);
  }

  deleteEmployee(emp:Employee){
    return this._httpClient.delete(`${environment.url}/${emp.empid}`);
  }

}
