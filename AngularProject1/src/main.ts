import { bootstrapApplication } from '@angular/platform-browser';
import { App } from './app/app';
import { appConfig } from './app/app.config';

bootstrapApplication(App, appConfig)
  .catch(err => console.error(err));


// =================================================================
// main.ts — uruchomienie wszystkiego

// Teraz idziemy poziom wyżej.

// main.ts
//    │
//    ├── App
//    │
//    └── appConfig

// Czyli Angular dostaje:  „Uruchom komponent App i użyj konfiguracji appConfig.”
// =================================================================
