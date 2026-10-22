import { Routes } from '@angular/router';
import { Login } from './pages/login/login';
import { MainLayout } from './layout/main-layout/main-layout';
import { Users } from './pages/users/users';
import { Zlecenia } from './pages/zlecenia/zlecenia';
import { ZlecenieEdit } from './pages/zlecenie-edit/zlecenie-edit';

// =================================================================
// To jest w praktyce mapa adresów URL na komponenty.
// Możemy ją czytać:

// Jeżeli URL jest pusty → wyświetl MainLayout.
// Jeżeli URL jest / users → wewnątrz MainLayout wyświetl Users.
// Jeżeli URL jest / zlecenia → wewnątrz MainLayout wyświetl Zlecenia.

// itd
// =================================================================

export const routes: Routes = [
  {
    path: 'login',
    component: Login
  },

  {
    path: 'app',
    component: MainLayout,
    children: [
      {
        path: 'users',
        component: Users
      },
      {
        path: 'zlecenia',
        component: Zlecenia
      },
      {
        path: 'zlecenia/:id',
        component: ZlecenieEdit
      }


    ]
  },


  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  }


];

// =================================================================
// Dlaczego mamy children?

// MainLayout ma w HTML " <router-outlet></router-outlet> ".
// Czyli mówi Angularowi: „Tutaj, wewnątrz mnie, włóż komponent wynikający z child route.”


// Dopasowanie odbywa się hierarchicznie:

// App
//  │
//  └── MainLayout
//        │
//        └── router - outlet
//               │
//               └── Users
// =================================================================
