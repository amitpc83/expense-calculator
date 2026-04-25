import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./header/header";
import { FooterComponent } from "./footer/footer";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HeaderComponent,FooterComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('expenses-angular');
}
