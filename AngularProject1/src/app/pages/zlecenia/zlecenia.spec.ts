import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Zlecenia } from './zlecenia';

describe('Zlecenia', () => {
  let component: Zlecenia;
  let fixture: ComponentFixture<Zlecenia>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Zlecenia],
    }).compileComponents();

    fixture = TestBed.createComponent(Zlecenia);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
