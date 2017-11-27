export let AppConfig = {
    API_URL: 'http://localhost:64558/api/',
};
export class Summoner {
    constructor(
        public id: string,
        public accountId: string,
        public name: string,
        public profileIconId: string,
        public revisionDate: string,
        public summonerLevel: string,
    ) { }
}
