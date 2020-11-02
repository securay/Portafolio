import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUURL = 'https://localhost:44389/api';
  readonly PhotoURL = 'https://localhost:44389/Photos';

  constructor(private http:HttpClient) { }

  getDepartmentList():Observable<any[]> {
    return this.http.get<any>(`${ this.APIUURL }/department`);
  }

  addDepartment(val:any) {
    return this.http.post(`${ this.APIUURL }/department`, val);
  }

  updateDepartment(val:any) {
    return this.http.put(`${ this.APIUURL }/department`, val);
  }

  deleteDepartment(val:any) {
    return this.http.delete(`${ this.APIUURL }/department/${ val }`);
  }

  getEmployeeList():Observable<any[]> {
    return this.http.get<any>(`${ this.APIUURL }/employee`);
  }

  addEmployee(val:any) {
    return this.http.post(`${ this.APIUURL }/employee`, val);
  }

  updateEmployee(val:any) {
    return this.http.put(`${ this.APIUURL }/employee`, val);
  }

  deleteEmployee(val:any) {
    return this.http.delete(`${ this.APIUURL }/employee/${ val }`);
  }

  uploadPhoto(val:any) {
    return this.http.post(`${ this.APIUURL }/employee/SaveFile`, val);
  }

  getAllDepartmentNames() : Observable<any[]> {
    return this.http.get<any[]>(`${this.APIUURL}/employee/GetAllDepartmentNames`);
  }
}
