import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddMemberComponent } from './add-member/add-member.component';
import { HomePageComponent } from './home-page/home-page.component';
import { SeeMemberComponent } from './see-member/see-member.component';

const routes: Routes = [
    { path: '', component: HomePageComponent, pathMatch: 'full' },
    { path: 'app-home-page', component: HomePageComponent },
    { path: 'app-add-member', component: AddMemberComponent },
    { path: 'app-see-member/:id', component: SeeMemberComponent },
  ];

@NgModule({
    imports: [ RouterModule.forRoot(routes) ],
    exports: [ RouterModule ]
  })
  export class AppRoutingModule {}
  