import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{MatSidenavModule} from '@angular/material/sidenav';
import{MatTabsModule} from '@angular/material/tabs'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavtabsComponent } from './navigation/navtabs/navtabs.component';
import { SidenavListComponent } from './navigation/sidenav-list/sidenav-list.component';
import { ToolbarComponent } from './navigation/toolbar/toolbar.component';
import{MatListModule} from '@angular/material/list';
import{MatIconModule} from '@angular/material/icon';
import{MatToolbarModule} from '@angular/material/toolbar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import{MatBadgeModule} from '@angular/material/badge';
import { CustomerComponent } from './customer/customer.component';
import { ValidateSimComponent } from './validate-sim/validate-sim.component';
import { ValidateCustomerComponent } from './validate-customer/validate-customer.component';
import { ValidateCustomerDetailsComponent } from './validate-customer-details/validate-customer-details.component';
import { ValidateIdproofComponent } from './validate-idproof/validate-idproof.component';
import { SpecialOfferComponent } from './special-offer/special-offer.component';
import{MatInputModule} from '@angular/material/input';
import{MatTableModule} from '@angular/material/table';
import{MatPaginatorModule} from '@angular/material/paginator';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import {ToastrModule} from 'ngx-toastr'
import{MatDatepickerModule} from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatCardModule } from '@angular/material/card';
import{DatePipe} from '@angular/common';
import{NgxSmartModalModule,NgxSmartModalService} from 'ngx-smart-modal';
import { FormsModule } from '@angular/forms';
import{MatDialogModule} from '@angular/material/dialog';
import{MatButtonModule} from '@angular/material/button';
import{MatCommonModule} from '@angular/material/core';
import{MatFormFieldModule} from '@angular/material/form-field';



@NgModule({
  declarations: [
    AppComponent,
    NavtabsComponent,
    SidenavListComponent,
    ToolbarComponent,
    CustomerComponent,
    ValidateSimComponent,
    ValidateCustomerComponent,
    ValidateCustomerDetailsComponent,
    ValidateIdproofComponent,
    SpecialOfferComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatSidenavModule,
    MatTabsModule,
    MatListModule,
    MatIconModule,
    MatToolbarModule,
    BrowserAnimationsModule,
    MatBadgeModule,
    MatInputModule,
    MatTableModule,
    MatPaginatorModule,
    HttpClientModule,
    ReactiveFormsModule,
    ToastrModule.forRoot(),
    MatDatepickerModule,
    MatNativeDateModule,
    MatCardModule,
    FormsModule,
    NgxSmartModalModule.forRoot(),
    MatDialogModule,
    MatButtonModule, 
    MatCommonModule, 
    MatFormFieldModule
    
  ],
  providers: [MatDatepickerModule,DatePipe,NgxSmartModalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
