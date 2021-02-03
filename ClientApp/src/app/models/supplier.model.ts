export class Supplier {
  constructor(
    public supplierId?: number,
    public name?: string,
    public streetAddress?: string,
    public mailingAddress?: string,
    public city?: string,
    public state?: string,
    public zipCode?: string,
    public phone?: string,
    public websiteUrl?: string,
    public email?: string
  ) { }
}
