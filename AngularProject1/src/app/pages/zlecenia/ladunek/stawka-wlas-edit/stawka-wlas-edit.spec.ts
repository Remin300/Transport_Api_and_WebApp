import { ComponentFixture, TestBed } from '@angular/core/testing';
import { StawkaWlasEdit } from './stawka-wlas-edit';

describe('StawkaWlasEdit', () => {
  let component: StawkaWlasEdit;
  let fixture: ComponentFixture<StawkaWlasEdit>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StawkaWlasEdit],
    }).compileComponents();

    fixture = TestBed.createComponent(StawkaWlasEdit);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
