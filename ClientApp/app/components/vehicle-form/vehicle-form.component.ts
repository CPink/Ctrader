import { Component, OnInit } from '@angular/core';
import { VehicleService } from '../../services/vehicle.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
    makes: any[];
    models: any[];
    vehicle: any = {};
    features: any;

  constructor(
    private vehicleService: VehicleService
  ) { }

  ngOnInit() {
    this.vehicleService.getMakes().subscribe(makes => {
      this.makes = makes;

      console.log('Makes', this.makes);
    });    

    this.vehicleService.getFeatures().subscribe(features => {
      this.features = features;

      console.log('Features', this.features);
    });
  }

  onMakeChange(){
    var selectedVehicle = this.makes.find(make => make.id == this.vehicle.make);
    this.models = selectedVehicle ? selectedVehicle.models : [];

  }

}
