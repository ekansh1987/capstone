import { Component } from '@angular/core';
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

@Component({
  selector: 'app-validate-sim',
  templateUrl: './validate-sim.component.html',
  styleUrls: ['./validate-sim.component.css']
})
export class ValidateSimComponent {

  customer!:Customer;

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

  constructor(private formBuilder: FormBuilder,private capstoneservice:CapstoneService,public toastr: ToastrService) {

  }

  ngOnInit(){
    this.form = this.formBuilder.group(
      {
        simnumber: ['', 
                      [
                        Validators.required,
                        Validators.pattern("^[0-9]*$"),
                        Validators.minLength(13),
                        Validators.maxLength(13),
                      ],
                    ],
        servicenumber: [
          '',
          [
            Validators.required,
            Validators.pattern("^[0-9]*$"),
            Validators.minLength(10),
            Validators.maxLength(10),
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
      return;
    }
    
    this.customer=this.form.value;
    console.log(this.customer);
    this.capstoneservice.validateSimandservice(this.customer).subscribe((response)=>{
      if(response=="Sim and service number combination not found."){
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
