import { ApiReturn, Results } from './../../models/api-return';
import { ApiService } from './../../service/api.service';
import { Component } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent {
  public resultList$ = new Subject<Results[] | undefined>();

  constructor(public service: ApiService) { }

  ngOnInit(): void {
    this.service.getCharacterList().subscribe (
      (resp) => {
        //console.log(resp);
        this.resultList$.next(resp.results);
      }
    );
  }
}
