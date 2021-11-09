import { IPedido,  } from "./pedido.model";
import { IProduto } from "./produto.model";

export interface IPedidoProduto{
    id: number,
    produtoId: number,
    produto: IProduto,
    descontoItem: number,
    pedidoId: number,
    pedido: IPedido
}
