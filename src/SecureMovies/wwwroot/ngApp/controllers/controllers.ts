namespace SecureMovies.Controllers {

    export class HomeController {
        public movies;
        
        constructor($http: ng.IHttpService) {

            
                $http.get(`/api/movies`).then((response) => {
                    this.movies = response.data;
                })
            
        }
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
