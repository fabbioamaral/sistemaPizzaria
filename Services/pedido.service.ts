import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IPedido } from 'Models/pedido.model';

@Injectable({
  providedIn: 'root'
})

export class PedidoService {

  constructor(private httpClient:HttpClient) { }

  private _url = "http://localhost:44322/pedidos";  
  
  // GET
  getPedidos(): Observable<IPedido[]>{
    return this.httpClient.get<IPedido[]>(this._url);
  }

  // GET by id
  getPedido(id:string):Observable<IPedido>{
    const url=`${this._url}/${id}`;
    return this.httpClient.get<IPedido>(url);
  }

  // POST
  postPedido(pedido: IPedido): Observable<IPedido>{
    return this.httpClient.post<IPedido>(this._url, pedido);
  }

  // PUT
  putPedido(id:string,pedido:IPedido){
    const url=`${this._url}/${id}`;
    return this.httpClient.put(url,pedido);
  }

  // DELETE
  deletePedido(id: number){
    const url=`${this._url}/${id}`;
    return this.httpClient.delete(url);
  }

}
