import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ClothesService {

  //privately declared variable that will take a injected global 
  //HttpClient variable from the constructor when the class is invoked
  private  _http:HttpClient;
  public errorMessage:any;

  constructor(private _httpclientRef:HttpClient) {
      this._http = _httpclientRef ;
  }

  //Variable for returned information
  clothesData:any = [] ;

  //CRUD methods like getClothesList(), updatePants(), etc will go here
  //sucha as given example. The URL below is the URL from the API demo 
  //that Nikhil made we will have our own URL's from our API





  //CREATE


  
  importdata:any = [] ;
  importdata1:any = [] ;
  importdata2:any = [] ;
  importdata3:any = [] ;
  importdata4:any = [] ;
  importdata5:any = [] ;
  importdata6:any = [] ;
  importdata7:any = [] ;
  importdata8:any = [] ;
  importdata9:any = [] ;
  importdata10:any = [] ;
  importdata11:any = [] ;
  importdata12:any = [] ;

  // adding a new user boot
SendBoots(form:any) 
{
  // var data = {
  //   "UploadStyle":form, "UploadBrand" :"polo", "InStock": true, "UploadSize": 1, "UploadCondition" : 1 }
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Boots',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata != null)
     {
       console.log(this.importdata)
       console.log("success")
     }
}

// adding a new user FullPieceSuit
SendFullPieceSuit(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_FullPieceSuit',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata1 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata1 != null)
     {
       console.log(this.importdata1)
       console.log("success")
     }
}

// adding a new user JacketsCoat
SendJacketsCoat(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_JacketsCoat',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata2 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata2 != null)
     {
       console.log(this.importdata2)
       console.log("success")
     }
}

// adding a new user Sneaker
SendSneaker(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Sneaker',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata3 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata3 != null)
     {
       console.log(this.importdata3)
       console.log("success")
     }
}

// adding a new user Sweats
SendSweats(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Sweats',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata4 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata4 != null)
     {
       console.log(this.importdata4)
       console.log("success")
     }
}

// adding a new user Jeans
SendJeans(form:any) 
{
     this._http
     this._http.post<any>("https://localhost:7041/api/UserInventory/Add_UserJeans",form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata5 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata5 != null)
     {
       console.log(this.importdata5)
       console.log("success")
     }
}

// adding a new user Sandals
SendSandals(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Sandals',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata6 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata6 != null)
     {
       console.log(this.importdata6)
       console.log("success")
     }
}

// adding a new user Shirts
SendShirts(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Shirts',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata7 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata7 != null)
     {
       console.log(this.importdata7)
       console.log("success")
     }
}

// adding a new user SuitTop
SendSuitTop(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_SuitTop',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata8 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata8 != null)
     {
       console.log(this.importdata8)
       console.log("success")
     }
}

// adding a new user SuitBottom
SendSuitBottom(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_SuitBottom',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata9 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata9 != null)
     {
       console.log(this.importdata9)
       console.log("success")
     }
}

// adding a new user TankTop
SendTankTop(form:any) 
{
     this._http
     this._http.post<any>("https://localhost:7041/api/UserInventory/Add_TankTop",form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata10 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata10 != null)
     {
       console.log(this.importdata10)
       console.log("success")
     }
}

// adding a new user Shorts
SendShorts(form:any) 
{
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Shorts',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importdata11 = result;
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importdata11 != null)
     {
       console.log(this.importdata11)
       console.log("success")
     }
}





  //approve user boot
  approveUserBoot(id:any)
  {
    return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Boots/"+id,null))
  }

  //approve user FullPieceSuit
  approveUserFullPieceSuit(id:any)
  {
    return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_FullPieceSuit"+id,null))
  }

//approve user JacketsCoat
approveUserJacketsCoat(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_JacketsCoat/"+id,null))
}

//approve user Jeans
approveUserJeans(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Jeans"+id,null))
}

//approve user Sandals
approveUserSandals(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Sandals"+id,null))
}

//approve user Shirts
approveUserShirts(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Shirts"+id,null))
}
//approve user sweats 
approveUserSweats(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Sweats"+id,null))
}

//approve user Seakers
approveUserSneakers(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Sneakers"+id,null))
}

//approve user SuitTop
approveUserSuitTop(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_SuitTop"+id,null))
}

//approve user SuitBottom
approveUserSuitBottom(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_SuitBottom"+id,null))
}
//approve user SuitBottom
approveUserTankTop(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_TankTops"+id,null))
}


//approve user Shorts
approveUserShorts(id:any)
{
  return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Shorts"+id,null))
}



  //get user boots
  getUserBoots()
  {

    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserBoots'))
  }

  //get user FullPieceSuit
  getUserFullPieceSuit()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserFullPieceSuit'))
  }

  //get user JacketsCoat
  getUserJacketsCoat()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserJacketsCoat'))
  }

  //get user Sneaker
  getUserSneaker()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserSneaker'))
  }

  //get user Sweats
  getUserSweats()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserSweats'))
  }

  //get user Jean
  getUserJean()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserJean'))
  }

  //get user Sandals
  getUserSandals()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserSandals'))
  }

  //get user Shirts
  getUserShirts()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserShirts'))
  }

  //get user SuitTop
  getUserSuitTop()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserSuitTop'))
  }

  //get user SuitBottom
  getUserSuitBottom()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserSuitBottom'))
  }

  //get user TankTop
  getUserTankTop()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserTankTop'))
  }

  //get user Shorts
  getUserShorts()
  {
    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserShorts'))
  }







//READ


  getFullPieceSuits() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Full_Piece_Suits').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getCoatsAndJackets() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Jackets/Coats').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllJeans() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Jeans').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSandals() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Sandals').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllShorts() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Shorts').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSneakers() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Sneakers').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSuitBottoms() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Suit_Bottoms').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSuitTops() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Suit_Tops').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSweats() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Sweats').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllShirts() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Shirts').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }
  
  getAllTankTops() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Tank_Tops').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }


  //UPDATE
  /*
  https://localhost:7041/api/UserInventory/Edit_Boots
https://localhost:7041/api/UserInventory/Edit_FullPieceSuits
https://localhost:7041/api/UserInventory/Edit_Jeans
https://localhost:7041/api/UserInventory/Edit_Shorts
https://localhost:7041/api/UserInventory/Edit_Sandals
https://localhost:7041/api/UserInventory/Edit_JacketsCoats
https://localhost:7041/api/UserInventory/Edit_SuitBottom
https://localhost:7041/api/UserInventory/Edit_TankTops
https://localhost:7041/api/UserInventory/Edit_Sweats
https://localhost:7041/api/UserInventory/Edit_Sneakers
https://localhost:7041/api/UserInventory/Edit_SuitTop
https://localhost:7041/api/UserInventory/Edit_Shirts

  */









  //2. The next task will be to get the data from the service and display it in a given 
  //component. 
  //Go to the ts file of the component that will display information. Like the carousel 
  //for the homepage. (In such a case seeing as though the database will not have 
  //the byte or hexadecimal data for the image. I will have to read the jpg namespace 
  //from a name attribute and display the appropriate picture selected from the assets 
  //folder. This should come with the result that is returned such as the call made 
  //above. Instead of the list of employees like in the example. It should return a 
  //list of clothes including the picture jpg info. )
  //
  //I will now go to the homepages ts file to continue notes. For this example. 






}
