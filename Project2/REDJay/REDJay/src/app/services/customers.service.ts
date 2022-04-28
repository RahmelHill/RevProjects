import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CustomersService {

  private  _http:HttpClient;
  private userName:any ;
  private password:any ;

  constructor(private _httpclientRef:HttpClient) {
      this._http = _httpclientRef ;
  }

  //Variable for returned information
  customersData:any = [] ;



  //CREATE
  // https://localhost:7041/api/Customers/Register_Customer

   // createUser(email:string, pwd:string)
    // {
    //   let url = "https:localhost:7041/api/Customers/Make_Username=" + email + "/" + pwd;
    //   return this._http.get(url);    
    // }

  


  register() {

  }


  //READ
  getCustomer() {
    this._http.get('https://localhost:7041/api/Users/UserID').subscribe( (result)=>{
      this.customersData = result 
    } ) ;
  }
  
  getAllCustomers() {
    this._http.get('https://localhost:7041/api/Customers/List_of_Customers').subscribe( (result)=>{
      this.customersData = result 
    } ) ;
  }

}
