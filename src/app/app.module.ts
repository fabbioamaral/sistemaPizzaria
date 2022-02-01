import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientesComponent } from './clientes/clientes.component';
import { ProdutoComponent } from './produto/produto.component';
import { CadastrarProdutoComponent } from './produto/cadastrar-produto/cadastrar-produto.component';
import { EditarProdutoComponent } from './produto/editar-produto/editar-produto.component';
import { RouterModule } from '@angular/router';
import { HomePageComponent } from './home-page/home-page.component';
import { PedidosComponent } from './pedidos/pedidos.component';

@NgModule({
  declarations: [
    AppComponent,
    ClientesComponent,
    ProdutoComponent,
    CadastrarProdutoComponent,
    EditarProdutoComponent,
    HomePageComponent,
    PedidosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
