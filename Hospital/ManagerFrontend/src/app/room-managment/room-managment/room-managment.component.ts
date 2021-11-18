import { Component, OnInit, ViewChild } from '@angular/core';
import { SidenavService } from 'src/app/shared/responsive-sidebar/sidenav.service';

@Component({
  selector: 'app-room-managment',
  templateUrl: './room-managment.component.html',
  styleUrls: ['./room-managment.component.css']
})
export class RoomManagmentComponent implements OnInit {

  constructor(
    private _sidenav: SidenavService
  ) { }

  ngOnInit(): void {
  }

  toogle() {
    this._sidenav.toggle();
  }

}
