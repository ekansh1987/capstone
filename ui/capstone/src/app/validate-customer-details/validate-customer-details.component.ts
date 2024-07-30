import { Component } from '@angular/core';
import { Customer } from '../Model/customerModel';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CapstoneService } from '../service/capstoneservice';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-validate-customer-details',
  templateUrl: './validate-customer-details.component.html',
  styleUrls: ['./validate-customer-details.component.css']
})
export class ValidateCustomerDetailsComponent {

  customer!:Customer;
  events: string[] = [];
  form: FormGroup = new FormGroup({
    id:new FormControl(''),
    name:new FormControl(''),
    address:new FormControl(''),
    email:new FormControl(''),
    dob:new FormControl(''),
    simnumber: new FormControl(),
    servicenumber: new FormControl(),
    firstname:new FormControl(''),
    lastname:new FormControl(''),
    adharnumber:new FormControl(''),
  });
  submitted = false;

  constructor(private formBuilder: FormBuilder,private capstoneservice:CapstoneService,public toastr: ToastrService,) {
    
  }

  ngOnInit(){
    this.form = this.formBuilder.group(
      {
        email: ['', 
                      [
                        Validators.required,
                        Validators.email,
                        Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')
                      ],
                    ],
        firstname: [
          '',
          [
            Validators.required,
            Validators.maxLength(15)
          ],
        ],
        lastname: [
          '',
          [
            Validators.required,
            Validators.maxLength(15)
          ],
        ]
      }
    );
  }
  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
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
    console.log(this.customer);
    
     this.capstoneservice.validatecustomerdetails(this.customer).subscribe((response)=>{
       if(response=="Invalid Customer! This Customer does not exists."){
         this.toastr.error(response);
       }
       else{
         this.toastr.success(response, 'Validate Successfully', {
           timeOut: 3000,
         });
         this.onReset();
       }
      
     });
  }
  onReset(): void {
    this.submitted = false;
    this.form.reset();
  }
}
