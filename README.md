# _Vendors and Orders_

#### _A program created to practice the MVC model in ASP.NET 10/17/2019_

#### By _Zach Krogh_

## Description

_This web application allows the user to create vendors and then, within those vendors, create lists of orders._

## Setup/Installation Requirements

* _Install dotnet core._
* _Download all files into the same directory and run "dotnet run"_

## Project Specifications

* _The user can create a vendor._
  * _input: name:"Bob's Pizza" description:"Pizza Shop"_
  * _output: none (both are saved to variables)_
  * _description: This is the most basic requirement of the program, allowing the user to create a vendor._
* _The user can create an Order within a vendor._
  * _input: title: "pizza order" description:"a lot of pizza" price:"100" date:"10/17/2019"_
  * _output: none (everything saved to variables)_
  * _description: The next simplest behavior, the user can create an order within a vendor._
* _The user can view details of an order._
  * _input: Navigate to a vendor and then an order._
  * _output: The order details and vendor name are displayed._
  * _description: Ensure the user can view order details._
* _The user can delete a vendor._
  * _input: Navigate to a vendor and click delete, then confirm the delete._
  * _output: The vendor is no longer accessible on the vendors list._
  * _description: Ensure the user can delete a vendor._

## Known Bugs

* _If a vendor is deleted, it's orders will remain in the _instances list of orders and still be accessible via URL manipulation but not by conventional means._

## Support and contact details

_contact: zakrogh@gmail.com_

## Technologies Used

_C#, ASP.NET MVC, Razor, HTML, CSS, Bootstrap_

### License

*MIT License*

Copyright (c) 2019 **_Zach Krogh_**
