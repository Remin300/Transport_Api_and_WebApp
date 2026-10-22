import { ChangeDetectorRef,Component } from '@angular/core';
import { Tab, TabService } from '../../services/tab';
import { Router, RouterOutlet } from '@angular/router';
import { RouteReuseService } from '../../services/route-reuse';
import { Subscription } from 'rxjs';

import { FormsModule } from '@angular/forms';
import { ThemeMode, ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-main-layout',
  imports: [RouterOutlet, FormsModule],
  standalone: true,
  styleUrl: './main-layout.css',
  templateUrl: './main-layout.html',
})
export class MainLayout {
  private tabsSubscription: Subscription;
  constructor(public tabService: TabService, private router: Router,
    private routeReuseService: RouteReuseService, private cdr: ChangeDetectorRef,
    public themeService: ThemeService)
  {
    // subskrybcja dynamicznego podglądania zmian wywoływana w TAB service. Porzebne do zamykania
    // tabów spoza main-layout. Bez tego brak odświerzenia UI
    this.tabsSubscription = this.tabService.tabsChanged$.subscribe(() => {
      this.cdr.markForCheck();
    });
  }
  strzalka: string = '⮜';

  menuCollapsed = false;



  ngOnDestroy(): void {
    this.tabsSubscription.unsubscribe();
  }

  toggleMenu(): void
  {
    this.menuCollapsed = !this.menuCollapsed;
    this.strzalka = this.menuCollapsed
      ? '⮞'
      : '⮜';
  }


  openUsers(): void {

    this.tabService.openTab({
      id: 'users',
      title: 'Użytkownicy',
      route: '/app/users'
    });
    this.router.navigate(['/app/users']);
  }

  openZlecenia(): void {

    this.tabService.openTab({
      id: 'zlecenia',
      title: 'Zlecenia',
      route: '/app/zlecenia'
      });
    this.router.navigate(['/app/zlecenia']);
  }


  activateTab(tab: Tab): void {
    this.tabService.setActiveTab(tab.id);
    this.router.navigate([tab.route]);
  }

  closeTab(id: string, event: MouseEvent): void {
    event.stopPropagation();

    const tab = this.tabService.tabs.find(x => x.id === id);
    if (!tab) return;

    const wasActive = this.tabService.activeTabId === id;

    if (wasActive) {
      this.routeReuseService.closeRoute(tab.route);
    } else {
      this.routeReuseService.clearRoute(tab.route);
    }

    this.tabService.closeTab(id);

    // Została jakaś zakładka
    if (wasActive && this.tabService.activeTabId) {

      const activeTab = this.tabService.tabs.find(
        x => x.id === this.tabService.activeTabId
      );

      if (activeTab) {
        this.router.navigate([activeTab.route]);
      }

    }
    // Nie ma już żadnej zakładki
    else if (wasActive) {

      this.router.navigate(['/app']);

    }
  }

  closeTab2(id: string, event: MouseEvent): void {
    event.stopPropagation();

    const tab = this.tabService.tabs.find(x => x.id === id);

    if (!tab) {
      return;
    }

    const wasActive = this.tabService.activeTabId === id;

    if (wasActive) {
      this.routeReuseService.closeRoute(tab.route);
    } else {
      this.routeReuseService.clearRoute(tab.route);
    }

    this.tabService.closeTab(id);

    if (wasActive) {
      if (this.tabService.activeTabId) {
        const activeTab = this.tabService.tabs.find(
          x => x.id === this.tabService.activeTabId
        );

        if (activeTab) {
          this.router.navigate([activeTab.route]);
        }
      } else {
        this.router.navigate(['/']);
      }
    }
  }

}
