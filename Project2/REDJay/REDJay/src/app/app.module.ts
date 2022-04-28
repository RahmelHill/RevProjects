import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
//import { CarouselComponent } from './carousel/carousel.component';
import { FooterComponent } from './footer/footer.component';
import { CatBarComponent } from './cat-bar/cat-bar.component';
import { InvCarouselComponent } from './inv-carousel/inv-carousel.component';
import { AboutuspageComponent } from './aboutuspage/aboutuspage.component';
// import { LoginComponent } from './login/login.component';
import { StoreLocaleComponent } from './store-locale/store-locale.component';
import { HomepageComponent } from './homepage/homepage.component';
import { InvPageComponent } from './inv-page/inv-page.component';
import { LocalepageComponent } from './localepage/localepage.component';
// import { LoginpageComponent } from './loginpage/loginpage.component';
import { AddrBarComponent } from './addr-bar/addr-bar.component';
import { HttpClientModule } from '@angular/common/http';
import { ClothesService } from './services/clothes.service';
import { CustomersService } from './services/customers.service';
import { CheckuserService } from './services/checkuser.service';


import { UploadpageComponent } from './uploadpage/uploadpage.component';
import { FormsModule } from '@angular/forms';


//import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
// import {NgbPaginationModule, NgbAlertModule} from '@ng-bootstrap/ng-bootstrap';



//import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
// import {NgbPaginationModule, NgbAlertModule} from '@ng-bootstrap/ng-bootstrap';


// import { CheckuserService } from './services/customers.service';



@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
   UploadpageComponent,
    FooterComponent,
    CatBarComponent,
    InvCarouselComponent,
    AboutuspageComponent,
    // LoginComponent,
    StoreLocaleComponent,
    HomepageComponent,
    InvPageComponent,
    LocalepageComponent,
    // LoginpageComponent,
    AddrBarComponent,
    UploadpageComponent 
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,


    FormsModule



    
  ],
  providers: [ClothesService, CustomersService, CheckuserService ],
  bootstrap: [AppComponent]
})
export class AppModule { }