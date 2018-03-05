import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import  'rxjs/add/Operator/map';

@Injectable()
export class VehicleService {

  constructor(
    private http: Http
  ) { }

  //GET makes from /api/makes
  getMakes(){
    return this.http.get('/api/makes')
    .map(res => res.json());
  }

  getFeatures(){
    return this.http.get('/api/features')
    .map(res => res.json());
  }
  
}
