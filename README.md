# LeafLogix Take Home Project 

For this project you will be creating a customer intake form to allow customers to sign up at a terminal provided in store. 

You will be integrating with our public API and will be given an API key to integrate with our test environment.

https://leaflogix-publicapi.azurewebsites.net/swagger/#/

The application can be written in any technology you like, and you are free to import any libraries you like. 

The only requirements are as follows

1. The customer intake form will create customers in leaflogix 
1. The customer intake form can intake both Recreational and Medical customers 
1. After completing registration customers are giver a success message and a new form is displayed allowing a new customer to sign up
1. Required fields are
    1. Customer Type
    1. If the customer is medical their Medical Marijuana Id and Expiration date is required. 
    1. If the customer is recreational MMJ Id and Expdate do not apply to them, as rec customers will not have an MMJ Card.
    1. Phone number is always required and must be a valid US phone number 
    1. First and last name are required
    1. DOB is required (and must be in the past and after 1800 (no vampires allowed in our system)) 
1. Optional fields are
    1. Name Prefix, middle, and Suffix 
    1. Address
    1. Email
    1. Gender
1. Other fields
    1. Status field should be set to active for the customer to be active 
    1. for gender Male, Female, NonBianry and Null are acceptable values.
    1. Valid customer types are Medical and Recreational.
    1. ExternalId is to be used by external apps for their own use.
1. User should be given feedback on failed and successful sign up

Other API Notes: 
1. the name field is deprecated and no longer used, please use firstName and lastName in place of it
1. For authorization convert your auth token to base64 and then put a head in your requests with name Authorization and value 'Basic <base64-key>' (without the quotes)
