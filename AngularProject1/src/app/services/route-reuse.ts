import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  DetachedRouteHandle,
  RouteReuseStrategy
} from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class RouteReuseService implements RouteReuseStrategy {

  private storedRoutes = new Map<string, DetachedRouteHandle>();
  private routesToDiscard = new Set<string>();

  shouldDetach(route: ActivatedRouteSnapshot): boolean {
    const key = this.getKey(route);

    if (this.routesToDiscard.has(key)) {
      this.routesToDiscard.delete(key);
      this.storedRoutes.delete(key);

      return false;
    }

    return key === 'users' || key === 'zlecenia';
  }

  store(
    route: ActivatedRouteSnapshot,
    handle: DetachedRouteHandle
  ): void {

    const key = this.getKey(route);

    this.storedRoutes.set(key, handle);
  }

  shouldAttach(route: ActivatedRouteSnapshot): boolean {
    const key = this.getKey(route);

    return this.storedRoutes.has(key);
  }

  retrieve(route: ActivatedRouteSnapshot): DetachedRouteHandle | null {
    const key = this.getKey(route);

    return this.storedRoutes.get(key) ?? null;
  }

  shouldReuseRoute(
    future: ActivatedRouteSnapshot,
    current: ActivatedRouteSnapshot
  ): boolean {

    return future.routeConfig === current.routeConfig;
  }

  private getKey(route: ActivatedRouteSnapshot): string {
    return route.routeConfig?.path ?? '';
  }

  clearRoute(route: string): void {
    const key = route.replace('/', '');

    this.storedRoutes.delete(key);
  }

  closeRoute(route: string): void {
    const key = route.replace('/', '');

    this.storedRoutes.delete(key);

    this.routesToDiscard.add(key);
  }
}
