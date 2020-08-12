# How to USE


## Install Postman

This tutorial uses Postman to test the web API.

- Install Postman 
- Start the web app
- Start Postman 
- Disable SSL certificate verification 
- From File > Settings (General tab), disable SSL certificate verification

## Test PostTodoItem with Postman

- Create a new request.

- Set the HTTP method to POST.

- Select the Body tab.

- Select the raw radio button.

- Set the type to JSON (application/json).

- In the request body enter JSON for a to-do item:
  {
  "name":"resi gautama",
  "DateTime":"2012-04-23T18:25:43.511Z",
  "Title":"Mr",
  "Description":"Im herro",
  "Complete": 50
}

4. MySql

        docker run --name mysql -d -p 3306:3306 --restart always -e MYSQL_ROOT_PASSWORD=1qazZAQ! mysql:5.7

## ScreenShot 
![DESIGN IMAGE](http://images.rizalresi.com/post.png?raw=true)
![DESIGN IMAGE](http://images.rizalresi.com/getall.png?raw=true)
![DESIGN IMAGE](http://images.rizalresi.com/put.png?raw=true)
![DESIGN IMAGE](http://images.rizalresi.com/get{id}.png?raw=true)
![DESIGN IMAGE](http://images.rizalresi.com/Delete.png?raw=true)
![DESIGN IMAGE](http://images.rizalresi.com/show_get_delete.png?raw=true)

