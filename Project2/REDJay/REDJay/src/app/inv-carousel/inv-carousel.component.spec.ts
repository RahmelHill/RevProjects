import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InvCarouselComponent } from './inv-carousel.component';

describe('InvCarouselComponent', () => {
  let component: InvCarouselComponent;
  let fixture: ComponentFixture<InvCarouselComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InvCarouselComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InvCarouselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
