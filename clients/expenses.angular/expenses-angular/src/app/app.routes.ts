import { Routes } from '@angular/router';
import { TransactionListComponent } from './transaction-list/transaction-list';
import { Login } from './login/login';
import { Signup } from './signup/signup';
import { TransactionFormComponent } from './transaction-form/transaction-form';

export const routes: Routes = [
    {path:'',redirectTo:'/transactions',pathMatch:'full'},
    {path:'transactions',component:TransactionListComponent},    
    {path:'login',component:Login},
    {path:'signup',component:Signup},
    {path:'create',component:TransactionFormComponent},
    {path:'edit/:id',component:TransactionFormComponent},
    {path:'**',redirectTo:'/transactions'}
];
