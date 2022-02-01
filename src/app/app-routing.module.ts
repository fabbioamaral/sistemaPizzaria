import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';
import { HomePageComponent } from './home-page/home-page.component';
import { PedidosComponent } from './pedidos/pedidos.component';
import { CadastrarProdutoComponent } from './produto/cadastrar-produto/cadastrar-produto.component';
import { EditarProdutoComponent } from './produto/editar-produto/editar-produto.component';
import { ProdutoComponent } from './produto/produto.component';

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'produtos', component: ProdutoComponent },
  { path: 'produtos/cadastrar-produto', component: CadastrarProdutoComponent },
  { path: 'produtos/editar-produto/:id', component: EditarProdutoComponent },
  { path: 'clientes', component: ClientesComponent },
  { path: 'pedidos', component: PedidosComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
