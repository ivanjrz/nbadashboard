import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowTeamHistoryComponent } from './show-teamhistory.component';

describe('ShowTeamHistoryComponent', () => {
  let component: ShowTeamHistoryComponent;
  let fixture: ComponentFixture<ShowTeamHistoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowTeamHistoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowTeamHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
