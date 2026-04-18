import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home';
import { OrdersComponent } from './components/orders/orders';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'orders', component: OrdersComponent }
];