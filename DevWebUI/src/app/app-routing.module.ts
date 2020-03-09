import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HttpClient} from '@angular/common/http';
import { HomeComponent } from './component/home/home.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
