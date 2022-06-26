import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/product.service';
import { CartService } from '../services/cart.services';
@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {

  constructor(private _productservice: ProductService,private cartService : CartService) { }

  public products : any ; 
   ngOnInit(): void {

    this._productservice.getProducts().subscribe(res => this.products = res, err => console.log(err))
  }
  
  addtocart(product: any){
   this.cartService.addtoCart(product);
  }

}