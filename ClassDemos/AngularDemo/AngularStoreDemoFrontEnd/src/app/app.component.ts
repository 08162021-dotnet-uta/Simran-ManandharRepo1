import { Component } from '@angular/core';
import { Customer } from './customer';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Simrans Angular Demo';
  something?: string;
  logintrue: boolean = false;
  registertrue: boolean = false;

  titleClicked(value:string) {
    console.log(`${value} was clicked`)
  }

  logincustomer() {
    if (this.registertrue) {
      this.registertrue = false;
    }
    this.logintrue = !this.logintrue;
    // this.registertrue = false;
  }

  registercustomer() {
    if (this.logintrue) {
      this.logintrue = false;
    }
    this.registertrue = !this.registertrue;
    // this.logintrue = false;

  }

  registernewcustomer(cust: Customer) {
    //do something with the customer
    console.log(`The new customer is ${cust.fname} ${cust.lname}`)
  }
}
