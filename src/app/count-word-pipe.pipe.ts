import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'countWordPipe'
})
export class CountWordPipePipe implements PipeTransform {

  transform(s:string): unknown {
    return s.length;
  }

}
