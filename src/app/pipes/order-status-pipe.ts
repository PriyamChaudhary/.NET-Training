import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'orderStatus',
  standalone: true
})
export class OrderStatusPipe implements PipeTransform {

  transform(value: number): string {
    if (value === 1) return 'Pending..';
    if (value === 2) return 'Shipped';
    if (value === 3) return 'Delivered';
    return 'Unknown';
  }
}