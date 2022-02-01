import { ICliente } from "./cliente.model";
import { IEndereco } from "./endereco.model";
import { IFormaDePagamento } from "./formadepagamento.model";
import { IPedidoProduto } from "./pedidoproduto.model";

export interface IPedido{
    id: number,
    valorItens: number,
    desconto: number,
    valorTotal: number,
    dataPedido: Date,
    formaDePagamentoId: number,
    formaDePagamento: IFormaDePagamento,
    clienteId: number,
    cliente: ICliente,
    detalhesPedido: IPedidoProduto[],
    enderecoId: number,
    endereco: IEndereco
}
