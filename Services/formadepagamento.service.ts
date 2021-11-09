import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IFormaDePagamento } from 'Models/formadepagamento.model';

@Injectable({
  providedIn: 'root'
})

export class FormaDePagamentoService {

  constructor(private httpClient:HttpClient) { }

  private _url = "http://localhost:44322/formasdepagamento";  
  
  // GET
  getFormasDePagamento(): Observable<IFormaDePagamento[]>{
    return this.httpClient.get<IFormaDePagamento[]>(this._url);
  }

}
