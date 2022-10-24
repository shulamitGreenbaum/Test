import { Component, OnInit } from '@angular/core';
import { Data } from '@angular/router';
import { Members } from '../shared/module/members.module';
import { MemberService } from '../shared/module/services/member.service';

@Component({
  selector: 'app-add-member',
  templateUrl: './add-member.component.html',
  styleUrls: ['./add-member.component.scss']
})
export class AddMemberComponent implements OnInit {
member:Members=<Members>{};
allMembers:Array<Members>=new Array<Members>();
  constructor(private memberService:MemberService) { }

  ngOnInit(): void {
    this.memberService.getMember().subscribe(
     (     res: any)=>(this.allMembers.push(res)),
    (      err: any)=>console.error(err),
    )
  }
 
addMember(fn:string, ln:string, id:string,c:string, st:string, b:any , p:string, cp:string, sickdate :any, recoverydate :any ,AvaccinDate  :any,Atipevaccin :string,BvaccindDate  :any,CvaccinDate :any, DvaccinDate :any,Btipevaccin :string,Dtipevaccin :string,Ctipevaccin :string){
 
  this.member.LastName=ln;
  this.member.Id=id;
  this.member.City=c;
  this.member.FirstName=fn;
  this.member.Steet=st;
  this.member.Bildingnumber=b;
  this.member.Phone=p;
  this.member.Cellphone=cp;
  this.member.Sickdate=sickdate;
  this.member.Recoverydate=recoverydate;
  this.member.AvaccinDate=AvaccinDate;
  this.member.Atipevaccin=Atipevaccin;
  this.member.BvaccindDate=BvaccindDate;
  this.member.CvaccinDate=CvaccinDate;
  this.member.DvaccinDate=DvaccinDate;
  this.member.Btipevaccin=Btipevaccin;
  this.member.Dtipevaccin=Dtipevaccin;
  this.member.Ctipevaccin=Ctipevaccin;
this.memberService.addMember(this.member)
  
  .subscribe(
    (      res: any)=>console.log('currentMember '+this.member),
    (      err: any)=>console.error(err),
  )
}

// gotVaccin(){
//   let flag=true;
// }
}
