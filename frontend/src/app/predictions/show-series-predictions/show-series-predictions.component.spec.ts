import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowSeriesPredictionsComponent } from './show-series-predictions.component'

describe('ShowSeriesPredictionsComponent', () => {
  let component: ShowSeriesPredictionsComponent;
  let fixture: ComponentFixture<ShowSeriesPredictionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowSeriesPredictionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowSeriesPredictionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
