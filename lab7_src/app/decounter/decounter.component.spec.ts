import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DecounterComponent } from './decounter.component';

describe('DecounterComponent', () => {
  let component: DecounterComponent;
  let fixture: ComponentFixture<DecounterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DecounterComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DecounterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
