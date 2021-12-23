import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DivisionPipeComponent } from './division-pipe/division-pipe.component';
import { DivsionPipePipe } from './divsion-pipe.pipe';
import { StringFormatComponent } from './string-format/string-format.component';
import { StringFormatPipePipe } from './string-format-pipe.pipe';
import { NoOfWordsComponent } from './no-of-words/no-of-words.component';
import { CountWordPipePipe } from './count-word-pipe.pipe';
import { RepeatWordsComponent } from './repeat-words/repeat-words.component';
import { RepeatWordsPipePipe } from './repeat-words-pipe.pipe';
import { PersonDisplayComponent } from './person-display/person-display.component';

@NgModule({
  declarations: [
    AppComponent,
    DivisionPipeComponent,
    DivsionPipePipe,
    StringFormatComponent,
    StringFormatPipePipe,
    NoOfWordsComponent,
    CountWordPipePipe,
    RepeatWordsComponent,
    RepeatWordsPipePipe,
    PersonDisplayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
