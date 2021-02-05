import { Component } from '@angular/core';
import { Repository } from "./models/repository";
import { Product } from "./models/product.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private repo: Repository) { }

  // these methods allow the template to data access through the repo.
  get product(): Product {
    return this.repo.product;
  }

  get products(): Product[] {
    return this.repo.products;
  }
}
