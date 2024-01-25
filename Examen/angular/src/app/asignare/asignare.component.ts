import { Component } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-asignare',
  templateUrl: './asignare.component.html',
  styleUrls: ['./asignare.component.scss']
})
export class AsignareComponent {
  constructor(private dataService: DataService) { }
}
