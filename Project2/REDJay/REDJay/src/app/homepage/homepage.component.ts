import { Component, OnInit } from '@angular/core';
import { ClothesService } from '../services/clothes.service';
import { CustomersService } from '../services/customers.service';
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
//import { cwd } from 'process';
import { LoginComponent } from '../login/login.component';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

  //Continued notes and demo code related to Nikhil's demo project. 
  //Will declare a variable of type service that this component will listen to 
  //for data. In my case the clothes data. 
  // private _clothesSer:ClothesService; 


  private _clothes:ClothesService;
  private  _http:HttpClient;
 // private _customer:CustomersService;
  constructor(private _httpclientRef:HttpClient, private clothes:ClothesService) {
    this._http = _httpclientRef ;
    this._clothes = clothes;

  }
  
  customersData:any = [] ;



  //post
addboots(form:any)
{
  form["InStock"] =true

this._clothes.SendBoots(form);
 //console.log(form)



}

//get
getAllUsersBoot()
{
this._clothes.getUserBoots().subscribe((result) => { 
  this.customersData = result
  console.log(result)
});

}

//put
editUserBoot(bootid:any) 
{

console.log(bootid)

this._clothes.approveUserBoot(bootid).subscribe((result)=> {
  console.log(result)
});
}




getAllCustomers() 
{
  this._http
  this._http.get('https://localhost:7041/api/Customers/List_of_Customers').subscribe( (result)=>{
    this.customersData = result 
 
  } ) ;
  if (this.customersData != null)
  {
    console.log(this.customersData)
    console.log("success")
  }


 }

  ngOnInit(): void {
  }

}
