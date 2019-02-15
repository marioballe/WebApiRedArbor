# WebApiRedArbor
Test técnico de selección para la empresa Redarbor. Se trata de una `WebAPI con arquitectura MVC` que accede a base de datos utilizando `ADO`

## Llamadas de la API
**GET**
``` 
Route: /api/redarbor/GetAll
Description: Get all employees items 
Request body: None 	
Response body: Array of employee items 
```

**GET**
``` 
Route: /api/redarbor/{id} 
Description: Get an item by ID 
Request body: None 	
Response body: Employee item 
```

**POST**
``` 
Route: /api/redarbor
Description: Add a new item 
Request body: Employee item 	
Response body: Employee item 
```
**POST**
``` 
Route: /api/redarbor/{id}
Description: Update an existing item  
Request body: Employee item 	
Response body: None
```
**DELETE**
``` 
Route: /api/redarbor/{id}
Description: Delete an item 
Request body: None	
Response body: None
```

## Employee (Ejemplo)
```js
{ 
 "CompanyId": 1, 
 "CreatedOn": "2000-01-01 00:00:00", 
 "DeletedOn": "2000-01-01 00:00:00", 
  "Email": "test1@test.test.tmp", 
 "Fax": "000.000.000", 
 "Name": "test1", 
 "Lastlogin": "2000-01-01 00:00:00", 
 "Password":  "test",	 
 "PortalId": 1, 
 "RoleId":  1 , 
 "StatusId": 1, 
 "Telephone":  "000.000.000",	 
 "UpdatedOn": "2000-01-01 00:00:00", 
 "Username": "test1" 
} 
```

## Contenido del proyecto

* Solución del proyecto - *Codigo fuente de la API*
* Carpeta Test - *Proyecto de Postman listo para importar*
* Carpeta Scripts - *Scripts necesarios para crear la tabla en la BD*
