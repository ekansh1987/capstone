import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerComponent } from './customer/customer.component';
import { ValidateSimComponent } from './validate-sim/validate-sim.component';
import { ValidateCustomerComponent } from './validate-customer/validate-customer.component';
import { ValidateCustomerDetailsComponent } from './validate-customer-details/validate-customer-details.component';
import { ValidateIdproofComponent } from './validate-idproof/validate-idproof.component';
import { SpecialOfferComponent } from './special-offer/special-offer.component';

const routes: Routes = [
  { path: '', component: CustomerComponent },
  { path: 'customer', component: CustomerComponent },
  { path: 'validate-sim', component: ValidateSimComponent },
  { path: 'validate-cutomer', component: ValidateCustomerComponent },
  { path: 'validate-cutomer-details', component: ValidateCustomerDetailsComponent },
  { path: 'validate-id-proof', component: ValidateIdproofComponent },
  { path: 'show-special-offers', component: SpecialOfferComponent }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
