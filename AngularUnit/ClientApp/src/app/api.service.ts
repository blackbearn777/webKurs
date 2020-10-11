import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class ApiService {
  constructor(private httpClient: HttpClient) {}
  key = "1-Ur6a13LyuRc48Bl8uoMWjWcpSP__q5vVmVG_HY7dc";
  page = 1;
  per_page = 21;
  getImage() {
    return this.httpClient.get(
      `https://api.unsplash.com/photos/?page=${this.page}&per_page=${this.per_page}&client_id=${this.key}`
    );
  }
}