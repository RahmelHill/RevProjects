import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-addr-bar',
  templateUrl: './addr-bar.component.html',
  styleUrls: ['./addr-bar.component.css']
})
export class AddrBarComponent implements OnInit {

  x = document.getElementById('storelocaleframe') ;


  constructor() { }


  
  

  ngOnInit(): void {
  }

}
