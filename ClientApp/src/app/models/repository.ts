import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable() //Only used when there is a dependency injected into the constructor. pg. 80
export class Repository {
  product: Product;

  // support for HTTP requestsis provided by the HTTPClient class, DI here.
  constructor(private http: HttpClient) {
    // this is just to test to see if the repository is working, no HTTP web service yet. pg.60
    //this.product = JSON.parse(document.getElementById("data").textContent);

    // using Http web service instead of static data pg. 79
    this.getProduct(1);
  }
  
  getProduct(id: number) {
    // This is an observable method and returns an Observable<Product> object, kind of like an asynchronous .NET task. pg. 80
    this.http.get<Product>("/api/products/" + id)
      .subscribe(p => this.product = p);
  }
}
