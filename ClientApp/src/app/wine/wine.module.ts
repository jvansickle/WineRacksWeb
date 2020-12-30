import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { WineListComponent } from "../wine-list/wine-list.component";
import { RouterModule } from "@angular/router";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";

@NgModule({
  declarations: [WineListComponent],
  imports: [
    CommonModule,
    RouterModule.forRoot([
      {
        path: "wines",
        component: WineListComponent,
        pathMatch: "full",
        canActivate: [AuthorizeGuard],
      },
    ]),
  ],
})
export class WineModule {}
