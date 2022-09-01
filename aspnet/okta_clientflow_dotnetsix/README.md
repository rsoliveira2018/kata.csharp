## Okta Secured API - OAuth 2.0

This project is intended to serve as a sandbox to playing around with Okta and its OAuth2.0 flows for authorizing a Web API.
Up to now (01/sep/2022), the method WeatherForecast, same as scaffolded by Visual Studio, is secured under "api" scope.

To set up an Authorization Server in order to make it work, you are going to need:
- Okta **account** (okta.com);
- **Scope** "api" created in your Okta account (or any other name you'd like, but remember to change it also in the application then);
- An application created in your Okta account (with **client id** and **client secret** as usual).

We recommend you check out the link down below in order to fully understand it:
* https://developer.okta.com/blog/2022/04/20/dotnet-6-web-api

Plus, take a look at the postman collection in the **postman folder** where you will find some useful requests to retrieve the access token and access the protected endpoint.

### Remember ###
When using this collection, you will need to fill up the environment variables on Postman, exactly these ones:
- auth_server_default_url: Okta's authorization server URL. Grab it from Okta;
- scope: the one you created when setting up Okta's account. Probably "api" unless you intentionally changed it;
- client_id: the ID that identifies your application on Okta;
- client_secret: the secret that uniquely identifies your application on Okta (sensitive information);
- access_token (this one is needed when running the request "API Secured Weather Forecast" and is automatically after running the request "OKTA Access Token");