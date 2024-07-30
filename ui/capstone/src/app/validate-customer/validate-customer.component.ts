import { Component } from '@angular/core';
import {MatDatepickerInputEvent} from '@angular/material/datepicker';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  FormControl,
  Validators,
} from '@angular/forms';
import { CapstoneService } from '../service/capstoneservice';
import { Customer } from '../Model/customerModel';
import{ToastrService} from 'ngx-toastr';
import { DateAdapter } from '@angular/material/core';
import { DatePipe } from '@angular/common'

@Component({
  selector: 'app-validate-customer',
  templateUrl: './validate-customer.component.html',
  styleUrls: ['./validate-customer.component.css']
})
export class ValidateCustomerComponent {

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
  });
  submitted = false;

  constructor(private formBuilder: FormBuilder,private capstoneservice:CapstoneService,public toastr: ToastrService,
    private dateAdapter: DateAdapter<Date>,private datepipe:DatePipe) {
    this.dateAdapter.setLocale('en-GB'); //dd/MM/yyyy

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
        dob: [
          '',
          [
            Validators.required
          ],
        ]
      }
    );
  }
  addEvent(type: string, event: MatDatepickerInputEvent<Date>) {
    this.events.push(`${type}: ${event.value}`);
    console.log(this.events);
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
    
    let latest_date =this.datepipe.transform(this.form.value["dob"], 'dd-MM-yyyy');
    this.form.value["dob"]=latest_date;
    this.customer=this.form.value;
    console.log(this.customer);
    
     this.capstoneservice.validatecustomer(this.customer).subscribe((response)=>{
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

