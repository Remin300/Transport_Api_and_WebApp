import { Component, OnInit } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ZleceniaService } from '../../api/api/zlecenia.service';
import { UpdateZlecenieDto } from '../../api/model/updateZlecenieDto';
import { AppCacheSelectOptionDto } from '../../api/model/appCacheSelectOptionDto';
import { SlowniaStawekDto } from '../../api/model/slowniaStawekDto';
import { NotificationService } from '../../services/notification.service';
import { TabService } from '../../services/tab';
import { RouteReuseService } from '../../services/route-reuse';
import { Router, RouterOutlet } from '@angular/router';

import { AuthService } from '../../services/auth';
import { SlownikiCache } from '../../services/slowniki-cache';
import { FormsModule } from '@angular/forms';

import { KontrahentSearchModal } from '../kontrahenci/kontrahent-search-modal/kontrahent-search-modal';
import { KontrahentDto } from '../../api/model/kontrahentDto';
import { Ladunek } from '../zlecenia/ladunek/ladunek/ladunek';

@Component({
  selector: 'app-zlecenie-edit',
  standalone: true,
  imports: [
    FormsModule,
    KontrahentSearchModal,
    Ladunek
  ],
  templateUrl: './zlecenie-edit.html',
  styleUrl: './zlecenie-edit.css'
})
export class ZlecenieEdit implements OnInit {

  isEditMode = false;
  title: string | null = null;

  zlecenieId: number | null = null;

  zlecenie: UpdateZlecenieDto = {};

  waluty: AppCacheSelectOptionDto[] = [];
  stawkiVat: AppCacheSelectOptionDto[] = [];
  jm: AppCacheSelectOptionDto[] = [];
  listaPojazdow: AppCacheSelectOptionDto[] = [];
  listaNaczep: AppCacheSelectOptionDto[] = [];
  listaKierowcow: AppCacheSelectOptionDto[] = [];

  slownik_stawek: SlowniaStawekDto[] = [];
  slownik_kosztow: SlowniaStawekDto[] = [];

  listaDzialow: AppCacheSelectOptionDto[] = [];
  listaFiltrow: AppCacheSelectOptionDto[] = [];

  isLoading = true;


  modal_1_2: number | null = null;


  constructor(
    private route: ActivatedRoute,
    private zleceniaService: ZleceniaService,
    private authService: AuthService,
    private cdr: ChangeDetectorRef,
    private notificationService: NotificationService,
    public tabService: TabService,
    private routeReuseService: RouteReuseService,
    private router: Router,
    private slownikiCache: SlownikiCache
  ) { }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');

    const appCache = this.authService.getCurrentAppCache();

    this.listaDzialow = appCache?.oddzialy ?? [];
    this.listaFiltrow = appCache?.filtryDodatkowe ?? [];

    const id_int = Number(id)

    if (id_int == 0) {
      // Tryb dodawania
      this.isEditMode = false;
      this.zlecenieId = null;

      this.title = "Nowe Zlecenie";

      this.initNoweZlecenie();



    } else {
      // Tryb edycji
      this.zlecenieId = Number(id);
      this.isEditMode = true;

      this.title = "Edycja Zlecenia";

      this.loadZlecenie();

    }

 

  }
  saveSlowniki() {
    this.slownikiCache.waluty = this.waluty ?? [];
    this.slownikiCache.stawkiVat = this.stawkiVat ?? [];
    this.slownikiCache.jm = this.jm ?? [];

    this.slownikiCache.listaPojazdow = this.listaPojazdow ?? [];
    this.slownikiCache.listaNaczep = this.listaNaczep ?? [];
    this.slownikiCache.listaKierowcow = this.listaKierowcow ?? [];

    this.slownikiCache.slownik_stawek = this.slownik_stawek ?? [];
    this.slownikiCache.slownik_kosztow = this.slownik_kosztow ?? [];
  }

  private initNoweZlecenie(): void {

    // TODO
    // pobrac slowniki potrzebne do pelnej edycji zlecenia

    // Przykładowe wartości początkowe:
    this.zlecenie = {
      dataRozladunku: new Date().toLocaleDateString('en-CA'),
      dataZlecenia: new Date().toLocaleDateString('en-CA'),
      dataZaladunku: new Date().toLocaleDateString('en-CA')
    };


    this.zleceniaService
      .apiZleceniaGetDataForCreateGet()
      .subscribe({
        next: response => {


          this.waluty = response.waluty ?? [];
          this.stawkiVat = response.stawkiVat ?? [];
          this.jm = response.jm ?? [];
          this.listaPojazdow = response.pojazdy ?? [];
          this.listaNaczep = response.naczepy ?? [];
          this.listaKierowcow = response.kierowcy ?? [];

          this.slownik_stawek = response.slownikStawkiWlasne ?? [];
          this.slownik_kosztow = response.slownikStakiPrzewoz ?? [];

          this.isLoading = false;

          this.saveSlowniki();

        },

        error: error => {

          console.error(
            'GET ZLECENIE FOR EDIT - error:',
            error
          );

          this.isLoading = false;
        }
      });



    this.isLoading = false;
    this.cdr.detectChanges();
  }

  private loadZlecenie(): void {

    if (!this.zlecenieId) {
      return;
    }

    console.log(
      'Ładowanie zlecenia:',
      this.zlecenieId
    );

    this.zleceniaService
      .apiZleceniaGetZlecenieForEditByIdIdGet(this.zlecenieId)
      .subscribe({
        next: response => {

          this.zlecenie = response.zlecenie ?? {};

          if (this.zlecenie.dataZlecenia) {
            // niezbedne, aby wyświetlić tylko datę bez czasu w formacie yyyy-MM-dd. Inaczej formatka html nie wyswietla danych
            this.zlecenie.dataZlecenia =
              this.zlecenie.dataZlecenia.substring(0, 10);

            this.zlecenie.dataZaladunku =
              this.zlecenie.dataZaladunku?.substring(0, 10);

            this.zlecenie.dataRozladunku =
              this.zlecenie.dataRozladunku?.substring(0, 10);
          }

          this.waluty = response.waluty ?? [];
          this.stawkiVat = response.stawkiVat ?? [];
          this.jm = response.jm ?? [];
          this.listaPojazdow = response.pojazdy ?? [];
          this.listaNaczep = response.naczepy ?? [];
          this.listaKierowcow = response.kierowcy ?? [];

          this.slownik_stawek = response.slownikStawkiWlasne ?? [];
          this.slownik_kosztow = response.slownikStakiPrzewoz ?? [];

          this.isLoading = false;
          this.saveSlowniki();
          this.cdr.detectChanges();

        },

        error: error => {

          console.error(
            'GET ZLECENIE FOR EDIT - error:',
            error
          );

          this.isLoading = false;
        }
      });
  }

  private zapisz(): void {
    if (this.isEditMode == true) {
      this.Update();

    }
    else {
      this.Create();
    }
  }

  private Create(): void {

    this.zleceniaService
      .apiZleceniaCreateZleceniePost(this.zlecenie)
      .subscribe({
        next: () => {


          this.notificationService.success(
            'Zlecenie zostało pomyślnie utworzone.'
          );

          this.zamknijTab();

        },


        error: error => {

          console.error(
            'CREATE ZLECENIE - error:',
            error
          );
          const message =
            error.error?.message ??
            'Nie udało się stworzyć zlecenia.';

          this.notificationService.error(message);
        }
      });
  }

  private Update(): void {
    if (!this.zlecenieId) {
      return;
    }


    this.zleceniaService
      .apiZleceniaUpdateZlecenieIdPost(this.zlecenieId, this.zlecenie)
      .subscribe({
        next: () => {


          this.notificationService.success(
            'Zlecenie zostało pomyślnie zaktualizowane.'
          );

          this.zamknijTab();

        },


        error: error => {

          console.error(
            'UPDATE ZLECENIE - error:',
            error
          );
          const message =
            error.error?.message ??
            'Nie udało się zaktualizować zlecenia.';

          this.notificationService.error(message);
        }
      });
  }

  private closeTab(id: string): void {
    const tab = this.tabService.tabs.find(x => x.id === id);
    if (!tab) return;

    const wasActive = this.tabService.activeTabId === id;

    if (wasActive) {
      this.routeReuseService.closeRoute(tab.route);
    } else {
      this.routeReuseService.clearRoute(tab.route);
    }

    this.tabService.closeTab(id);

    // Jeśli zamykana zakładka nie była aktywna,
    // nie trzeba zmieniać bieżącej trasy.
    if (!wasActive) {
      return;
    }

    // Przejdź do kolejnej aktywnej zakładki.
    const activeTab = this.tabService.tabs.find(
      x => x.id === this.tabService.activeTabId
    );

    if (activeTab) {
      this.router.navigate([activeTab.route]);
    } else {
      // Nie ma już żadnych otwartych zakładek.
      this.router.navigate(['/app']);
    }
  }

  private zamknijTab(): void {
    this.closeTab("editZlecenie");
  }


  pokazModalKontrahentow = false;

  otworzWyszukiwarkeKontrahentow(): void {
    this.pokazModalKontrahentow = true;

    this.modal_1_2 = 1;
  }
  otworzWyszukiwarkeKontrahentow2(): void {
    this.pokazModalKontrahentow = true;

    this.modal_1_2 = 2;
  }

  zamknijWyszukiwarkeKontrahentow(): void {
    this.pokazModalKontrahentow = false;
  }


  obsluzWyborKontrahenta(kontrahent: KontrahentDto): void {
    if (this.modal_1_2 == 1) {
      this.zlecenie.idZleceniodawcy = kontrahent.id;
      this.zlecenie.zleceniodawcaNazwa = kontrahent.nazwa;
    }
    if (this.modal_1_2 == 2) {
      this.zlecenie.idWykonawcy = kontrahent.id;
      this.zlecenie.wykonawcaNazwa = kontrahent.nazwa;

    }


    // Zamknij modal
    this.pokazModalKontrahentow = false;
  }


  pokazModalLadunek = false;

  otworz_Modal_Ladunek(): void {
    this.pokazModalLadunek = true;
  }

  zamknij_Modal_Ladunek(): void {
    this.pokazModalLadunek = false;

    // po ewentualnych zmianach w ładunku zbiorowym należy przeładować całe zlecenie
    this.loadZlecenie();
  }

}
