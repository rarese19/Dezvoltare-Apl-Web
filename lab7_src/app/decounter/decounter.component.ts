import {Component, OnChanges, OnDestroy, OnInit, SimpleChanges} from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatButtonModule} from "@angular/material/button";
import {MatCardModule} from "@angular/material/card";

@Component({
  selector: 'app-decounter',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatCardModule],
  templateUrl: './decounter.component.html',
  styleUrl: './decounter.component.scss'
})
export class DecounterComponent implements OnInit, OnDestroy, OnChanges{
  public counter: number = 5;

  decreaseCounter() {
    this.counter--;
  }

  constructor() {
  }
  ngOnChanges(changes: SimpleChanges): void {
  }

  ngOnDestroy(): void {
  }

  ngOnInit(): void {
  }

}
