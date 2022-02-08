import { CustomerService } from './../../services/customer.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-customer-add',
  templateUrl: './customer-add.component.html',
  styleUrls: ['./customer-add.component.scss'],
})
export class CustomerAddComponent implements OnInit {
  customerAddForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private customerService: CustomerService,
    private taostrService: ToastrService
  ) {}

  ngOnInit(): void {
    this.createCustomerAddForm();
  }

  createCustomerAddForm() {
    this.customerAddForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      identityNumber: ['', Validators.required],
      birthYear: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      email: ['', Validators.email],
    });
  }

  customerAdd() {
    if (this.customerAddForm.valid) {
      let customerModel = Object.assign({}, this.customerAddForm.value);
      this.customerService.customerAdd(customerModel).subscribe((response) => {
        this.taostrService.success(response.message,'İşlem Başarılı');
      });
    }else{
      this.taostrService.warning("Formunuz eksik veya hatalı")
    }
  }
}
