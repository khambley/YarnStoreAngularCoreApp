import { Supplier } from "./supplier.model";
import { Rating } from "./rating.model";
import { ImageFileName } from "./imageFileName.model";

export class Product {
  constructor(
    public productId?: number,
    public name?: string,
    public category?: string,
    public description?: string,
    public price?: number,
    public supplier?: Supplier,
    public quantityOnHand?: string,
    public manufacturer?: string,
    // yarn attributes
    public yarnType?: string,
    public weight?: number,
    public yardage?: number,
    public fiberBlend?: string,
    public mainColor?: string,
    public knittingGauge?: string,
    public crochetGauge?: string,
    public isWashable?: boolean,
    public collection?: string,
    // needles attributes
    public length?: number,
    public sizeUS?: number,
    public needlesType?: string,
    public isInterchangeable?: boolean,
    // navigation properties
    public imageFiles?: ImageFileName[],
    public ratings?: Rating[]) { }   
}
