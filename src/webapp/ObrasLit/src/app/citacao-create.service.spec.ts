import { TestBed } from '@angular/core/testing';

import { CitacaoCreateService } from './citacao-create.service';

describe('CitacaoCreateService', () => {
  let service: CitacaoCreateService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CitacaoCreateService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
