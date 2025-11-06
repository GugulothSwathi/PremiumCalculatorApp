import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PremiumCalculatorComponent } from './Components/premium-calculator/premium-calculator.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, PremiumCalculatorComponent],
  templateUrl: './app.html',
  styleUrl: './app.less'
})
export class App {
  protected title = 'PremiumCalUI';
}
