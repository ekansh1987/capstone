import { Component, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Customer } from '../Model/customerModel';
import{MatPaginator} from '@angular/material/paginator';
import{CapstoneService} from '../service/capstoneservice';
import { FormGroup, NgForm } from '@angular/forms';
import { NgxSmartModalService } from 'ngx-smart-modal';
 

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent {

customers:Customer[]=[];
displayedColumns=['name','email','dob','address'];
dataSource:MatTableDataSource<Customer>;
@ViewChild(MatPaginator) paginator!:MatPaginator;

// @ViewChild('myform') form!: NgForm;

editMode = false;
editIndex:any;

constructor(private capstoneService:CapstoneService,
  public ngxSmartModalService: NgxSmartModalService){
  this.dataSource=new MatTableDataSource(this.customers);
  this.capstoneService.getCustomers().subscribe((response)=>
   { 
    if(response!=null)
      {
        
        this.dataSource=new MatTableDataSource(response);
        this.dataSource.paginator=this.paginator;
      }
   }
  
  );
}
ngOnInit():void{

  
}

ngAfterViewInit(){
  this.dataSource.paginator=this.paginator;
}

//  addData(form:any){
//    var val = form.controls;
//    const newData ={
//      recipient : val.rec.value,
//      message : val.msg.value
//    }
//   //  if(this.editMode){
//   //    this.data[this.editIndex] = newData;
//   //  }else{
//   //    this.data.push(newData);
//   //  }
//    this.form.reset();
//   this.ngxSmartModalService.close('myModal');
//  }

// onEdit(index){
//   // this.editMode = true;
//   // this.editIndex = index;
//   // this.ngxSmartModalService.open('myModal');
//   // this.form.setValue({
//   //   rec:this.data[index].recipient,
//   //   msg:this.data[index].message
//   // });
// }

//  closeModal(id:any){
//    this.form.reset();
//   this.editMode=false;
//   this.ngxSmartModalService.close(id);
 //}
}
