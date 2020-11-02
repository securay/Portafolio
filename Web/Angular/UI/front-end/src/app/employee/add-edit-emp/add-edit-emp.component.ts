import { Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-emp',
  templateUrl: './add-edit-emp.component.html',
  styleUrls: ['./add-edit-emp.component.css']
})
export class AddEditEmpComponent implements OnInit {

  constructor(private service: SharedService) { }

  @Input() emp: any;
  Id: string;
  Name: string;
  DepartmentId: string;
  JoiningDate: string;
  Photo: string;
  PhotoPath: string;

  DepartmentList: any[];

  ngOnInit(): void {
    this.loadDepartmentList();
  }

  loadDepartmentList(): void {
    this.service.getAllDepartmentNames().subscribe((data:any) => {
      this.DepartmentList = data;

      this.Id = this.emp.Id;
      this.Name = this.emp.Name;
      this.DepartmentId = this.emp.DepartmentId;
      this.JoiningDate = this.emp.JoiningDate;
      this.Photo = this.emp.Photo;
      this.PhotoPath = `${ this.service.PhotoURL }/${ this.Photo }`
    });
  }

  addEmployee(): void {
    var val = {
      Id: this.Id,
      Name: this.Name,
      DepartmentId: this.DepartmentId,
      JoiningDate: this.JoiningDate,
      Photo: this.Photo
    };

    this.service.addEmployee(val).subscribe(res => {
      alert(res.toString());
    });
  }

  updateEmployee(): void {
    var val = {
      Id: this.Id,
      Name: this.Name,
      DepartmentId: this.DepartmentId,
      JoiningDate: this.JoiningDate,
      Photo: this.Photo
    };

    this.service.updateEmployee(val).subscribe(res => {
      alert(res.toString());
    });
  }

  uploadPhoto(event): void {
    var file = event.target.files[0];
    const formData: FormData = new FormData();
    formData.append('uploadFile', file, file.name)

    this.service.uploadPhoto(formData).subscribe((data: any) => {
      this.Photo = data.toString();
      this.PhotoPath = `${ this.service.PhotoURL }/${ this.Photo }`
    });
  }
}
