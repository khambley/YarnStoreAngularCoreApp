import { NgModule } from "@angular/core";
import { Repository } from "./repository";
import { HttpClientModule } from '@angular/common/http';


// This is the decorator. The NgModule decorator tells Angular that ModelModule is a feature module.
@NgModule({
  imports: [HttpClientModule],
  // Configuration property used to register classes for DI.
  providers: [Repository]
})

// This is a TypeScript class.
export class ModelModule { }
