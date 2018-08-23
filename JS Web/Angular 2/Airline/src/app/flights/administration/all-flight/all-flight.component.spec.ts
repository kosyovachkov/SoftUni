import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AllFlightComponent } from './all-flight.component';

describe('AllFlightComponent', () => {
  let component: AllFlightComponent;
  let fixture: ComponentFixture<AllFlightComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AllFlightComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AllFlightComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
