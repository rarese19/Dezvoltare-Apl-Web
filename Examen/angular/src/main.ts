import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.component'; // Importați modulul principal al aplicației

platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
