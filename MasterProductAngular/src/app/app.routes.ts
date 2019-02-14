import { Routes, RouterModule } from "@angular/router";
import { NgModule, ModuleWithProviders } from "@angular/core";
import { HomeComponent } from "./home/home.component";
import { ProductComponent } from "./product/product.component";
import { ProductsStockComponent } from "./products-stock/products-stock.component";

const APP_ROUTES: Routes = [
  { path: "", redirectTo: "home", pathMatch: "full" },
  { path: "home", component: HomeComponent },
  { path: "product", component: ProductComponent },
  { path: "products-stock", component: ProductsStockComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(APP_ROUTES)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
