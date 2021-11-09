import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IProduto } from 'Models/produto.model';

@Injectable({
  providedIn: 'root'
})

export class ProdutoService {

  constructor(private httpClient:HttpClient) { }

  private _url = "http://localhost:44322/produtos";  
  
  // GET
  getProdutos(): Observable<IProduto[]>{
    return this.httpClient.get<IProduto[]>(this._url);
  }

  // GET by id
  getProduto(id:string):Observable<IProduto>{
    const url=`${this._url}/${id}`;
    return this.httpClient.get<IProduto>(url);
  }

  // POST
  postProduto(produto: IProduto): Observable<IProduto>{
    return this.httpClient.post<IProduto>(this._url, produto);
  }

  // PUT
  putProduto(id:string,produto:IProduto){
    const url=`${this._url}/${id}`;
    return this.httpClient.put(url,produto);
  }

  // DELETE
  deleteProduto(id: number){
    const url=`${this._url}/${id}`;
    return this.httpClient.delete(url);
  }

}
