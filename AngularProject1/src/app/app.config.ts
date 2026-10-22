import { ApplicationConfig } from '@angular/core';
import {
  provideRouter,
  RouteReuseStrategy
} from '@angular/router';
import { routes } from './app-routing-module';
import { RouteReuseService } from './services/route-reuse';
import { Configuration } from './api/configuration';

// "Wstrzykujemy"  Angular Router "routes". Zasada działania routes znajduje się w pliku ./app-routing-module
// Dodajemy ustawienia dla Configuration api
export const appConfig: ApplicationConfig = {
  providers: [

    provideRouter(routes),

    {
      provide: RouteReuseStrategy,
      useExisting: RouteReuseService
    },

    {
      provide: Configuration,
      useFactory: () => new Configuration({
        basePath: 'https://localhost:44345'
      })
    }

  ]
};
