import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { HttpModule } from "@angular/http";
import { AppRoutingModule } from "./app.routes";
import { FormsModule } from "@angular/forms";
import { AppComponent } from "./app.component";
import { NavbarComponent } from "./navbar/navbar.component";
import { HomeComponent } from "./home/home.component";
import { ProductService } from "./services/product.service";
import { PagerService } from "./services/pager.service";
import { ProductComponent } from "./product/product.component";
import { ProductsStockComponent } from "./products-stock/products-stock.component";

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    ProductComponent,
    ProductsStockComponent
  ],
  imports: [
    BrowserModule,
    NgbModule.forRoot(),
    HttpModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [ProductService, PagerService],
  bootstrap: [AppComponent]
})
export class AppModule {}
