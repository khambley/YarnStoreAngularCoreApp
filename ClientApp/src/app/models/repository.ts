import { Product } from "./product.model";

export class Repository {
  constructor() {
    // this is just to test to see if the repository is working, no HTTP web service yet. pg.60
    this.product = JSON.parse(document.getElementById("data").textContent);
  }
  product: Product;
}
