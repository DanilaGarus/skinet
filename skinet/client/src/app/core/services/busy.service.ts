import { Injectable } from '@angular/core';
import {NgxSpinnerService} from "ngx-spinner";

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  busyRequestCouns = 0;

  constructor(private spinnerService: NgxSpinnerService) {}

  busy(){
      this.busyRequestCouns++;
      this.spinnerService.show(undefined,{
        type: 'pacman',
        bdColor: 'rgba(255,255,255,0.7)',
        color:'#333333',
        size: "default"
      });
  }

  idle(){
    this.busyRequestCouns--;
    if(this.busyRequestCouns <= 0){
      this.busyRequestCouns = 0;
      this.spinnerService.hide();
    }
  }
}
