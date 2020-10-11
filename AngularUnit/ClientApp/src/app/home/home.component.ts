  import { Component, Inject, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { News } from "../news";
import { DataService } from "../data.service";

import {ApiService} from '../api.service';

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  providers: [DataService],
})
export class HomeComponent implements OnInit {
  public news: News[];
  constructor(private dataService: DataService, private apiService:ApiService) {}
  ngOnInit() {
    
    this.loadNews();
    
  }
  loadNews() {
    this.dataService.getNews().subscribe((data: News[]) => (this.news = data));
    
  }
}

