import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Summoner } from './shared/app.config';
import { Observable } from 'rxjs/Observable';
import { AppConfig } from './shared/app.config';
@Injectable()
export class SummonerService {

  constructor(private _http: Http) { }
  getSummoner(name: string): Observable<Summoner> {
    return this._http.get(AppConfig.API_URL + 'values/' + name)
      .map(function (res) {
        return <Summoner>res.json();
      });
  }

}
