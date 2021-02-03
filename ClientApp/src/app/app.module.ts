import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModelModule } from "./models/model.module";

@NgModule({
  // This property is used to provide a list of Components (building blocks) in the app.
  declarations: [
    AppComponent
  ],
  // This property is used to specify the Angular modules that the app requires. 
  imports: [
    BrowserModule,
    AppRoutingModule,
    ModelModule // custom feature module
  ],
  // This property specifies services for DI
  providers: [],
  // This property specifies the root component of the app which is used to start the app.
  bootstrap: [AppComponent]
})
export class AppModule { }
