import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth';
import { AuthService as ApiAuthService } from '../../api/api/auth.service';
import { LoginRequestDto } from '../../api/model/loginRequestDto';
import { switchMap, tap } from 'rxjs';
import { ThemeMode, ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {

  login = '';
  password = '';

  constructor(
    private router: Router,
    private authService: AuthService,
    private apiAuthService: ApiAuthService,
    public themeService: ThemeService
  ) {
  }

  loginUser(): void {

    const request: LoginRequestDto = {
      login: this.login,
      password: this.password
    };


    this.apiAuthService.apiAuthLoginPost(request)
      .pipe(
        tap(response => {
          this.authService.login(response);
        }),
        switchMap(() =>
          this.apiAuthService.apiAuthGetAppCachePost()
        )
      )
      .subscribe({
        next: cache => {
          console.log('APP CACHE:', cache);

          this.authService.saveAppCache(cache);

          this.router.navigate(['/app']);
        },

        error: error => {
          console.error('LOGIN ERROR:', error);
        }
      });


    // this.apiAuthService.apiAuthLoginPost(request)
    //   .subscribe({
    //     next: response => {
    //       console.error(response);

    //       this.authService.login(response);

    //       this.router.navigate(['/app']);

    //     },

    //     error: error => {
    //       console.error('LOGIN ERROR:', error);
    //     }
    //   });



  }
}
