import { Routes } from '@angular/router';
import { TransactionListComponent } from './components/transaction-list/transaction-list';
import { Login } from './components/login/login';
import { Signup } from './components/signup/signup';
import { TransactionFormComponent } from './components/transaction-form/transaction-form';

export const routes: Routes = [
    {path:'',redirectTo:'/transactions',pathMatch:'full'},
    {path:'transactions',component:TransactionListComponent},    
    {path:'login',component:Login},
    {path:'signup',component:Signup},
    {path:'create',component:TransactionFormComponent},
    {path:'edit/:id',component:TransactionFormComponent},
    {path:'**',redirectTo:'/transactions'}
];
