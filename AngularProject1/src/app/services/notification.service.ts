import { Injectable, signal } from '@angular/core';

export type NotificationType = 'success' | 'error' | 'warning' | 'info';

export interface Notification {
  type: NotificationType;
  message: string;
}

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  notification = signal<Notification | null>(null);

  success(message: string): void {
    console.log('NOTIFICATION SUCCESS:', message);
    this.show('success', message);
  }

  error(message: string): void {
    this.show('error', message);
  }

  warning(message: string): void {
    this.show('warning', message);
  }

  info(message: string): void {
    this.show('info', message);
  }

  close(): void {
    this.notification.set(null);
  }

  private show(type: NotificationType, message: string): void {

    this.notification.set({
      type,
      message
    });

    console.log(
      'NOTIFICATION SHOW:',
      this.notification()
    );
  }
}
