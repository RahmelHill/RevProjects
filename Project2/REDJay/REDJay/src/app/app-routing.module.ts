import { NgModule } from '@angular/core';
// import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
// import { AppComponent } from './app.component';
import { AboutuspageComponent } from './aboutuspage/aboutuspage.component';
import { HomepageComponent } from './homepage/homepage.component';
import { InvPageComponent } from './inv-page/inv-page.component';
import { LocalepageComponent } from './localepage/localepage.component';
import { UploadpageComponent } from './uploadpage/uploadpage.component';
// import { LoginpageComponent } from './loginpage/loginpage.component';



const routes: Routes = [
  {path:'',component:HomepageComponent},
  {path:'home',component:HomepageComponent},
  {path:'inventory',component:InvPageComponent},
  {path:'locale',component:LocalepageComponent},
  // {path:'login',component:LoginpageComponent},
  {path:'about',component:AboutuspageComponent},
  {path:'Upload',component:UploadpageComponent}
]; 
   // --this is where u put all ur components and url

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

