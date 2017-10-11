export let AppConfig = {
    API_URL: 'http://localhost:5000/api/',
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
