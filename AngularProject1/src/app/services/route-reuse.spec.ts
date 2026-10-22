import { TestBed } from '@angular/core/testing';
import { RouteReuse } from './route-reuse';

describe('RouteReuse', () => {
  let service: RouteReuse;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RouteReuse);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
