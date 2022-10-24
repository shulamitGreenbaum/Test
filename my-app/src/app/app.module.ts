import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import {HttpClientModule} from '@angular/common/http';
import { AddMemberComponent } from './add-member/add-member.component'
import { AppRoutingModule } from './app-routing.module';
import { SeeMemberComponent } from './see-member/see-member.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    AddMemberComponent,
    SeeMemberComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
