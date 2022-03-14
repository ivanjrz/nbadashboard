import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditTeamHistoryComponent } from './add-edit-teamhistory.component';

describe('AddEditTeamHistoryComponent', () => {
  let component: AddEditTeamHistoryComponent;
  let fixture: ComponentFixture<AddEditTeamHistoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddEditTeamHistoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditTeamHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
