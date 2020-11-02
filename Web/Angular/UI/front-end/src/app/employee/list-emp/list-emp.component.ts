import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-list-emp',
  templateUrl: './list-emp.component.html',
  styleUrls: ['./list-emp.component.css']
})
export class ListEmpComponent implements OnInit {

  constructor(private service : SharedService) { }

  EmployeeList:any = [];

  ModalTitle: string;
  ActivateAddEditEmpComp: boolean = false;
  emp: any;

  ngOnInit(): void {
    this.refreshEmployeeList();
  }

  addClick(): void {
    this.emp = {
      Id: 0,
      Name: "",
      DepartmentId: 0,
      JoiningDate: "",
      Photo: "anon.png"
    };
    this.ModalTitle = "Add Employee";
    this.ActivateAddEditEmpComp = true;
  }

  editClick(item: any): void {
    this.emp = item;
    this.ModalTitle = "Edit Employee";
    this.ActivateAddEditEmpComp = true;
  }

  deleteClick(item: any): void {
    if (confirm('Are you sure?')) {
      this.service.deleteEmployee(item.Id).subscribe(data => {
        alert(data.toString());
        this.refreshEmployeeList();
      });
    }
  }

  closeClick(): void {
    this.ActivateAddEditEmpComp = false;
    this.refreshEmployeeList();
  }

  refreshEmployeeList() {
    this.service.getEmployeeList().subscribe(data => {
      this.EmployeeList = data;
    });
  }
}
