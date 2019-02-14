import { Injectable } from "@angular/core";
import { Http, Headers, RequestOptions } from "@angular/http";
import { Observable } from "rxjs";
//import "rxjs/add/operator/map";
import { map } from "rxjs/operators";

@Injectable({
    providedIn: 'root'
})
export class ProductService {

    constructor(private http: Http) { }


    public InsertProduct(IPROD) {
        let fullUrl = "/api/v1/product/InsertProduct";
        let headers = new Headers({ "Content-Type": "application/json" });
        let options = new RequestOptions({ headers: headers });
        return this.http.post(fullUrl, JSON.stringify(IPROD), options).pipe(map(result => result.json()));
    }

    public UpdateProduct(UPROD) {
        let fullUrl = "/api/v1/product";
        let headers = new Headers({ "Content-Type": "application/json" });
        let options = new RequestOptions({ headers: headers });
        return this.http.put(fullUrl, JSON.stringify(UPROD), options).pipe(map(result => result.json()));
    }

    public SearchProductId(SPRODID) {
        let fullUrl = "/api/v1/product/searidpro/" + SPRODID;
        let headers = new Headers({ "Content-Type": "application/json" });
        let options = new RequestOptions({ headers: headers });
        return this.http.get(fullUrl, options).pipe(map(result => result.json()));
    }


    public GetProductFalseAll() {
        let fullUrl = /api/v1/product/false';
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this.http.get(fullUrl, options).pipe(map(result => result.json()));;
    }

    public GetProductAll() {
        let fullUrl = '/api/v1/product';
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this.http.get(fullUrl, options).pipe(map(result => result.json()));;
    }

}
