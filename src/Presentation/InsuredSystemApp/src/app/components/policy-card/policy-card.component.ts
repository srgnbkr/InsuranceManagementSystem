import { PolicyService } from './../../services/policy.service';
import { Component, OnInit } from '@angular/core';
import { Policy } from 'src/app/models/policy';

@Component({
  selector: 'app-policy-card',
  templateUrl: './policy-card.component.html',
  styleUrls: ['./policy-card.component.scss']
})
export class PolicyCardComponent implements OnInit {

  policies : Policy[] = [];

  constructor(private policyService:PolicyService) { }

  ngOnInit(): void {
    this.getAllPolicies();
  }

  getAllPolicies(){
    this.policyService.getAllPolicies().subscribe(response =>{
      this.policies = response.data;
    })
  }

}
