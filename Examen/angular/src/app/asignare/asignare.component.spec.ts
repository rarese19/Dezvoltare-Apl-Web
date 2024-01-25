import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AsignareComponent } from './asignare.component';

describe('AsignareComponent', () => {
  let component: AsignareComponent;
  let fixture: ComponentFixture<AsignareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AsignareComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AsignareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
