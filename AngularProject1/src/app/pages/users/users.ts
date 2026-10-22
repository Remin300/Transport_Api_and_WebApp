import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { UsersService } from '../../api/api/users.service';
import { UserDto } from '../../api/model/userDto';
import { CommonModule } from '@angular/common';
import { ChangeDetectorRef } from '@angular/core';
import { UpdateUserAllInfoDTO } from '../../api/model/updateUserAllInfoDTO';
import { CreateUserDto } from '../../api/model/createUserDto';
import { AppCacheSelectOptionDto } from '../../api/model/appCacheSelectOptionDto';
import { NotificationService } from '../../services/notification.service';

@Component({
  selector: 'app-users',
  standalone: true,
  imports: [FormsModule, CommonModule],
  styleUrl: './users.css',
  templateUrl: './users.html',
})
export class Users {

  users: UserDto[] = [];
  selectedUser: UserDto | null = null;


  f_login: string = '';
  f_imie: string = '';
  f_nazwisko: string = '';

  pageNo: number = 1;
  totalPages: number = 0;


  isUserModalOpen = false;
  isEditMode = false;

  userForm: UpdateUserAllInfoDTO = {};
  listaFiltrow: Array<AppCacheSelectOptionDto> = [];
  listaDzialow: Array<AppCacheSelectOptionDto> = [];
  selectedDzialIds: number[] = [];
  selectedFiltrIds: number[] = [];
  listaIdOddzialy?: Array<number> | null;
  listaIdDodatkoweFiltry?: Array<number> | null;
  constructor(private usersService: UsersService, private cdr: ChangeDetectorRef, private notificationService: NotificationService)
  {
    console.log('USERS COMPONENT CREATED');

    this.loadUsers();
  }

  loadUsers(): void {

    console.log('LOAD USERS - start');

    this.usersService.apiUsersGetUserListGet(this.pageNo, this.f_login, this.f_imie, this.f_nazwisko)
      .subscribe({
        next: response => {

          this.users = response.userList ?? [];

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
    this.loadUsers();
  }

  previousPage(): void {

    if (this.pageNo <= 1) {
      return;
    }

    this.pageNo--;
    this.loadUsers();
  }

  nextPage(): void {

    if (this.pageNo >= this.totalPages) {
      return;
    }

    this.pageNo++;
    this.loadUsers();
  }


  selectUser(user: UserDto): void {
    this.selectedUser = user;

    console.log('Wybrany użytkownik:', this.selectedUser);
  }


  addUser(): void {
    this.isEditMode = false;

    console.log('ADD USER');


    this.userForm = {
      login: '',
      imie: '',
      nazwisko: '',
      adres: '',
      miasto: ''
    };

    this.isUserModalOpen = true;
  }


  editUser(): void
  {

    if (!this.selectedUser?.iD_USER) {
      return;
    }
     this.isEditMode = true;

    this.usersService.apiUsersGetUserToEditIdGet(this.selectedUser.iD_USER)
      .subscribe({
    next: response => {
          this.userForm = {
            login: response.user?.login ?? '',
            pass: '',
            imie: response.user?.imie ?? '',
            nazwisko: response.user?.nazwisko ?? '',
            iD_GRUPY: response.user?.iD_GRUPY ?? null,
            idgrupa: response.user?.idgrupa ?? null,
            visible: response.user?.visible ?? null,
            adres: response.user?.adres ?? '',
            kod: response.user?.kod ?? '',
            miasto: response.user?.miasto ?? '',
            lock: response.user?.lock ?? null,
            kseF_TOKEN: response.user?.kseF_TOKEN ?? '',
            iD_ROLA: response.user?.iD_ROLA ?? null,
            idrejestr: response.user?.idrejestr ?? null,
            warunek: response.user?.warunek ?? '',
            passodkod: response.user?.passodkod ?? '',
            grupa: response.user?.grupa ?? '',

             // zapisane uprawnienia użytkownika
           listaIdOddzialy: response.user?.listaIdOddzialy ?? [],
            listaIdDodatkoweFiltry: response.user?.listaIdDodatkoweFiltry ?? []
          };

          // Checkboxy
          this.selectedDzialIds =
            response.user?.listaIdOddzialy ?? [];

          this.selectedFiltrIds =
            response.user?.listaIdDodatkoweFiltry ?? [];

          this.listaFiltrow = response.dzialy ?? [];
          this.listaDzialow = response.filtry ?? [];

          this.isUserModalOpen = true;

          this.cdr.detectChanges();
    },

    error: error => {
      console.error('GET USER DETAILS - error:', error);
    }
  });
  }

  toggleDzial(id: number): void {
    const index = this.selectedDzialIds.indexOf(id);

    if (index >= 0) {
      this.selectedDzialIds.splice(index, 1);
    } else {
      this.selectedDzialIds.push(id);
    }
  }

  toggleFiltr(id: number): void {
    const index = this.selectedFiltrIds.indexOf(id);

    if (index >= 0) {
      this.selectedFiltrIds.splice(index, 1);
    } else {
      this.selectedFiltrIds.push(id);
    }
  }

  saveUser(): void
  {
    if (!this.isEditMode)
    {
      this.createUser();
    }
    else
    {
      this.updateUser();
    }

 
  }

  createUser(): void
  {
    console.log('Create USERS - start');

    const request: CreateUserDto = {
      ...this.userForm,
      listaIdOddzialy: this.selectedDzialIds,
      listaIdDodatkoweFiltry: this.selectedFiltrIds
    };


    this.usersService.apiUsersCreateUserPost(
      request
    )
      .subscribe({
        next: () => {
          console.log('USER CREATED');

          this.notificationService.success(
            'Użytkownik został pomyślnie utworzony.'
          );

          // Zamykamy modal TYLKO po poprawnym zapisie
          this.isUserModalOpen = false;

          // Czyścimy formularz dopiero po sukcesie
          this.userForm = {};
          this.selectedDzialIds = [];
          this.selectedFiltrIds = [];

          // Odświeżamy listę
          this.loadUsers();


        },

        error: error =>
        {
          console.error('Create USERS - error:', error);

          const message =
            error.error?.message ??
            'Nie udało się utworzyć użytkownika.';

          this.notificationService.error(message);
        }
      });
  }

  updateUser(): void {
    console.log('Update USERS - start');

    if (!this.selectedUser) {
      return;
    }

    const request: UpdateUserAllInfoDTO = {
      ...this.userForm,
      listaIdOddzialy: this.selectedDzialIds,
      listaIdDodatkoweFiltry: this.selectedFiltrIds
    };


    this.usersService.apiUsersUpdateUserIdPost(
      this.selectedUser.iD_USER ?? 0,
      request
    )
      .subscribe({
        next: () => {
          console.log('USER UPDATED');

          this.notificationService.success(
            'Użytkownik został pomyślnie zaktualizowany.'
          );


          // Zamykamy modal TYLKO po poprawnym zapisie
          this.isUserModalOpen = false;

          // Czyścimy formularz dopiero po sukcesie
          this.userForm = {};
          this.selectedDzialIds = [];
          this.selectedFiltrIds = [];

          // Odświeżamy listę
          this.loadUsers();


        },



        error: error => {
          console.error('Update USERS - error:', error);

          const message =
            error.error?.message ??
            'Nie udało się zaktualizować użytkownika.';

          this.notificationService.error(message);
        }
      });
  }

  deleteUser(): void {
    console.log('Create USERS - start');


    if (!this.selectedUser)
    {
      return;
    }
    const confirmed = confirm(
      `Czy na pewno chcesz usunąć użytkownika "${this.selectedUser.login}"?`
    );

    if (!confirmed) {
      return;
    }

    this.usersService.apiUsersDeleteUserIdDelete(
      this.selectedUser.iD_USER ?? 0
    )
      .subscribe({
        next: () => {
          console.log('USER DELETED');

          this.notificationService.success(
            'Użytkownik został pomyślnie usunięty.'
          );


          // Zamykamy modal TYLKO po poprawnym zapisie
          this.isUserModalOpen = false;

          // Czyścimy formularz dopiero po sukcesie
          this.userForm = {};
          this.selectedDzialIds = [];
          this.selectedFiltrIds = [];

          // Odświeżamy listę
          this.loadUsers();


        },



        error: error => {
          console.error('Delete USERS - error:', error);

          const message =
            error.error?.message ??
            'Nie udało się usunąć użytkownika.';

          this.notificationService.error(message);
        }
      });
  }
 

  closeUserModal(): void
  {
    this.isUserModalOpen = false;
  }
}
