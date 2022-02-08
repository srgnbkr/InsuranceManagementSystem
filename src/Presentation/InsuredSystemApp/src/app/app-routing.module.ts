import { PolicyCardComponent } from './components/policy-card/policy-card.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerAddComponent } from './components/customer-add/customer-add.component';

const routes: Routes = [
  {path:"customers/add", component:CustomerAddComponent},
  {path:"products",component:PolicyCardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
