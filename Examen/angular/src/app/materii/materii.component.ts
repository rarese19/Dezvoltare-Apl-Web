import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-materii',
  templateUrl: './materii.component.html',
  styleUrls: ['./materii.component.scss']
})
export class MateriiComponent implements OnInit {
  materii: any[] = [];

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    this.dataService.getMaterii().subscribe(
      (data: any[]) => this.materii = data,
      error => console.error(error)
    );
  }
}
