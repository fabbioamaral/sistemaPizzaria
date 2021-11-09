import { ICategoria } from "./categoria.model";
import { IPedidoProduto } from "./pedidoproduto.model";

export interface IProduto{
    id: number,
    nome: string,
    preco: number,
    categoriaId: number,
    categoria: ICategoria,
    pedidos: IPedidoProduto[]
}
