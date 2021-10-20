import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { DeviceDetail } from 'src/app/shared/device-detail.model';
import { DeviceDetailService } from 'src/app/shared/device-detail.service';

@Component({
  selector: 'app-device-detail-form',
  templateUrl: './device-detail-form.component.html',
  styles: [],
})
export class DeviceDetailFormComponent implements OnInit {
  constructor(
    public service: DeviceDetailService,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {}

  // when submitting form check if deviceDetailID is 0 (for Create) or has value (for Update)
  onSubmit(form: NgForm) {
    if (this.service.formData.deviceDetailID == 0) this.insertRecord(form);
    else this.updateRecord(form);
  }

  // Create new record in database using form details, reset form, refresh list of devices and show toaster message if successful
  insertRecord(form: NgForm) {
    this.service.postDeviceDetail().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Submitted successfully', 'Device Registered');
      },
      (err) => {
        console.log(err);
      }
    );
  }

  // Update record in database using form details, reset form, refresh list of devices and show toaster message if successful
  updateRecord(form: NgForm) {
    this.service.putDeviceDetail().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated successfully', 'Device Updated');
      },
      (err) => {
        console.log(err);
      }
    );
  }

  // clears all form fields, sets fields as untouched and removes data from formData object to prevent mishaps
  resetForm(form: NgForm) {
    form.resetForm();
    this.service.formData = new DeviceDetail();
  }
}
