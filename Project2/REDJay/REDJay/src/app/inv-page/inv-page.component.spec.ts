import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InvPageComponent } from './inv-page.component';

describe('InvPageComponent', () => {
  let component: InvPageComponent;
  let fixture: ComponentFixture<InvPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InvPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InvPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
