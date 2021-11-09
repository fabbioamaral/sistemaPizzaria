import { ICliente } from "./cliente.model";
import { IPedido } from "./pedido.model";
import { ITaxaDeEntrega } from "./taxadeentrega.model";

export interface IEndereco{
    id: number,
    logradouro: string,
    numero: number,
    cep: string,
    complemento: string,
    bairro: string,
    cidade: string,
    referencia: string,
    taxaDeEntregaId: number,
    taxaDeEntrega: ITaxaDeEntrega,
    clienteId: number,
    cliente: ICliente,
    pedidos: IPedido[]
}