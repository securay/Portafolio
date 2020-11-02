import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-list-dep',
  templateUrl: './list-dep.component.html',
  styleUrls: ['./list-dep.component.css']
})
export class ListDepComponent implements OnInit {

  constructor(private service : SharedService) { }

  DepartmentList:any = [];

  ModalTitle: string;
  ActivateAddEditDepComp: boolean = false;
  dep: any;

  DepartmentIdFilter: string = "";
  DepartmentNameFilter: string = "";
  DepartmentListWithoutFilter: any = [];

  ngOnInit(): void {
    this.refreshDepartmentList();
  }

  addClick(): void {
    this.dep = {
      Id: 0,
      Name: ""
    };
    this.ModalTitle = "Add Department";
    this.ActivateAddEditDepComp = true;
  }

  editClick(item: any): void {
    this.dep = item;
    this.ModalTitle = "Edit Department";
    this.ActivateAddEditDepComp = true;
  }

  deleteClick(item: any): void {
    if (confirm('Are you sure?')) {
      this.service.deleteDepartment(item.Id).subscribe(data => {
        alert(data.toString());
        this.refreshDepartmentList();
      });
    }
  }

  closeClick(): void {
    this.ActivateAddEditDepComp = false;
    this.refreshDepartmentList();
  }

  refreshDepartmentList() {
    this.service.getDepartmentList().subscribe(data => {
      this.DepartmentList = data;
      this.DepartmentListWithoutFilter = data;
    });
  }

  FilterFn(): void {
    var idF = this.DepartmentIdFilter;
    var nameF = this.DepartmentNameFilter;

    this.DepartmentList = this.DepartmentListWithoutFilter.filter(function (el) {
      return el.Id.toString().toLowerCase().includes(idF.toString().trim().toLowerCase()) &&
        el.Name.toString().toLowerCase().includes(nameF.toString().trim().toLowerCase());
    });
  }
  sortResult(prop: any, asc: boolean): void {
    this.DepartmentList = this.DepartmentListWithoutFilter.sort(function(a: any, b: any)
    {
      if (asc) {
        return a[prop] > b[prop] ? 1 : (a[prop] < b[prop] ? -1 : 0);
      } else {
        return b[prop] > a[prop] ? 1 : (b[prop] < a[prop] ? -1 : 0);
      }
    });
  }
}
