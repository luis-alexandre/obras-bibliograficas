import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CitacaoCreateComponent } from './citacao-create/citacao-create.component'

const routes: Routes = [
  {path: 'create', component: CitacaoCreateComponent},
  {path: '**', component: CitacaoCreateComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
