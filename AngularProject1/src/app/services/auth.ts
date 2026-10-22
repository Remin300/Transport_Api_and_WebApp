import { Injectable } from '@angular/core';
import { Configuration } from '../api/configuration';
import { LoginUserResponseDto } from '../api/model/loginUserResponseDto';
import { GetAppCacheDto } from '../api/model/getAppCacheDto';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private currentUser: LoginUserResponseDto | null = null;
  private appCache: GetAppCacheDto | null = null;

  private static instanceCounter = 0;
  private instanceId = ++AuthService.instanceCounter;
  constructor(private configuration: Configuration)
  {
    console.log('AuthService instance:', this.instanceId);
  }

  login(response: LoginUserResponseDto): void
  {

    console.log('LOGIN RESPONSE:', response);

    if (response.token) {
      this.configuration.credentials['Bearer'] = 'Bearer ' + response.token;
    }

    console.log(
      'BEARER IN CONFIG:',
      this.configuration.credentials['Bearer']
    );

    this.currentUser = response;

    localStorage.setItem(
      'currentUser',
      JSON.stringify(response)
    );
  }


  saveAppCache(cache: GetAppCacheDto): void
  {
    console.log('SAVE APP CACHE RESPONSE:', cache);
    this.appCache = cache;
    localStorage.setItem('appCache', JSON.stringify(cache));
  }

  getCurrentUser(): LoginUserResponseDto | null {
    return this.currentUser;
  }

  getCurrentAppCache(): GetAppCacheDto | null {
    return this.appCache;
  }

  logout(): void {
    delete this.configuration.credentials['Bearer'];

    this.currentUser = null;

    localStorage.removeItem('currentUser');
    localStorage.removeItem('appCache');
  }
}
