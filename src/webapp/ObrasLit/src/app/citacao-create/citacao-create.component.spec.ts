import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CitacaoCreateComponent } from './citacao-create.component';

describe('CitacaoCreateComponent', () => {
  let component: CitacaoCreateComponent;
  let fixture: ComponentFixture<CitacaoCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CitacaoCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CitacaoCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
