import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ZlecenieEdit } from './zlecenie-edit';

describe('ZlecenieEdit', () => {
  let component: ZlecenieEdit;
  let fixture: ComponentFixture<ZlecenieEdit>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ZlecenieEdit],
    }).compileComponents();

    fixture = TestBed.createComponent(ZlecenieEdit);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
