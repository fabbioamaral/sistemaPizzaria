import { IEndereco } from "./endereco.model";

export interface ITaxaDeEntrega{
    id: number,
    bairro: string,
    preco: number,
    enderecos: IEndereco[]
}