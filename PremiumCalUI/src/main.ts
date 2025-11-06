import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { App } from './app/app';
import { PremiumCalculatorComponent } from './app/Components/premium-calculator/premium-calculator.component';
import { provideRouter } from '@angular/router';
import { routes } from './app/app.routes';
import { provideHttpClient } from '@angular/common/http';

bootstrapApplication(App, { providers: [provideHttpClient(),provideRouter(routes)]})
  .catch((err) => console.error(err));
