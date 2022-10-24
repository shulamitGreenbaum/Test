import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Members } from '../shared/module/members.module';
import { MemberService } from '../shared/module/services/member.service';

@Component({
  selector: 'app-see-member',
  templateUrl: './see-member.component.html',
  styleUrls: ['./see-member.component.scss']
})
export class SeeMemberComponent implements OnInit {
  member: Members =<Members>{};
  constructor(private memberService:MemberService, private route: ActivatedRoute,) {
    }
  
  ngOnInit(): void {
    let id=this.route.snapshot.paramMap.get('id');
    if(id!=null){
      this.getMemberById(id);
    }
  }
  getMemberById(idMember:string) {
   
     this.memberService.getMemberById(idMember).subscribe(
      (      res: Members)=>
      {
this.member=res;
      }
      
    )
  }
  saveChanges(fn:string, ln:string, id:string,c:string, st:string, b:any , p:string, cp:string, sickdate :any, recoverydate :any ,AvaccinDate  :any,Atipevaccin :string,BvaccindDate  :any,CvaccinDate :any, DvaccinDate :any,Btipevaccin :string,Dtipevaccin :string,Ctipevaccin :string){
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
this.memberService.saveChanges(this.member).subscribe(
  (      res: any)=>('currentMember '+this.member),
  (      err: any)=>(err),
)

}
}