import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LocalepageComponent } from './localepage.component';

describe('LocalepageComponent', () => {
  let component: LocalepageComponent;
  let fixture: ComponentFixture<LocalepageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LocalepageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LocalepageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
