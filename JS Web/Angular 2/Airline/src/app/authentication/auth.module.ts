import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { authComponents } from '.';
import { AuthService } from './auth.service';
import { ReactiveFormsModule} from '@angular/forms' 

@NgModule({
    declarations: [
        ...authComponents
    ],
    imports: [
       CommonModule, 
       ReactiveFormsModule
    ],
    providers: [
        AuthService
    ]
})

export class AuthModule { }