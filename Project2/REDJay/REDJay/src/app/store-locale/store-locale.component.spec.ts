import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StoreLocaleComponent } from './store-locale.component';

describe('StoreLocaleComponent', () => {
  let component: StoreLocaleComponent;
  let fixture: ComponentFixture<StoreLocaleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StoreLocaleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StoreLocaleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
