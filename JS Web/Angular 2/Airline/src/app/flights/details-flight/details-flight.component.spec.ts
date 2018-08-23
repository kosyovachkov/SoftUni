import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsFlightComponent } from './details-flight.component';

describe('DetailsFlightComponent', () => {
  let component: DetailsFlightComponent;
  let fixture: ComponentFixture<DetailsFlightComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DetailsFlightComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailsFlightComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
