import { Component, OnInit } from "@angular/core";
import { ProductService } from "../services/product.service";
import { Product } from "../models/product";
import { PagerService } from "../services/pager.service";

@Component({
  selector: "app-products-stock",
  templateUrl: "./products-stock.component.html",
  styleUrls: ["./products-stock.component.css"],
  providers: [ProductService, PagerService]
})
export class ProductsStockComponent implements OnInit {
  public products: Product[];
  public ltsproduct: Product[];
  pager: any = {}; //paginador
  pagedItems: any[]; //paginador items
  temprod: ""; //temporal del filtro

  NotificationStatus: boolean = false;
  TypeNotification: string = "success";
  TextNotification: string = "Primera notificación";
  public active = true;
  public submitted = false;
  constructor(
    private productservice: ProductService,
    private pagerservice: PagerService
  ) {}

  ngOnInit() {
    this.productservice.GetProductAll(true).subscribe(result => {
      this.products = result;
      this.ltsproduct = result;
      this.setPage(1);
    }),
      error => console.error(error);
  }

  setPage(page: number) {
    if (page < 1 || page > this.pager.totalPages) {
      return;
    }

    // get pager object from service
    this.pager = this.pagerservice.getPager(this.ltsproduct.length, page);

    // get current page of items
    this.pagedItems = this.ltsproduct.slice(
      this.pager.startIndex,
      this.pager.endIndex + 1
    );
  }

  //Busca  por nombre
  onClickSearchIdProduct() {
    this.ltsproduct = this.products.filter(x =>
      x.nameProduct.toUpperCase().includes(this.temprod.toUpperCase())
    );
    this.pager = {};
    this.setPage(1);
  }

  //Busca  por nombre pais
  onClickSearchIdCountry() {
    this.ltsproduct = this.products.filter(x =>
      x.idCountry.toUpperCase().includes(this.temprod.toUpperCase())
    );
    this.pager = {};
    this.setPage(1);
  }

  //Limpia el formulario
  OnClickCleanProductAll() {
    this.ltsproduct = this.products;
    this.temprod = "";
    this.pager = {};
    this.setPage(1);
  }
}
