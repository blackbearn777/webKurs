import { Component, OnInit } from '@angular/core';
import {ApiService} from '../api.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {

 
  constructor(private apiService: ApiService) { }
  Items;

  ngOnInit() {
    this.apiService.getImage().subscribe((res:any)=>{
      this.Items = res;
    })
  }

}
