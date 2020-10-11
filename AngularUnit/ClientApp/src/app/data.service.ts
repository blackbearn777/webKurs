import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { News } from "./news";
@Injectable()
export class DataService {
  private url = "/news";
  constructor(private http: HttpClient) {}
  getImages(){
    return
  }
  getNews() {
    return this.http.get(this.url);
  }
}
