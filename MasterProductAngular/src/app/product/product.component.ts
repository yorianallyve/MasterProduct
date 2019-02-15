import { Component, OnInit } from "@angular/core";
import * as moment from "moment";
import { Product } from "../models/product";
import { Countries } from "../models/countries";
import { ProductService } from "../services/product.service";

@Component({
  selector: "app-product",
  templateUrl: "./product.component.html",
  styleUrls: ["./product.component.css"],
  providers: [ProductService]
})
export class ProductComponent implements OnInit {
  public ltscountry = new Array();
  public temcountry: number = 0;
  public product: Product = new Product(
    0,
    "",
    "",
    "",
    "",
    "",
    "",
    "",
    "",
    true,
    ""
  );
  NotificationStatus: boolean = false;
  TypeNotification: string = "success";
  TextNotification: string = "Primera notificación";
  public active = true;
  public submitted = false;

  constructor(private productservice: ProductService) {}

  ngOnInit() {
    this.getCountries();
  }

  getCountries() {
    this.productservice.GetCountriesAll().subscribe(result => {
      this.ltscountry = result;
    }),
      error => console.error(error);
  }

  onClickInsertProduct() {
    this.productservice.InsertProduct(this.product).subscribe(
      result => {
        console.log(result);
        if (result.codeError == 0) {
          this.NotificationStatus = true;
          this.TextNotification = result.descriptionError;
          this.TypeNotification = "success";
        } else {
          this.NotificationStatus = true;
          this.TextNotification = result.descriptionError;
          this.TypeNotification = "danger";
        }
      },
      error => console.error(error)
    );
  }

  onClickUpdateProduct() {
    this.productservice.UpdateProduct(this.product).subscribe(
      result => {
        console.log(result);
        if (result.codeError == 0) {
          this.NotificationStatus = true;
          this.TextNotification = result.descriptionError;
          this.TypeNotification = "success";
        } else {
          this.NotificationStatus = true;
          this.TextNotification = result.descriptionError;
          this.TypeNotification = "danger";
        }
      },
      error => console.error(error)
    );
  }

  onClickSearchProductId() {
    this.productservice.SearchProductId(this.product.idProduct).subscribe(
      result => {
        console.log(result);
        if (result != null) {
          this.product.idProduct = result.idProduct;
          this.product.nameProduct = result.nameProduct;
          this.product.properties = result.properties;
          this.product.releaseDate = moment(result.releaseDate).format(
            "YYYY-MM-DD"
          );
          this.product.manufacturerEmail = result.manufacturerEmail;
          this.product.idCountry = result.idCountry;
          this.product.cost = result.cost;
          this.product.unitsAvailable = result.unitsAvailable;
          this.product.soldUnits = result.soldUnits;
          this.product.stateProduct = result.stateProduct;
        } else {
          this.NotificationStatus = true;
          this.TextNotification = "El producto no existe";
          this.TypeNotification = "danger";
        }
      },
      error => console.error(error)
    );
  }

  onClickGetProductAll(STATPROD) {
    this.productservice.GetProductAll(STATPROD).subscribe(
      result => {
        console.log(result);
        if (result != null) {
          this.product.idProduct = result.idProduct;
          this.product.nameProduct = result.nameProduct;
          this.product.properties = result.properties;
          this.product.releaseDate = moment(result.releaseDate).format(
            "YYYY-MM-DD"
          );
          this.product.manufacturerEmail = result.manufacturerEmail;
          this.product.idCountry = result.idCountry;
          this.product.cost = result.cost;
          this.product.unitsAvailable = result.unitsAvailable;
          this.product.soldUnits = result.soldUnits;
          this.product.stateProduct = result.stateProduct;
        } else {
          this.NotificationStatus = true;
          this.TextNotification = "El producto no existe";
          this.TypeNotification = "danger";
        }
      },
      error => console.error(error)
    );
  }

  OnClickCleanProduct() {
    this.product = {
      idProduct: 0,
      nameProduct: "",
      properties: "",
      releaseDate: null,
      manufacturerEmail: null,
      idCountry: null,
      cost: null,
      unitsAvailable: "",
      soldUnits: "",
      stateProduct: true,
      name: ""
    };
    this.temcountry = null;
    this.active = true;
  }

  closeAlert() {
    this.NotificationStatus = !this.NotificationStatus;
  }
}
