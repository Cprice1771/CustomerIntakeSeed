# LeafLogix Take Home Project 

For this project you will be creating a customer intake form to allow customers to sign up at a terminal provided in store. 

You will be integrating with our public API at 

https://leaflogix-publicapi.azurewebsites.net/swagger/#/

and will be given an API key to integrate with our test environment. 

The application can be written in any technology you like, the only requirements are as follows

1. The customer intake form will create customers in leaflogix 
1. The customer intake form can intake both Recreational and Medical customers 
1. After completing registration customers are giver a success message and a new form is displayed allowing a new customer to sign up
1. Required fields are
    1. If the customer is medical thei Medical Marijuana Id and Expiration date is required. 
    1. Phone number is always required and must be a valid US phone number 
    1. First and last name are required
    1. DOB is required (and must be in the past and after 1800 (no vampires allowed in our system)) 
1. Optional fields are
    1. Address
    1. email 
1. Other fields
    1. Status must be set to active for the customer to be active 
1. Any errors (Invalid data, failed request ect.) must be displayed to the user

Other API Notes: 
1. the name field is deprecated and no longer used, please use firstName and lastName
1. for gender Male, Female, NonBianry and Null are acceptable values.
