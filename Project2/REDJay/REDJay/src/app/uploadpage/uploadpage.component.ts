import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ClothesService } from '../services/clothes.service';


@Component({
  selector: 'app-uploadpage',
  templateUrl: './uploadpage.component.html',
  styleUrls: ['./uploadpage.component.css']
})
export class UploadpageComponent implements OnInit {

  




  private _clothes:ClothesService;
  private  _http:HttpClient;
 // private _customer:CustomersService;
  constructor(private _httpclientRef:HttpClient, private clothes: ClothesService) {
    this._http = _httpclientRef ;
    this._clothes = clothes;
 
   }
   
   importData:any = [] ;
   
  customersData:any = [] ;
  customersData1:any = [] ;
  customersData2:any = [] ;
  customersData3:any = [] ;
  customersData4:any = [] ;
  customersData5:any = [] ;
  customersData6:any = [] ;
  customersData7:any = [] ;
  customersData8:any = [] ;
  customersData9:any = [] ;
  customersData10:any = [] ;
  customersData11:any = [] ;
  
   

    
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
      getAllUserJacketsCoat()
      {
      this._clothes.getUserJacketsCoat().subscribe((result) => { 
        this.customersData3 = result
        console.log(result)
      });

      }
      getAllUserSneaker()
      {
      this._clothes.getUserSneaker().subscribe((result) => { 
        this.customersData1 = result
        console.log(result)
      });

      }

      getAllUserSweats()
      {
      this._clothes.getUserSweats().subscribe((result) => { 
        this.customersData4 = result
        console.log(result)
      });

      }
      getAllUserFullPieceSuit()
      {
      this._clothes.getUserFullPieceSuit().subscribe((result) => { 
        this.customersData2 = result
        console.log(result)
      });

      }
      getAllUserJean()

      {
      this._clothes.  getUserJean().subscribe((result) => { 
        this.customersData5 = result
        console.log(result)
      });
    }
          getAllUserSandals()
          {
          this._clothes.getUserSandals().subscribe((result) => { 
            this.customersData6 = result
            console.log(result)
          });
        }
        getAllUserShirts()
          {
          this._clothes.getUserShirts().subscribe((result) => { 
            this.customersData7 = result
            console.log(result)
          });
        }
        getAllUserSuitTop()
          {
          this._clothes.getUserSuitTop().subscribe((result) => { 
            this.customersData8 = result
            console.log(result)
          });
            }
            getAllUserSuitBottom()
        {
        this._clothes.getUserSuitBottom().subscribe((result) => { 
          this.customersData9 = result
          console.log(result)
        });
      }
      getAllUserTankTop()
      {
      this._clothes.getUserTankTop().subscribe((result) => { 
        this.customersData10 = result
        console.log(result)
      });
    }
    getAllUserShorts()
      {
      this._clothes.getUserShorts().subscribe((result) => { 
        this.customersData11 = result
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

      editUserTankTop(tankid:any) 
      {

      console.log(tankid)

      this._clothes.approveUserTankTop(tankid).subscribe((result)=> {
        console.log(result)
      });
      }

     


      addFullPiece(form:any)
      {
         form["InStock"] =true
     
         this._clothes.SendFullPieceSuit(form);
          //console.log(form)
     
        }

      editserFullPieceSuit(suitid:any) 
      {

      console.log(suitid)

      this._clothes.approveUserFullPieceSuit(suitid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserJacketsCoat(jacketcoatid:any) 
      {

      console.log(jacketcoatid)

      this._clothes.approveUserJacketsCoat(jacketcoatid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserJeans(jeansid:any) 
      {

      console.log(jeansid)

      this._clothes.approveUserJeans(jeansid).subscribe((result)=> {
        console.log(result)
      });
      }

      editUserSweats(sweatsid:any) 
      {

      console.log(sweatsid)

      this._clothes.approveUserSweats(sweatsid).subscribe((result)=> {
        console.log(result)
      });
      }



      editUserSandals(sandalsid:any) 
      {

      console.log(sandalsid)

      this._clothes.approveUserSandals(sandalsid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserShirts(shirtsid:any) 
      {

      console.log(shirtsid)

      this._clothes.approveUserShirts(shirtsid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserSneakers(sneakersid:any) 
      {

      console.log(sneakersid)

      this._clothes.approveUserSneakers(sneakersid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserSuitTop(suittopid:any) 
      {

      console.log(suittopid)

      this._clothes.approveUserSuitTop(suittopid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserSuitBottom(suitbottomid:any) 
      {

      console.log(suitbottomid)

      this._clothes.approveUserSuitBottom(suitbottomid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserShorts(shortsid:any) 
      {

      console.log(shortsid)

      this._clothes.approveUserShorts(shortsid).subscribe((result)=> {
        console.log(result)
      });
      }


          

        addJacket(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendJacketsCoat(form);
          //console.log(form)
     
        }
        addsneaker(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSneaker(form);
          //console.log(form)
     
        }
        addsweats(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSweats(form);
          //console.log(form)
     
        }
        addjeans(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendJeans(form);
          //console.log(form)
     
        }
        addSandals(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSandals(form);
          //console.log(form)
     
        }
        addShirts(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendShirts(form);
          //console.log(form)
     
        }
        addSuitTop(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSuitTop(form);
          //console.log(form)
     
        }
        addSuitBottom(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSuitBottom(form);
          //console.log(form)
     
        }
        addTankTop(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendTankTop(form);
          //console.log(form)
     
        }                
        addShorts(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendShorts(form);
          //console.log(form)
     
        }

                
        

        ngOnInit(): void {
       
       
        }
    
}
