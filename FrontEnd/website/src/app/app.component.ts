import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AboutUsComponent } from './about-us/about-us.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,AboutUsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent  implements OnInit{
  title = 'website';
  /**
   *
   */
  constructor() {
    debugger;
  }
  ngOnInit(): void {
    debugger
  }
}
