import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Router, ActivatedRoute, Params } from '@angular/router';


@Component({
  selector: 'app-data-results',
  templateUrl: './data-results.component.html'
})
export class DataResultsComponent {
  constructor(private http: HttpClient, private activatedRoute: ActivatedRoute) { }
  summoner: any;

  // tslint:disable-next-line:use-life-cycle-interface
  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params: Params) => {
      const query = params['query'];
      this.http.get('http://localhost:5000/api/values/' + query).subscribe(data => {
        this.summoner = data;
        console.log(data);
      });
    });
  }
}
