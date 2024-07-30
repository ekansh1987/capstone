import { Component } from '@angular/core';
import { Customer } from '../Model/customerModel';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CapstoneService } from '../service/capstoneservice';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-validate-idproof',
  templateUrl: './validate-idproof.component.html',
  styleUrls: ['./validate-idproof.component.css']
})
export class ValidateIdproofComponent {
  customer!:Customer;
  events: string[] = [];
  form: FormGroup = new FormGroup({
    id:new FormControl(''),
    name:new FormControl(''),
    address:new FormControl(''),
    email:new FormControl(''),
    dob:new FormControl(''),
    simnumber: new FormControl(0),
    servicenumber: new FormControl(0),
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
        adharnumber: ['', 
                      [
                        Validators.required,
                        Validators.minLength(12),
                        Validators.maxLength(12),
                        Validators.pattern("^[0-9]*$")
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
    
     this.capstoneservice.validateidproof(this.customer).subscribe((response)=>{
       if(response=="Customer Not Found."){
         this.toastr.error(response);
       }
       else{
         this.toastr.success(response, '', {
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
