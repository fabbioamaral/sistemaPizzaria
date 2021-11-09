import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { ICategoria } from 'Models/categoria.model';

@Injectable({
  providedIn: 'root'
})

export class CategoriaService {

  constructor(private httpClient:HttpClient) { }

  private _url = "http://localhost:44322/categorias";  
  
  // GET
  getCategorias(): Observable<ICategoria[]>{
    return this.httpClient.get<ICategoria[]>(this._url);
  }

  // GET by id
  getCategoria(id:string):Observable<ICategoria>{
    const url=`${this._url}/${id}`;
    return this.httpClient.get<ICategoria>(url);
  }

}
