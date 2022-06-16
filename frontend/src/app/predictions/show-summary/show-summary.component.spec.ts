import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowPredictionsSummaryComponent } from './show-summary.component';

describe('ShowPredictionsSummaryComponent', () => {
  let component: ShowPredictionsSummaryComponent;
  let fixture: ComponentFixture<ShowPredictionsSummaryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowPredictionsSummaryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowPredictionsSummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
