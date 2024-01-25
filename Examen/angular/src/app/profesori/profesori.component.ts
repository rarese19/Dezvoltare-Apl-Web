import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-profesori',
  templateUrl: './profesori.component.html',
  styleUrls: ['./profesori.component.scss']
})
export class ProfesoriComponent implements OnInit {
  profesori: any[] = [];

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    this.dataService.getProfesori().subscribe(
      (data: any[]) => this.profesori = data,
      error => console.error(error)
    );
  }
}
