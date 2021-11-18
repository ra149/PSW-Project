import { Component, OnInit } from '@angular/core';
import { IEquipment } from '../equipment';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-room-equipment',
  templateUrl: './room-equipment.component.html',
  styleUrls: ['./room-equipment.component.css'],
})
export class RoomEquipmentComponent implements OnInit {
  isLinear = false;
  firstFormGroup!: FormGroup;
  secondFormGroup!: FormGroup;
  thirdFormGroup!: FormGroup;
  selectedEquipment!: IEquipment;
  equipments: any[] = [
    {
      text: 'Igla',
    },
    {
      text: 'Infuzija',
    },
    {
      text: 'Krevet',
    },
  ];

  constructor(private _formBuilder: FormBuilder) {}

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required],
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required],
    });
    this.thirdFormGroup = this._formBuilder.group({
      thirdCtrl: ['', Validators.required],
    });
  }
}
