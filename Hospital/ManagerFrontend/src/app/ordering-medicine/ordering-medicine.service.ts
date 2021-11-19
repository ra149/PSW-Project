import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IPharmacy } from '../pharmacies-view/pharmacy';

@Injectable({
  providedIn: 'root'
})
export class OrderingMedicineService {

  constructor(private _http: HttpClient) { }

  searchMedicine(name: string, amount: number) : Observable<IPharmacy[]> {
    return this._http.get<IPharmacy[]>('http://localhost:16928/api2/medicine/' + name +'/' + amount);
  }

  //metoda koja uvecava kolicinu leka u bazi bolnice za prosledjenu vrednost
  orderMedicineHospital(name: string, amount: number){
    return this._http.post('http://localhost:16928/api2/medicine', {"id": -1, "name": name, "medicineAmount": amount} );
  }
}
