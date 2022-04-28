import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CheckuserService } from '../services/checkuser.service';

@Component({
  selector: 'app-loginpage',
  templateUrl: './loginpage.component.html',
  styleUrls: ['./loginpage.component.css']
})
export class LoginpageComponent implements OnInit {

  _user:CheckuserService
  _router:Router;

 
  constructor(_userRef:CheckuserService,private routerRef:Router)
   {
     this._user = _userRef;
     this._router = routerRef;
    }

    Login()
    {
      this._user.getUser().subscribe( (data)=>{
       
          console.log(data);
          this._user.userDetails = data;
          console.log('Login Successful');       
          this._user.isUserLoggedin = true;
          this._router.navigateByUrl("/home");
      },(err)=>{
          console.log('Login Failed');
      });
    }

    // Login(email:string,pwd:string)
    // {
    //   this._user.getUser(email,pwd).subscribe( (data)=>{
    //     if(data == null)
    //     {
    //       console.log('User Not Found, Login Failed');
    //     }
    //     else
    //     {
    //       console.log(data);
    //       this._user.userDetails = data;
    //       console.log('Login Successful');       
    //       this._user.isUserLoggedin = true;
    //       this._router.navigateByUrl("/home");
        
          
        

    //     }
    //   },(err)=>{
    //       console.log('Login Failed');
    //   });
    // }
   

  ngOnInit(): void {
  }

}
