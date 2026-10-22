import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Notification } from './components/notification/notification';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Notification],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
}


// =================================================================

// App jest korzeniem drzewa komponentów Angulara. jest pierwszym naszym komponentem ale sam App praktycznie nic nie robi.
// Jego HTML:  <router-outlet></router-outlet>

// Co oznacza router-outlet?
// To nie jest zwykły HTML.
// To jest miejsce zarezerwowane dla Routera.
// Możesz myśleć o nim jak o:  [TU ANGULAR WSTAWI ODPOWIEDNI KOMPONENT]

// Czyli:
// <router-outlet > </router-outlet>  nie oznacza:  „wyświetl jakiś komponent RouterOutlet”.
// Tylko:  „Routerze, tutaj umieść komponent wynikający z aktualnego URL.”

// =================================================================
