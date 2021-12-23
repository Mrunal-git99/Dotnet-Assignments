import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'stringFormatPipe'
})
export class StringFormatPipePipe implements PipeTransform {

  transform(s:string, op:string): unknown {
    return s.replace(" ",op);
  }

}
