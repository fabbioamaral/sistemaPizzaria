import { IPedido } from "./pedido.model";

export interface IFormaDePagamento{
    id: number,
    nome: string,
    pedidos: IPedido[]
}