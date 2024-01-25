import { Routes } from '@angular/router';
import { ProfesoriComponent } from './profesori/profesori.component';
import { MateriiComponent } from './materii/materii.component';
import { AsignareComponent } from './asignare/asignare.component';

export const routes: Routes = [
  { path: 'profesori', component: ProfesoriComponent },
  { path: 'materii', component: MateriiComponent },
  { path: 'asignare', component: AsignareComponent },
  { path: '', redirectTo: '/profesori', pathMatch: 'full' }
];
