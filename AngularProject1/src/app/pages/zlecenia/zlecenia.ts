import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ZleceniaService } from '../../api/api/zlecenia.service';
import { VZleceniaSpedNewORM } from '../../api/model/vZleceniaSpedNewORM';
import { CommonModule } from '@angular/common';
import { ChangeDetectorRef } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth';
import { AppCacheSelectOptionDto } from '../../api/model/appCacheSelectOptionDto';
import { Tab, TabService } from '../../services/tab';


@Component({
  selector: 'app-zlecenia',
  standalone: true,
  imports: [FormsModule, CommonModule],
  styleUrl: './zlecenia.css',
  templateUrl: './zlecenia.html',
})
export class Zlecenia
{
  zlecenia: VZleceniaSpedNewORM[] = [];
  selectedZlecenie: VZleceniaSpedNewORM | null = null;


  f_zleceniodawca: string = '';
  f_nrReferencyjny: string = '';
  f_przewoznik: string = '';

  f_nrRej: string = '';
  f_nrZlecenia: string = '';
  f_nrFaktury: string = '';
  f_kierowca: string = '';
  f_miejsceZaladunku: string = '';
  f_miejsceRozladunku: string = '';
  f_idUser: number = 0;
  f_idDzial: number = 0;
  f_idDodatkowyFiltr: number = 0;
  f_status: number = 100;
  f_transport0Spedycja1: number = 0;

  f_filtrDataRodzaj: number = 1;

  listaDzialow: Array<AppCacheSelectOptionDto> =[];
  listaFiltrow: Array<AppCacheSelectOptionDto> = [];
  listaUserow: Array<AppCacheSelectOptionDto> = [];

  f_dataDo: string = this.formatDate(new Date());

  f_dataOd: string = this.formatDate(
    new Date(new Date().setDate(new Date().getDate() - 7))
  );


  private formatDate(date: Date): string {
    return date.toISOString().split('T')[0];
  }




  pageNo: number = 1;
  totalPages: number = 0;


  isModalOpen = false;
  isEditMode = false;


  constructor(private zleceniaService: ZleceniaService,
              private cdr: ChangeDetectorRef,
              private authService: AuthService,
              private router: Router,
              public tabService: TabService,) {
    console.log('ZLECENIA COMPONENT CREATED');

    this.loadAppCache();
    this.loadZlecenia();
  }

  loadAppCache(): void {
    const cache = this.authService.getCurrentAppCache();

    if (!cache)
    {
      return;
    }

    this.listaDzialow = cache.oddzialy ?? [];
    this.listaFiltrow = cache.filtryDodatkowe ?? [];
    this.listaUserow = cache.users ?? [];
  }

  loadZlecenia(): void {

    console.log('LOAD zlecenia - start');

    this.zleceniaService.apiZleceniaGetListaZlecenGet(this.pageNo, this.f_zleceniodawca, this.f_nrReferencyjny, this.f_przewoznik, this.f_nrRej,
                                                      this.f_nrZlecenia, this.f_nrFaktury, this.f_kierowca, this.f_miejsceZaladunku, this.f_miejsceRozladunku,
                                                      this.f_idUser, this.f_idDzial, this.f_idDodatkowyFiltr, this.f_status, this.f_filtrDataRodzaj,
                                                      this.f_dataOd, this.f_dataDo, this.f_transport0Spedycja1 )
      .subscribe({
        next: response => {

          console.log(response);

          this.zlecenia = response.listaZlecen ?? [];

          this.pageNo = response.pageNo ?? 1;
          this.totalPages = response.totalPages ?? 0;

          this.cdr.detectChanges();

   
        },

        error: error => {
          console.error('LOAD USERS - error:', error);
        }
      });
  }

  szukaj(): void {

    this.pageNo = 1;
    this.loadZlecenia();
  }

  previousPage(): void {

    if (this.pageNo <= 1) {
      return;
    }

    this.pageNo--;
    this.loadZlecenia();
  }

  nextPage(): void {

    if (this.pageNo >= this.totalPages) {
      return;
    }

    this.pageNo++;
    this.loadZlecenia();
  }


  selectZlecenie(zlecenie: VZleceniaSpedNewORM): void {
    this.selectedZlecenie = zlecenie;


  }


  addZlecenie(): void {

    this.tabService.openTab({
      id: `editZlecenie`,
      title: `Edycja zlecenia`,
      route: `/app/zlecenia/${0}`
    });
    this.router.navigate([`/app/zlecenia/${0}`]);

  }

  editZlecenie(): void {
    if (!this.selectedZlecenie) {
      return;
    }

    const id = this.selectedZlecenie.iD_ZLECENIA_SPED;
    const numer = this.selectedZlecenie.numeR_PELNY;

    this.tabService.openTab({
      id: `editZlecenie`,
      title: `Edycja zlecenia`,
      route: `/app/zlecenia/${id}`
    });
    this.router.navigate([`/app/zlecenia/${id}`]);

  }


  deleteZlecenie(): void {
    console.log('Create USERS - start');


    if (!this.selectedZlecenie) {
      return;
    }


  }


  closeModal(): void {
    this.isModalOpen = false;
  }

  // =============================================================
  // =========  kolorowanie statusów w tabeli  ===================
  // =============================================================
  getStatusClass(finalized: number | null | undefined): string {
    switch (finalized) {
      case 0:
        return 'status-0';
      case 1:
        return 'status-1';
      case 2:
        return 'status-2';
      case 3:
        return 'status-3'; 
      case 4:
        return 'status-4';
      default:
        return 'status-unknown';
    }
  }

  getStatusText(finalized: number | null | undefined): string {
    switch (finalized) {
      case 0:
        return '●'; // oczekujące
      case 1:
        return '◐'; // w trakcie
      case 2:
        return '✓'; // zakończone
      case 3:
        return '!!'; // uwaga
      case 4:
        return '■'; // zamkniete
      default:
        return '?';
    }
  }

  toDate(value: string | null | undefined): Date | null {
    if (!value) {
      return null;
    }

    return new Date(value);
  }

  // =============================================================
}
