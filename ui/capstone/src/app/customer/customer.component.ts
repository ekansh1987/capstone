import { Component, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Customer } from '../Model/customerModel';
import{MatPaginator} from '@angular/material/paginator';
import{CapstoneService} from '../service/capstoneservice';
import { UpdateAddressDialogComponent } from '../update-address-dialog/update-address-dialog.component';
import {MatDialog, MAT_DIALOG_DATA, MatDialogRef, MatDialogModule} from '@angular/material/dialog';
import { Router } from '@angular/router';
 

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




constructor(private capstoneService:CapstoneService,private dialog: MatDialog,public router:Router){
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

openDialog(customerRow: Customer): void {
  
  const dialogRef = this.dialog.open(UpdateAddressDialogComponent, {
    data: {customer: customerRow},
  });

  dialogRef.afterClosed().subscribe(result => {
    console.log('The dialog was closed');
    this.capstoneService.getCustomers().subscribe((response)=>
      { 
       if(response!=null)
         {
           
           this.dataSource=new MatTableDataSource(response);
           this.dataSource.paginator=this.paginator;
         }
      }
     
     );
  });
}

}
