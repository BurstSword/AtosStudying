import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Employee } from 'src/app/interfaces/interfaces';
import { EmployeeService } from 'src/app/services/employee.service';
import { ModalService } from 'src/app/services/modal.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {

  //Attribute received from Home Component
  @Input() employee: Employee
  @Output() modalClose: EventEmitter<boolean> = new EventEmitter()
  constructor(public modalService: ModalService, private _employeeService: EmployeeService) { }

  ngOnInit(): void {
  }

  /**
   * Method for creating or editing an Employee in DB
   */
  createEdit() {
    console.log(this.employee);
    if (this.employee.empid == null) {
      this._employeeService.createEmployee(this.employee).subscribe(() => {
        this.modalClose.emit();
      });
    } else {
      this._employeeService.editEmployee(this.employee).subscribe(() => {
        this.modalClose.emit();
      })
    }
    this.modalService.openCloseModal();
  }

}
