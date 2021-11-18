import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { IEquipment } from './equipment';

@Injectable({
  providedIn: 'root',
})
export class EqupimentService {
  private _equipmentUrl = 'http://localhost:42789/api/rooms/floors';

  constructor(private _http: HttpClient) {}

  getRooms(): Observable<IEquipment[]> {
    return this._http.get<IEquipment[]>(this._equipmentUrl).pipe(
      tap((data) => console.log('All: ', JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse) {
    console.log(err.message);
    return throwError(err.message);
  }
}
