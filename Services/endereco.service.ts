import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IProduto } from 'Models/produto.model';
import { IPedido } from 'Models/pedido.model';
import { IEndereco } from 'Models/endereco.model';

@Injectable({
  providedIn: 'root'
})

export class EnderecoService {

  constructor(private httpClient:HttpClient) { }

  private _url = "http://localhost:44322/enderecos";  
  
  // GET
  getEnderecos(): Observable<IEndereco[]>{
    return this.httpClient.get<IEndereco[]>(this._url);
  }

  // GET by id
  getEndereco(id:string):Observable<IEndereco>{
    const url=`${this._url}/${id}`;
    return this.httpClient.get<IEndereco>(url);
  }

  // POST
  postEndereco(endereco: IEndereco): Observable<IEndereco>{
    return this.httpClient.post<IEndereco>(this._url, endereco);
  }

  // PUT
  putEndereco(id:string,endereco:IEndereco){
    const url=`${this._url}/${id}`;
    return this.httpClient.put(url,endereco);
  }

  // DELETE
  deleteEndereco(id: number){
    const url=`${this._url}/${id}`;
    return this.httpClient.delete(url);
  }

}
