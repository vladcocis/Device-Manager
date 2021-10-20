import { NULL_EXPR } from "@angular/compiler/src/output/output_ast";

// initialise DeviceDetail class with default values
// strict null rules have been disabled to allow initialisation with null values
// this is a hack but is an easy way to allow devices to be added without binding them to a userID
export class DeviceDetail {
    deviceDetailID:number=0;
    deviceName:string='';
    manufacturer:string='';
    deviceType:string='';
    os:string='';
    osVersion:string='';
    processor:string='';
    ram:number=null;
    userID:number=null;
}
