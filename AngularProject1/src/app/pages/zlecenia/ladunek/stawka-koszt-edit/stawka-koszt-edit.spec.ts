import { ComponentFixture, TestBed } from '@angular/core/testing';
import { StawkaKosztEdit } from './stawka-koszt-edit';

describe('StawkaKosztEdit', () => {
  let component: StawkaKosztEdit;
  let fixture: ComponentFixture<StawkaKosztEdit>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StawkaKosztEdit],
    }).compileComponents();

    fixture = TestBed.createComponent(StawkaKosztEdit);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
