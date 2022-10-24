import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeeMemberComponent } from './see-member.component';

describe('SeeMemberComponent', () => {
  let component: SeeMemberComponent;
  let fixture: ComponentFixture<SeeMemberComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SeeMemberComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SeeMemberComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
