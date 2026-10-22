export * from './auth.service';
import { AuthService } from './auth.service';
export * from './kontrahent.service';
import { KontrahentService } from './kontrahent.service';
export * from './users.service';
import { UsersService } from './users.service';
export * from './zlecenia.service';
import { ZleceniaService } from './zlecenia.service';
export const APIS = [AuthService, KontrahentService, UsersService, ZleceniaService];
