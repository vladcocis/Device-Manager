import { Injectable } from '@angular/core';
import { DeviceDetail } from './device-detail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class DeviceDetailService {
  constructor(private http: HttpClient) {}

  // store data from form in a DeviceDetail object
  formData: DeviceDetail = new DeviceDetail();

  // arrow of DeviceDetail objects for mass display - For Read
  list: DeviceDetail[];

  // must be changed to match local path (ports can vary)
  readonly baseURL = 'http://localhost:30857/api/DeviceDetail';

  // send data from form via POST method to the API - For Create
  postDeviceDetail() {
    return this.http.post(this.baseURL, this.formData);
  }

  // send data from form via PUT method to the API - For Update
  putDeviceDetail() {
    return this.http.put(`${this.baseURL}/${this.formData.deviceDetailID}`, this.formData);
  }

  // delete the device via DELETE  method in API - For Delete
  deleteDevice(id:number){
    return this.http.delete(`${this.baseURL}/${id}`);

  }

  // refresh the list of devices after an update
  refreshList() {
    this.http
      .get(this.baseURL)
      .toPromise()
      .then(res => this.list = res as DeviceDetail[]);
  }
}
