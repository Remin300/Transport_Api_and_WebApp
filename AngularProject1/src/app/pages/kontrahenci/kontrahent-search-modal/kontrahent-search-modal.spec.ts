import { ComponentFixture, TestBed } from '@angular/core/testing';
import { KontrahentSearchModal } from './kontrahent-search-modal';

describe('KontrahentSearchModal', () => {
  let component: KontrahentSearchModal;
  let fixture: ComponentFixture<KontrahentSearchModal>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [KontrahentSearchModal],
    }).compileComponents();

    fixture = TestBed.createComponent(KontrahentSearchModal);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
