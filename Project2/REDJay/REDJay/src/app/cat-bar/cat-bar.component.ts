import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ClothesService } from '../services/clothes.service';
import { Injectable } from '@angular/core';


@Component({
  selector: 'app-cat-bar',
  templateUrl: './cat-bar.component.html',
  styleUrls: ['./cat-bar.component.css']
})
export class CatBarComponent implements OnInit {

  private  _http:HttpClient;
  clothesData:any = [];

  constructor(private _httpclientRef:HttpClient) {
      this._http = _httpclientRef ;
  }



  
  getAllBoots() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Boots').subscribe( (result)=>{
      this.clothesData = result 
      return(result)
    } ) ;
  }

  getAllFullPieceSuits() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Full_Piece_Suits').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllJacketsAndCoats() {
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

  getAllShoes() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Shoes').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllShirts() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Shirts').subscribe( (result)=>{
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

  getAllSweats() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Sweats').subscribe( (result)=>{
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

  
  getAllTankTops() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Tank_Tops').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }



  getAllClothes() {
    this._http
    this._http.get('https://jsonplaceholder.typicode.com/comments').subscribe( (result)=>{
    this.clothesData = result 
    } ) ;
    if (this.clothesData != null)
    {
    console.log(this.clothesData)
    console.log("success")
      }
    }

  getTestApi() {
    this._http
    this._http.get('https://jsonplaceholder.typicode.com/comments').subscribe( (result)=>{
    this.clothesData = result 
    } ) ;
    if (this.clothesData != null)
    {
    console.log(this.clothesData)
    console.log("success")
      }
    }

 

  ngOnInit(): void {
  }

}
