import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfesoriComponent } from './profesori.component';

describe('ProfesoriComponent', () => {
  let component: ProfesoriComponent;
  let fixture: ComponentFixture<ProfesoriComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProfesoriComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProfesoriComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
