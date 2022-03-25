
# Coure Assessment

Country Detail API

## Authors

- [@pelumiadebayo](https://www.github.com/pelumiadebayo)


## Run Locally

Clone the project

```bash
  git clone https://github.com/pelumiadebayo/CoureAssessment
```


Install nuget packages

```bash
    install Microsoft.EntityFrameworkCore.InMemory version 3.1.23
    install AutoMapper version 11.0.1
    install Swashbuckle.AspNetCore lastest version
    install Microsoft.EntityFrameworkCore version 3.1.22

```


run the project
 Redirect to swagger UI by adding /swagger to the url in the broswer.
 Call the enpoint with appropriate request body in swagger


Alternatively:
```bash

Run the project.
Call a get method with endpoint url below in postman
    {BaseUrl}/api/CountryDetails/get-country-details/{phoneNumber}
```

Defination:

BaseUrl: The url of the project in run.

phoneNumber: valid phone number with country code eg, 23467890867

