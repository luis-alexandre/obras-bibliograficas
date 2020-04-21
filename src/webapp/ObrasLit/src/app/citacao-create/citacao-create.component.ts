import { Component, OnInit, ComponentFactoryResolver } from '@angular/core';
import { Observable } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

import { CitacaoCreateService } from '../citacao-create.service';
import { CitacaoRequest } from '../models/citacaoRequest';
import { CitacaoResponse, Citacao } from '../models/citacaoResponse';
import { stringify } from 'querystring';

@Component({
  selector: 'app-citacao-create',
  templateUrl: './citacao-create.component.html',
  styleUrls: ['./citacao-create.component.css']
})
export class CitacaoCreateComponent implements OnInit {

  citacaoResponse$: Observable<CitacaoResponse>;

  form: FormGroup;
  formAutores: string;
  errorMessage: any;

  constructor(private citacaoCreateService: CitacaoCreateService,
              private formBuilder: FormBuilder) { 

  }

  ngOnInit(): void {
    
    this.form = this.formBuilder.group({
      Autores: ['', [Validators.required]]
    })
  }

  save(){
    if(!this.form.valid){
      return;
    }

    let citacaoRequest: CitacaoRequest = {
      autores: String(this.form.get("Autores").value).split(/\r?\n/),
      numeroAutores: String(this.form.get("Autores").value).split(/\r?\n/).length
    };

    try {
      this.citacaoResponse$ = this.citacaoCreateService.create(citacaoRequest);
    } catch (error) {
      
      console.log(error);
      throw error;  
    }
    
  }

}
