import { Injectable } from '@angular/core';
import { AppCacheSelectOptionDto } from '../api/model/appCacheSelectOptionDto';
import { SlowniaStawekDto } from '../api/model/slowniaStawekDto';

@Injectable({
  providedIn: 'root'
})
export class SlownikiCache {

  waluty: AppCacheSelectOptionDto[] = [];
  stawkiVat: AppCacheSelectOptionDto[] = [];
  jm: AppCacheSelectOptionDto[] = [];

  listaPojazdow: AppCacheSelectOptionDto[] = [];
  listaNaczep: AppCacheSelectOptionDto[] = [];
  listaKierowcow: AppCacheSelectOptionDto[] = [];

  slownik_stawek: SlowniaStawekDto[] = [];
  slownik_kosztow: SlowniaStawekDto[] = [];
}
