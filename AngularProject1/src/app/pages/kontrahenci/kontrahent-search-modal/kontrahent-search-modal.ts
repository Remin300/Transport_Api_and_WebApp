import { Component, Output, EventEmitter } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { KontrahentDto } from '../../../api/model/kontrahentDto';
import { KontrahentService } from '../../../api/api/kontrahent.service';
import { ChangeDetectorRef } from '@angular/core';



@Component({
  selector: 'app-kontrahent-search-modal',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './kontrahent-search-modal.html',
  styleUrl: './kontrahent-search-modal.css'
})
export class KontrahentSearchModal {

  kontrahenci: KontrahentDto[] = [];
  selectedObj: KontrahentDto | null = null;


  f_nazwa: string = '';
  f_nip: string = '';


  pageNo: number = 1;
  totalPages: number = 0;

  fraza = '';

  constructor(private kontrahentService: KontrahentService, private cdr: ChangeDetectorRef) {
    console.log('USERS COMPONENT CREATED');

  
  }


  @Output() wybranoKontrahenta = new EventEmitter<KontrahentDto>();

  zatwierdzWybor(): void {
    if (this.selectedObj) {
      this.wybranoKontrahenta.emit(this.selectedObj);
    }
  }

  loadList(): void {

    console.log('LOAD USERS - start');

    this.kontrahentService.apiKontrahentGetKontrahentListGet(this.pageNo, this.f_nip, this.f_nazwa, true)
      .subscribe({
        next: response => {

          this.kontrahenci = response.kontrahenci ?? [];

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
    this.loadList();
  }

  previousPage(): void {

    if (this.pageNo <= 1) {
      return;
    }

    this.pageNo--;
    this.loadList();
  }

  nextPage(): void {

    if (this.pageNo >= this.totalPages) {
      return;
    }

    this.pageNo++;
    this.loadList();
  }

  selectObj(selectedObj: KontrahentDto): void {
    this.selectedObj = selectedObj;

  }

}
