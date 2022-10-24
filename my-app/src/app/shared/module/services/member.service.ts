import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http'
import { Members } from '../members.module';
import { environment } from 'src/environments/environment';
import { map, Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class MemberService {

  constructor( private http:HttpClient) { }
  addMember(member:Members) :Observable<boolean>
  {
       return this.http.post<boolean>(environment.url + 'homepage/AddMember', member);
  }
  getMember():Observable<Members[]>{
    return this.http.get<Members[]>(environment.url + 'homepage/GetMember')
  }
  getMemberById(memberId:string):Observable<Members>{
    return this.http.get<Members>(environment.url + 'homepage/getMemberById/'+memberId);
  }
  saveChanges(member:Members){
    return this.http.post<boolean>(environment.url + 'homepage/SaveChanges', member);
  }
  delete(memberId:string):Observable<boolean>{
    return this.http.delete<boolean>(environment.url+'homepage/delete/'+memberId);

  }
    

  }

