import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Ladunek } from './ladunek';

describe('Ladunek', () => {
  let component: Ladunek;
  let fixture: ComponentFixture<Ladunek>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Ladunek],
    }).compileComponents();

    fixture = TestBed.createComponent(Ladunek);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
