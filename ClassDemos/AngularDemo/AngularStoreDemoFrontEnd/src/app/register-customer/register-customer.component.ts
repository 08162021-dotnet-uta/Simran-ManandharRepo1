import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { Customer } from '../customer';

@Component({
  selector: 'app-register-customer',
  templateUrl: './register-customer.component.html',
  styleUrls: ['./register-customer.component.css']
})
export class RegisterCustomerComponent implements OnInit {
  @Input() registertrue: boolean = false;
  fname: string = '';
  lname: string = '';
  @Output() passNewCustomerToParent = new EventEmitter<Customer>();

  constructor() { }

  ngOnInit(): void {
    // this.registertrue = true;
  }

  registercustomer():void {
    let c: Customer = { fname: this.fname, lname: this.lname };
    console.log(`New customer is: ${this.fname} ${this.lname}`)
    this.passNewCustomerToParent.emit(c);
  }

}
