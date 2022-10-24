import { Data } from "@angular/router";

 export interface Members
{
    TableID: number
    FirstName :string
     LastName :string
     Id :string
     City:string
     Steet:string
     Bildingnumber :number
    Birthday :Date
     Phone :string
     Cellphone :string
    // vaccinDate! :Date
    //  tipevaccin!:string
    AvaccinDate ? :Date
    Atipevaccin?:string
    Sickdate ?:Date
     Recoverydate? :Data
    BvaccindDate ? :Date
    CvaccinDate ? :Date
    DvaccinDate ? :Date
      Btipevaccin? :string
      Dtipevaccin? :string
      Ctipevaccin? :string
}