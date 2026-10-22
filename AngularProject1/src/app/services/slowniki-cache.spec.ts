import { TestBed } from '@angular/core/testing';
import { SlownikiCache } from './slowniki-cache';

describe('SlownikiCache', () => {
  let service: SlownikiCache;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SlownikiCache);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
