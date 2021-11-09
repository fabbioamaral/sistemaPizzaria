import { IProduto } from "./produto.model";

export interface ICategoria{
    id: number,
    nome: string,
    produtos: IProduto[]
}
