import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';


import { ProfesoriComponent } from './profesori/profesori.component';
import { MateriiComponent } from './materii/materii.component';
import { AsignareComponent } from './asignare/asignare.component';
import { routes } from './app.routes';
import { DataService } from './services/data.service';

@NgModule({
  declarations: [
    ProfesoriComponent,
    MateriiComponent,
    AsignareComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    HttpClientModule
  ],
  providers: [DataService],
  bootstrap: []
})
export class AppModule { }
