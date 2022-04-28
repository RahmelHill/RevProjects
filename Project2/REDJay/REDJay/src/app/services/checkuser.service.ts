import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class CheckuserService implements CanActivate {

 private _http:HttpClient;
 userDetails:any = "blank";
 isUserLoggedin:boolean = false;
 

  constructor(private _httpRef:HttpClient)
   {
     this._http =_httpRef;
    }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean  {
    if(this.userDetails !="blank")
    {
      
      return true;
    }
    else
    {
      return false;
    }
  }
 

   


    // getUser(email:string, pwd:string)
    // {
    //   let url = "https:localhost:7041/api/Customers/Make_Username=" + email + "/" + pwd;
    //   return this._http.get(url);    
    // }
  
    getUser()
    {
      let url = "https://localhost:7041/api/Users/UserID";
      return this._http.get(url);    
    }
    

}


// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class CheckuserService {

//   constructor() { }
// }

