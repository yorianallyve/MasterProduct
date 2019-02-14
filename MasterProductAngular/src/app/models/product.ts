export class Product {
  constructor(
    public idProduct: number,
    public nameProduct: string,
    public properties: string,
    public releaseDate: string,
    public manufacturerEmail: string,
    public idCountry: string,
    public cost: string,
    public unitsAvailable: string,
    public soldUnits: string,
    public stateProduct: boolean,
    public name: string
  ) {}
}
