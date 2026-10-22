import { Component ,Input } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ChangeDetectorRef } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ZleceniaService } from '../../../../api/api/zlecenia.service';
import { LadunekZbiorowyResponseDto } from '../../../../api/model/ladunekZbiorowyResponseDto';
import { TowaryIStawkiDto } from '../../../../api/model/towaryIStawkiDto';
import { StawkaWlasnaDto } from '../../../../api/model/stawkaWlasnaDto';
import { StawkaKosztowaDto } from '../../../../api/model/stawkaKosztowaDto';
import { TowarEdit } from '../towar-edit/towar-edit';
import { StawkaWlasEdit } from '../stawka-wlas-edit/stawka-wlas-edit';
import { StawkaKosztEdit } from '../stawka-koszt-edit/stawka-koszt-edit';

@Component({
  selector: 'app-ladunek',
  standalone: true,
  imports: [FormsModule, CommonModule, TowarEdit, StawkaWlasEdit, StawkaKosztEdit],
  templateUrl: './ladunek.html',
  styleUrl: './ladunek.css'
})
export class Ladunek {

  @Input() idZlecenia!: number;


  wybranaPozycja: TowaryIStawkiDto | null = null;

  wybranaStawkaWlasna: StawkaWlasnaDto | null = null;
  wybranaStawkaKoszt: StawkaKosztowaDto | null = null;

  listaStawekWlasnych: StawkaWlasnaDto[] = [];
  listaStawekKosztowych: StawkaKosztowaDto[] = [];

  lista_ladunkow: LadunekZbiorowyResponseDto | null = null;
  Towar_i_Stawiki: TowaryIStawkiDto[] = [];
  constructor(private zleceniaService: ZleceniaService,
              private cdr: ChangeDetectorRef)
  {
  

  }
  wybierzStawkeWlasna(stawka: StawkaWlasnaDto): void {

    this.wybranaStawkaWlasna = stawka;


    this.cdr.detectChanges();
  }
  wybierzStawkeKoszt(stawka: StawkaKosztowaDto): void {

    this.wybranaStawkaKoszt = stawka;


    this.cdr.detectChanges();
  }

  
  wybierzPozycje(pozycja: TowaryIStawkiDto): void {

    this.wybranaPozycja = pozycja;

    this.listaStawekWlasnych = pozycja.stawki_wlasne ?? [];
    this.listaStawekKosztowych = pozycja.stawki_kosztowe ?? [];

    this.cdr.detectChanges();
  }

  ngOnInit(): void {
    this.load_Dane();
  }

  load_Dane(): void {


    if (this.idZlecenia == null) {
      return;
    }

    this.zleceniaService.apiZleceniaGetLadunekZbiorowyIdGet(this.idZlecenia)
      .subscribe({
        next: response => {

          console.log(response);

          this.lista_ladunkow = response;

          this.Towar_i_Stawiki = response.ladunek ?? [];


          if (this.Towar_i_Stawiki != null)
          {
            this.wybierzPozycje(this.Towar_i_Stawiki[0]);
          }

          this.cdr.detectChanges();

        },

        error: error => {
          console.error('LOAD USERS - error:', error);
        }
      });
  }

 


  pokazModalTowar = false;
  towarId: number | null = null;


  edytuj_towar(): void {
    this.towarId = this.wybranaPozycja?.towar?.idTowaru ?? 0;
    this.pokazModalTowar = true;
  }
  dodaj_towar(): void {
    this.towarId = 0;
    this.pokazModalTowar = true;
  }

  zamknij_Modal_towar(): void {
    this.pokazModalTowar = false;

  // po ewentualnych zmianach w ładunku zbiorowym należy przeładować całe zlecenie
    this.load_Dane();
  }





  pokazModalStawkaWlasna = false;
  stawkaWlasnaId: number | null = null;

  edytuj_StawkaWlasna(): void {
    this.towarId = this.wybranaPozycja?.towar?.idTowaru ?? 0;
    this.stawkaWlasnaId = this.wybranaStawkaWlasna?.idTowaryStawki ?? 0;
    this.pokazModalStawkaWlasna = true;
  }
  dodaj_StawkaWlasna(): void {
    this.towarId = this.wybranaPozycja?.towar?.idTowaru ?? 0;
    this.stawkaWlasnaId = 0;
    this.pokazModalStawkaWlasna = true;
  }

  zamknij_Modal_StawkaWlasna(): void {
    this.pokazModalStawkaWlasna = false;

    // po ewentualnych zmianach w ładunku zbiorowym należy przeładować całe zlecenie
    this.load_Dane();
  }





  pokazModalStawkaKoszt = false;
  stawkaKosztId: number | null = null;

  edytuj_StawkaKoszt(): void {
    this.towarId = this.wybranaPozycja?.towar?.idTowaru ?? 0;
    this.stawkaKosztId = this.wybranaStawkaKoszt?.idTowaryKoszty ?? 0;
    this.pokazModalStawkaKoszt = true;
  }
  dodaj_StawkaKoszt(): void {
    this.towarId = this.wybranaPozycja?.towar?.idTowaru ?? 0;
    this.stawkaKosztId = 0;
    this.pokazModalStawkaKoszt = true;
  }

  zamknij_Modal_StawkaKoszt(): void {
    this.pokazModalStawkaKoszt = false;

    // po ewentualnych zmianach w ładunku zbiorowym należy przeładować całe zlecenie
    this.load_Dane();
  }

}
