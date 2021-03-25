import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/interfaces/interfaces';
import { EmployeeService } from 'src/app/services/employee.service';
import { ModalService } from 'src/app/services/modal.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public employeeList: Employee[] = [];
  public employee: Employee={
    empname:"",
    age:0,
    dni:""
  }
  constructor(private _employeeService: EmployeeService, private _modalService: ModalService) { }


  ngOnInit(): void {
    this.getEmployees();
  }

  /**
   * This method brings employees from DB
   */
  getEmployees() {
    this._employeeService.getEmployees().subscribe(resp => {
      this.employeeList = resp;
    }, err => {
      console.log(err)
    });
  }

  /**
   * This method edits an employee from DB
   * @param emp An edited employee
   */
  editEmployee(emp?: Employee) {
    if(emp) {
      this.employee = {... emp}

    } else {
      this.employee = {
        empname: '',
        age:0,
        dni:""
      }
    }
    this._modalService.openCloseModal();
  }
/**
 * This method removes an employee from DB
 * @param emp The employee to be removed
 */
  removeEmployee(emp:Employee){
    this._employeeService.deleteEmployee(emp).subscribe(()=>{
      this.getEmployees();
    })
  }
  
}
