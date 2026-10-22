import { ComponentFixture, TestBed } from '@angular/core/testing';
import { TowarEdit } from './towar-edit';

describe('TowarEdit', () => {
  let component: TowarEdit;
  let fixture: ComponentFixture<TowarEdit>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TowarEdit],
    }).compileComponents();

    fixture = TestBed.createComponent(TowarEdit);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
