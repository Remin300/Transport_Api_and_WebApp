import { Component, ChangeDetectorRef, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { ZleceniaService } from '../../../../api/api/zlecenia.service';
import { UpdateTowarDto } from '../../../../api/model/updateTowarDto';
import { NotificationService } from '../../../../services/notification.service';

@Component({
  selector: 'app-towar-edit',
  standalone: true,
  imports: [FormsModule, CommonModule],
  styleUrl: './towar-edit.css',
  templateUrl: './towar-edit.html',
})
export class TowarEdit {
  constructor(private zleceniaService: ZleceniaService,
    private cdr: ChangeDetectorRef,
    private notificationService: NotificationService) {
  }

  @Input() idZlecenia!: number;
  @Input() idZTowar!: number;

  isEditMode = false;
  title: string | null = null;

  _towar: UpdateTowarDto | null = null;

  ngOnInit(): void {


    if (this.idZTowar == 0) {
      // Tryb dodawania
      this.isEditMode = false;

      this.title = "Nowy Towar";
      this._towar = {};
      this._towar.idZlecenia = this.idZlecenia;

      this.cdr.detectChanges();

    } else {
      // Tryb edycji
      this.isEditMode = true;

      this.title = "Edycja Towaru";

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
    if (!this._towar) {
      return;
    }


    this.zleceniaService
      .apiZleceniaCreateTowarPost(this._towar)
      .subscribe({
        next: () => {


          this.notificationService.success(
            'Towar został pomyślnie stworzony.'
          );
        },


        error: error => {

          console.error(
            'CREATE TOWAR - error:',
            error
          );
          const message =
            error.error?.message ??
            'Nie udało się stworzyć towaru.';

          this.notificationService.error(message);
        }
      });
  }
  Update() {
    if (!this._towar) {
      return;
    }


    this.zleceniaService
      .apiZleceniaUpdatetTowarPost(this._towar)
      .subscribe({
        next: () => {


          this.notificationService.success(
            'Towar został pomyślnie zaktualizowany.'
          );
        },


        error: error => {

          console.error(
            'UPDATE TOWAR - error:',
            error
          );
          const message =
            error.error?.message ??
            'Nie udało się zaktualizować towaru.';

          this.notificationService.error(message);
        }
      });
  }

  load_Dane(): void {


    if (this.idZlecenia == null) {
      return;
    }

    this.zleceniaService.apiZleceniaGetTowarByIdIdGet(this.idZTowar)
      .subscribe({
        next: response => {

          console.log(response);

          this._towar = response ?? [];

          if (this._towar.dataRozlad) {
            // niezbedne, aby wyświetlić tylko datę bez czasu w formacie yyyy-MM-dd. Inaczej formatka html nie wyswietla danych
            this._towar.dataRozlad =
              this._towar.dataRozlad.substring(0, 10);
          }
          if (this._towar.dataZalad) {
            // niezbedne, aby wyświetlić tylko datę bez czasu w formacie yyyy-MM-dd. Inaczej formatka html nie wyswietla danych
            this._towar.dataZalad =
              this._towar.dataZalad.substring(0, 10);


          }


          this.cdr.detectChanges();

        },

        error: error => {
          console.error('LOAD USERS - error:', error);
        }
      });
  }


}
