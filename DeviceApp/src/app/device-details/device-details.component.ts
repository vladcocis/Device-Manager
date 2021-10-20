import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { DeviceDetail } from '../shared/device-detail.model';
import { DeviceDetailService } from '../shared/device-detail.service';

@Component({
  selector: 'app-device-details',
  templateUrl: './device-details.component.html',
  styles: [],
})
export class DeviceDetailsComponent implements OnInit {
  constructor(
    public service: DeviceDetailService,
    private toastr: ToastrService
  ) {}

  // refresh the list on page initialisation
  ngOnInit(): void {
    this.service.refreshList();
  }

  // gets details from selected object and passes them into form
  // creation of new object is required in order for changes not to be visible in device list as they are being updated in the form
  populateForm(selectedRecord: DeviceDetail) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  // delete object, refresh list to show changes and display toast message confirming action
  onDelete(id: number) {
    // delete action requires extra step for user in order to prevent mishaps
    if (confirm('Are you sure you want to delete this device?')) {
      this.service.deleteDevice(id).subscribe(
        (res) => {
          this.service.refreshList();
          this.toastr.error('Deleted Succesfully', 'Device Deleted');
        },
        (err) => {
          console.log(err);
        }
      );
    }
  }
}
