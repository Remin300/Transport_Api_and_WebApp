import { Component, ChangeDetectorRef, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { ZleceniaService } from '../../../../api/api/zlecenia.service';
import { UpdateStawkaKosztowaDto } from '../../../../api/model/updateStawkaKosztowaDto';
import { NotificationService } from '../../../../services/notification.service';

import { SlownikiCache } from '../../../../services/slowniki-cache';
import { AppCacheSelectOptionDto } from '../../../../api/model/appCacheSelectOptionDto';
import { SlowniaStawekDto } from '../../../../api/model/slowniaStawekDto';

@Component({
  selector: 'app-stawka-koszt-edit',
  standalone: true,
  imports: [FormsModule, CommonModule],
  styleUrl: './stawka-koszt-edit.css',
  templateUrl: './stawka-koszt-edit.html',
})
export class StawkaKosztEdit {
  constructor(private zleceniaService: ZleceniaService,
    private cdr: ChangeDetectorRef,
    private notificationService: NotificationService,
    private slownikiCache: SlownikiCache) {
  }
  @Input() idTowaru!: number;
  @Input() idStawka!: number;

  isEditMode = false;
  title: string | null = null;

  _stawka: UpdateStawkaKosztowaDto | null = null;



  waluty: AppCacheSelectOptionDto[] = [];
  stawkiVat: AppCacheSelectOptionDto[] = [];
  jm: AppCacheSelectOptionDto[] = [];


  slownik_stawek: SlowniaStawekDto[] = [];
  slownik_kosztow: SlowniaStawekDto[] = [];


  ngOnInit(): void {

    this.waluty = this.slownikiCache.waluty ?? [];
    this.jm = this.slownikiCache.jm ?? [];
    this.slownik_stawek = this.slownikiCache.slownik_kosztow ?? [];
    this.stawkiVat = this.slownikiCache.stawkiVat ?? [];



    if (this.idStawka == 0) {
      // Tryb dodawania
      this.isEditMode = false;

      this.title = "Nowa Stawka";
      this._stawka = {};
      this._stawka.idTowaru = this.idTowaru;

      this.cdr.detectChanges();

    } else {
      // Tryb edycji
      this.isEditMode = true;

      this.title = "Edycja Stawki";

      this.load_Dane();

    }

  }


  zapisz(): void {

    if (this.isEditMode == true) {
      this.Update();

    }
    else {
      this.Create();
    }

  }


  Create() {
    if (!this._stawka) {
      return;
    }


    this.zleceniaService
      .apiZleceniaCreateStawkaKosztowaPost(this._stawka)
      .subscribe({
        next: () => {


          this.notificationService.success(
            'Stawka została pomyślnie stworzona.'
          );
        },


        error: error => {

          console.error(
            'CREATE STAWKA KOSZT - error:',
            error
          );
          const message =
            error.error?.message ??
            'Nie udało się stworzyć stawki.';

          this.notificationService.error(message);
        }
      });
  }
  Update() {
    if (!this._stawka) {
      return;
    }


    this.zleceniaService
      .apiZleceniaUpdatetStawkaKosztowaPost(this._stawka)
      .subscribe({
        next: () => {


          this.notificationService.success(
            'Stawka została pomyślnie zaktualizowana.'
          );
        },


        error: error => {

          console.error(
            'UPDATE STAWKA KOSZT - error:',
            error
          );
          const message =
            error.error?.message ??
            'Nie udało się zaktualizować stawki.';

          this.notificationService.error(message);
        }
      });
  }

  load_Dane(): void {


    if (this.idStawka == null) {
      return;
    }

    this.zleceniaService.apiZleceniaGetStawkaKosztByIdIdGet(this.idStawka)
      .subscribe({
        next: response => {

          console.log(response);

          this._stawka = response ?? [];



          this.cdr.detectChanges();

        },

        error: error => {
          console.error('LOAD STAWKA KOSZT - error:', error);
        }
      });
  }


}
