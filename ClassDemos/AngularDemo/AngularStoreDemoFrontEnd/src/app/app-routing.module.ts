import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { RegisterCustomerComponent } from './register-customer/register-customer.component';
import { LoginCustomerComponent } from './login-customer/login-customer.component';

const routes: Routes = [
  {path:'', redirectTo:'/', pathMatch:'full'},
  { path: 'login', component: LoginCustomerComponent },
  {path: 'register', component: RegisterCustomerComponent},
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
