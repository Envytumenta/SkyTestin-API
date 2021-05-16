# SkyTestin-API
This is a sky test project for API automation
Testing API commands using mockapi to check valid response 200 (GET)
Using C#
Run test using specFlow and RestSharp test framework to assert http response either pass or fail. 
While carrying out a manaul testing on Postman with the endpoints given to me i found a few bugs which i think its worth mentioning. As per the actual result, attempting a POST,PUT or DELETE should returned "404". But as per the actual result, POST returned "404", PUT returned "400" and DELETE returned "400" for the list of articles endpoint. POST returned "400",PUT returned "404" and DELETE returned "404" for the single alticle endpoint.
