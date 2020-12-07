export default class BaseApi {

    constructor() {
        this.defaultOptions = {
            method: 'GET',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        };
    }

    fetch(uri, options) {
        const optionsObject = Object.assign({}, this.defaultOptions, options);
        return fetch(uri, optionsObject)
            .then(response => {
                // If an API call happens when we're unauthorized, we will get a redirect response
                // We should redirect to the URL of the current page, to both force a new authentication challenge
                // and to prevent us from being redirected to the URL of the API request.
                if (response.redirected) {
                    window.location = window.location.href;
                }
                else
                    return response.json();
            });
    }
}