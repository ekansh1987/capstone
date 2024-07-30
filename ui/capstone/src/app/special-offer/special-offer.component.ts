import { Component } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormGroup,
  FormControl,
  Validators,
} from '@angular/forms';
import { CapstoneService } from '../service/capstoneservice';
import{ToastrService} from 'ngx-toastr';
import { Offers } from '../Model/offerModel';

@Component({
  selector: 'app-special-offer',
  templateUrl: './special-offer.component.html',
  styleUrls: ['./special-offer.component.css']
})
export class SpecialOfferComponent {
  offer!:Offers;
  specialoffers:Offers[]=[];
  form: FormGroup = new FormGroup({
    id:new FormControl(0),
    netdata:new FormControl(''),
    sms:new FormControl(''),
    validity:new FormControl(0),
    otherbenifits:new FormControl(''),
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
    
    this.offer=this.form.value;
    console.log(this.offer);
    this.capstoneservice.getallOffers(this.offer).subscribe((response)=>{
        this.specialoffers=response;

    });
  }
  onReset(): void {
    this.submitted = false;
    this.form.reset();
  }
}
