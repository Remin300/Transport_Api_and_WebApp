import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
export interface Tab {
  id: string;
  title: string;
  route: string;
}

@Injectable({
  providedIn: 'root'
})
export class TabService {

  tabs: Tab[] = [];
  activeTabId: string | null = null;

  private tabsChangedSource = new Subject<void>();
  tabsChanged$ = this.tabsChangedSource.asObservable();

  private notifyTabsChanged(): void {
    this.tabsChangedSource.next();
  }

  openTab(tab: Tab): void {

    const existingTab = this.tabs.find(x => x.id === tab.id);

    if (!existingTab) {
      this.tabs.push(tab);
    }

    this.activeTabId = tab.id;
  }

  closeTab(id: string): void {

    this.tabs = this.tabs.filter(x => x.id !== id);

    if (this.activeTabId === id) {
      this.activeTabId =
        this.tabs.length > 0
          ? this.tabs[this.tabs.length - 1].id
          : null;
    }

    this.notifyTabsChanged();
  }

  setActiveTab(id: string): void {
    this.activeTabId = id;
  }
}
