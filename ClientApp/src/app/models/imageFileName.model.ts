import { Product } from "./product.model";

export class ImageFileName {
  constructor(
    public imageFileNameId?: number,
    public fileName?: string,
    public product?: Product 
  ) { }
}
