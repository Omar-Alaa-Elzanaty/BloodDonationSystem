# BloodDonationSystem
## What was my motivation?
  I learned some of programming basics and i try to apply some of it.
## What I learned ?
 - manage a project and create it from scratch.
 - Apply Design pattern.
 - Dealing with git & Github.

## What do you need to run the project?
- At least .Net6 to can run this project
- Windows form application package 
- To modify UML Digram you will need to install [Umlet](https://www.umlet.com/).
- Get Msql 
- Run file DBcreation.sql 

## Used Tools:
- c#
- Msql
- Windows Forms
- Design pattern
- Object orianted programming
- Open closed principle <sup>(OCP)</sup> 

# System Analysis:

**Blood Donation system was created to connect between the donor and organizations.Any person want to 
donate can get account on system and donating blood.Any organization can start recieving donations
by regitser in the system and getreport about all amount and types of bloods it recieve.
Admin has permission to Add,Delete,Remove any person or organization on the system**

## Actors:
1- person
   - can donate with blood :frowning_man:
   - can show his donation history.
  
2- organization :drop_of_blood:
   - can show it's Donation history.
   - can know amount of diff types of bloods it's has.
    
3- Admin  ***not implement open as issue*** :warning:
   -  can make any of CRUD operations on Any of accounts.

## preconditions:
- Many persons can register at the same time.
- Many organizations can register at the same time.
- Many Admins can register on the system.
- one admin can sign in same time.
- no one can donate more than 1 time in the same day.

# system Design:
- **UML Classes Digramn:**
![UML](https://user-images.githubusercontent.com/94639386/232314106-8b8c37c5-a16b-445e-bb79-74e263415b38.PNG)
 -  Using strategy design pattern with signup.
 -  I didn't make startegy pattern to login as login auto detect type of account by username and pass but sign up user should detect type of account.
- **Database Digram:**
![DB Digram](https://user-images.githubusercontent.com/94639386/232314375-f0a92946-213f-48ac-9602-72637a3aa908.PNG)

## Contribution:
- Make your Fork and start your custom edit.
- I will let some tasks if you like to contribute or training.
- you can also modify any bugs ~~in case you found~~.
- Open issues and select easiest one to you and start your contribute 

## MIT License

Copyright (c) [year] [fullname]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
