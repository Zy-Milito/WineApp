# WineApp

Small app created for my uni whose purpose is to manage the stock of a wine store.

***

##Endpoints
### User
- GET /api/User | Get a list of all the users registered in the app and their properties.
- POST /api/User | Register a new user.
### Wine
- GET /api/Wine | Get a list of all the registered wines and their characteristics.
- POST /api/Wine | Register a new wine.
- PUT /api/Wine/add/{wineName} | Add more stock to the specified wine.
- PUT /api/Wine/remove/{wineName} | Remove certain stock from the specified wine.
