import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'repeatWordsPipe'
})
export class RepeatWordsPipePipe implements PipeTransform {

  transform(s:string, n: number): unknown {
    return s.repeat(n);
  }

}
