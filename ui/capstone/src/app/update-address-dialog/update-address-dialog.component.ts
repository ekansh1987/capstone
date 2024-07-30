import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  FormControl,
  Validators,
  FormsModule
} from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CapstoneService } from '../service/capstoneservice';
import { Customer } from '../Model/customerModel';
import { Router } from '@angular/router';

@Component({
  selector: 'app-update-address-dialog',
  templateUrl: './update-address-dialog.component.html',
  styleUrls: ['./update-address-dialog.component.css']
})
export class UpdateAddressDialogComponent {
  
  address:string='';
  city:string='';
  pincode:number=0;
  state:string='';
  id:number=0;
  customer!:Customer;
  form: FormGroup = new FormGroup({
    id:new FormControl(),
    name:new FormControl(''),
    address:new FormControl(''),
    email:new FormControl(''),
    dob:new FormControl(''),
    simnumber: new FormControl(),
    servicenumber: new FormControl(),
  });

  submitted = false;

  constructor(private dialogRef: MatDialogRef<UpdateAddressDialogComponent>,@Inject(MAT_DIALOG_DATA) private data: any,public toastr: ToastrService,
  private formBuilder: FormBuilder,private capstoneService: CapstoneService,public router:Router){
    this.getDataById();
  }

  ngOnInit(){
    
    this.form = this.formBuilder.group(
      {
        address: ['', 
                      [
                        Validators.required
                      ],
                    ],
        city: ['',
                  [
                    Validators.required
                  ],
              ],
        pincode: ['',
                  [
                    Validators.required
                  ],
                 ],
        state: ['',
                  [
                    Validators.required
                  ],
               ],
        id: ['',
                [
                  Validators.nullValidator
                ],
             ]
            
      }
    );
  }
  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
  }
  getDataById(){
    
    this.capstoneService.getCustomerById(this.data.customer).subscribe((response)=>
      { 
       if(response!=null)
         {
            
            this.state=response.state;
            this.city=response.city;
            this.pincode=response.pinCode;
            this.address=response.address;
            this.id=response.id;
         }
      }
     
     );
  }
  onNoClick() {
    this.dialogRef.close();
    
  }

  onSubmit(): void {
    
    this.submitted = true;
    
    if (this.form.invalid) {
      this.toastr.error("Please fill all details", 'Error', {
        timeOut: 3000,
      });
      return
    }
    
    this.customer=this.form.value;
    
    this.capstoneService.updateCustomerAddress(this.customer).subscribe((response)=>{
      this.toastr.success(response, 'Success', {
        timeOut: 3000,
      });
     
    });
    this.router.navigateByUrl('/customer');
    this.dialogRef.close();
  }
}
