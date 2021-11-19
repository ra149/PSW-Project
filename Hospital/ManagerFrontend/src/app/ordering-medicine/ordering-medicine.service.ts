import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IPharmacy } from '../pharmacies-view/pharmacy';

@Injectable({
  providedIn: 'root'
})
export class OrderingMedicineService {

  constructor(private _http: HttpClient) { }

  searchMedicine(name: string, amount: number){
    return this._http.post('http://localhost:16928/api2/medicine', { "medicineName": name, "medicineAmount": amount})
  }
}
