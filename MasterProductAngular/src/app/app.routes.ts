import { Routes, RouterModule } from "@angular/router";
import { NgModule, ModuleWithProviders } from "@angular/core";
import { HomeComponent } from "./home/home.component";

const APP_ROUTES: Routes = [
  { path: "", redirectTo: "home", pathMatch: "full" },
  { path: "home", component: HomeComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(APP_ROUTES)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
