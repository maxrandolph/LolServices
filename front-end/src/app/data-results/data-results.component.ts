import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Router, ActivatedRoute, Params } from '@angular/router';
import { Summoner } from '../shared/app.config';
import { SummonerService } from '../summoner.service';


@Component({
  selector: 'app-data-results',
  templateUrl: './data-results.component.html'
})
export class DataResultsComponent {
  constructor(private http: HttpClient, private activatedRoute: ActivatedRoute, private _summonerService: SummonerService) { }
  summoner: Summoner = new Summoner('', '', '', '', '', '');
  result: any;
  summonerName: string;

  // tslint:disable-next-line:use-life-cycle-interface
  ngOnInit(): void {
    let query;
    this.activatedRoute.params.subscribe(params => query = params['query']);
    console.log(query);
    this._summonerService.getSummoner(query.replace(/\s/g, '')).subscribe(data =>
      this.processSummoner(data),
      this.summonerName = query
    );
  }

  private processSummoner(summoner) {
    this.summoner = summoner;
    console.log(this.summoner);
    return true;
  }
}
