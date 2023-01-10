# TariffSelection API

TariffSelectionApi was developed with ASP.NET Core.
Solution contains Web API project.
Controller contains two methods and both of them is HttpGet method.
Factory Design Pattern is used. FactoryDesign.cs is implemented for creating instance according to type of tariff.
The creation of object is done when it is required and also Factory design allows to implement new type(new product) easily and clear.
SwaggerUI is used for testing method. 

## GetAllTarifProviders

"GetAllTarifProviders" was implemented for reading TariffProvider.json file. There is no input value, Json data is returned value.
It reads data from json and return List of BasicProduct objects.

## GetAllTarifProvidersWithCons

"GetAllTarifProvidersWithCons" was implemented for calculating annual cost with the input consumption Kwh.
GetAllTarifProvidersWithCons gets  integer value as an consumption.
According to Basic or Packaged Tariff type , it returns annual cost in ordered list according to annual cost.

## Usage

When you run program , you will see Swagger interface in your browser.
Then choose your service and click "Try it out" , and then input text box for consumption. 
If inputs are required , enter your input data and click "Execute" button.


