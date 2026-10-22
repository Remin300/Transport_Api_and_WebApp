
import { Injectable } from '@angular/core';

export type ThemeMode = 'light' | 'dark' | 'system';

@Injectable({
  providedIn: 'root'
})
export class ThemeService {
  private readonly storageKey = 'app-theme';

  private systemQuery = window.matchMedia('(prefers-color-scheme: dark)');

  constructor() {
    const saved = localStorage.getItem(this.storageKey) as ThemeMode | null;

    this.setTheme(saved ?? 'system');

    this.systemQuery.addEventListener('change', () => {
      if (this.getTheme() === 'system') {
        this.applyTheme('system');
      }
    });
  }

  setTheme(theme: ThemeMode): void {
    localStorage.setItem(this.storageKey, theme);
    this.applyTheme(theme);
  }

  getTheme(): ThemeMode {
    return (localStorage.getItem(this.storageKey) as ThemeMode) ?? 'system';
  }

  private applyTheme(theme: ThemeMode): void {
    const dark =
      theme === 'dark' ||
      (theme === 'system' && this.systemQuery.matches);

    document.documentElement.setAttribute(
      'data-theme',
      dark ? 'dark' : 'light'
    );

    document.documentElement.style.colorScheme = dark ? 'dark' : 'light';
  }
}
