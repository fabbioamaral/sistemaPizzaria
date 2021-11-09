import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientesComponent } from './clientes/clientes.component';
import { ProdutoComponent } from './produto/produto.component';
import { CadastrarProdutoComponent } from './produto/cadastrar-produto/cadastrar-produto.component';
import { EditarProdutoComponent } from './produto/editar-produto/editar-produto.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    ClientesComponent,
    ProdutoComponent,
    CadastrarProdutoComponent,
    EditarProdutoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot([
      {path:'',component:ProdutoComponent},
      {path:'produtos', component:ProdutoComponent},
      {path:'produtos/cadastrar-produto', component:CadastrarProdutoComponent},
      {path: 'produtos/editar-produto/:id', component: EditarProdutoComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
