import { Injectable } from "@angular/core";
import { Http, Headers, RequestOptions } from "@angular/http";
import { Observable } from "rxjs";
//import "rxjs/add/operator/map";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: "root"
})
export class ProductService {
  constructor(private http: Http) {}

  public InsertProduct(IPROD) {
    let fullUrl = "http://localhost:51169/api/product/InsertProduct";
    let headers = new Headers({ "Content-Type": "application/json" });
    let options = new RequestOptions({ headers: headers });
    return this.http
      .post(fullUrl, JSON.stringify(IPROD), options)
      .pipe(map(result => result.json()));
  }

  public UpdateProduct(UPROD) {
    let fullUrl = "http://localhost:51169/api/product/UpdateProduct/";
    let headers = new Headers({ "Content-Type": "application/json" });
    let options = new RequestOptions({ headers: headers });
    return this.http
      .put(fullUrl, JSON.stringify(UPROD), options)
      .pipe(map(result => result.json()));
  }

  public SearchProductId(SPRODID) {
    let fullUrl =
      "http://localhost:51169/api/product/SearchIdProduct?SEARIDPRO=" + SPRODID;
    let headers = new Headers({ "Content-Type": "application/json" });
    let options = new RequestOptions({ headers: headers });
    return this.http.get(fullUrl, options).pipe(map(result => result.json()));
  }

  public GetProductAll(STATPROD) {
    let fullUrl =
      "http://localhost:51169/api/product/GetProductAll?STATPROD =" + STATPROD;
    let headers = new Headers({ "Content-Type": "application/json" });
    let options = new RequestOptions({ headers: headers });
    return this.http.get(fullUrl, options).pipe(map(result => result.json()));
  }
}
