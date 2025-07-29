# SimpleLedger

This is a simple ledger application written in C#. It allows users to manage a simple ledger of Credits and debits, providing features such as adding, viewing, and deleting transactions. There is also a very simple reporting interface that you can use to see transactions for a specific category/payee. 

## Using the Application

After loading, you are greeted with a simple dashboard that shows you the last 5 credits and debits to the ledger along with the balance in the right corner.

Clicking View Ledger on the top navigation bar will take you to the ledger page where you can see and work with all transactions.

Clicking Reports will allow you to run some basic reporting showing you all the transactions that meet your search criteria as well as totals by categroy and payee for those transactions. 

## Assumptions

### Dependencies

- dotnet 9
- [bootstrap](https://www.getbootstrap.com)
- [Jquery](https://jquery.com/)

### Data Layer

Data access is defined by a couple of interfaces that can be easily implemented to support whatever data layer you want. Currently only the in memory layer is implemented.

### Deployment

Deployment is done through CI/CD with any commit into the main branch. 

Site is deployed to a Azure Web App hosted on the Free Tier. 

## Trade Offs

From the creation to the github repo to the deployment to azure, this web application was written in four hours. Things not implemented that I would've liked but just ran out of time in order of "importance". 

- External API for other applications to connect to
- SQL Server Data Store
- Authentication to Cloud Services
- Applicaiton montior via Azure Application Insights
- Support for the idea of Accounts in which a ledger would fall under

