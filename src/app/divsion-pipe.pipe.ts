import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'divsionPipe'
})
export class DivsionPipePipe implements PipeTransform {

  transform(a:number,b:number): unknown {
    return a/b;
  }

}
