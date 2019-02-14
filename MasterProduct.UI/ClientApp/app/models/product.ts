export class Product {
    constructor(
        public IdProduct: number,
        public NameProduct: string,
        public Properties: string,
        public ReleaseDate: string,
        public ManufacturerEmail: string,
        public IdCountry: number,
        public Cost: string,
        public UnitsAvailable: string,
        public SoldUnits: string,
        public StateProduct: boolean,
        public ImageProduct: string,
    ) { }
}