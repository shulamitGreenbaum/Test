import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Route } from '@angular/router';
import { filter, find, map, tap } from 'rxjs';
import { Members } from '../shared/module/members.module';
import { MemberService } from '../shared/module/services/member.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {
  member?:Members=<Members>{};
  allMembers:Members[] =[];
  constructor(private memberService:MemberService) {
   }
  ngOnInit(): void {
    this.getMember();
  }
  
  getMember(){
    this.memberService.getMember().subscribe(res=>{
      this.allMembers=res;
      console.log( "all members :" +this.allMembers);
      console.log("res" +res)
     
    }
    )
  }

  delete(id:string){
this.memberService.delete(id).subscribe(
  res=>{if(res==true){  
    this.getMember()
    
    }  
  }
) 

}
}


