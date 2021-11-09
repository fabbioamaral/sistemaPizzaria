import { IEndereco } from "./endereco.model";

export interface ICliente{
    id: number,
    nome: string,
    telefone: string, 
    observacaoInterna: string,
    dataCriacao: Date,
    dataUltimaAtualizacao: Date,
    enderecos:IEndereco[]
}