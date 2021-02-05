import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

// @Injectable decorator only used when there is a dependency injected into the constructor. pg. 80
// Support for HTTP requests is provided by the HTTPClient class DI in the constructor.
// This is just to test inside the constructor to see if the repository is working, no HTTP web service yet. pg.60
// this.product = JSON.parse(document.getElementById("data").textContent);
// this is using Http web service instead of static data inside constructor pg. 79 this.getProduct(1)
// this.http.get<Product>("/api/products/" + id)"This is an observable method and returns an Observable<Product> object,
// kind of like an asynchronous.NET task.pg. 80

const productsUrl = "/api/products";

@Injectable() 
export class Repository {
  product: Product;
  products: Product[];

  constructor(private http: HttpClient) {
    
    this.getProducts(true);
  }

  // gets one product by id
  getProduct(id: number) {
    this.http.get<Product>(`${productsUrl}/${id}`)
      .subscribe(p => this.product = p);
  };

  // gets all products and related data available.
  getProducts(related = false) {
    this.http.get<Product[]>(`${productsUrl}?related=${related}`)
      .subscribe(prods => this.products = prods);
  }
}


