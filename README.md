## I'm Sorry, I not familiar with nunit test. I've tried it and I need more time


# How to USE


## Install Postman

This tutorial uses Postman to test the web API.

- Install Postman 
              https://www.postman.com/
- Start the web app
- Start Postman 
- Disable SSL certificate verification 
- From File > Settings (General tab), disable SSL certificate verification
![DESIGN IMAGE](http://images.rizalresi.com/setting.png?raw=true)
## Test PostTodoItem with Postman

1 Create a new request.

2 Set the HTTP method to POST.
                
                https://localhost:{port}/api/TodoItems

3 Select the Body tab.

4 Select the raw radio button.

5 Set the type to JSON (application/json).

6 In the request body enter JSON for a to-do item

        {
          "name":"resi gautama",
          "DateTime":"2012-04-23T18:25:43.511Z",
          "Title":"Mr",
          "Description":"Im herro",
          "Complete": 50
         }

## ScreenShot 
# Create ToDo
![DESIGN IMAGE](http://images.rizalresi.com/post.png?raw=true)
# Get All Todo’s
![DESIGN IMAGE](http://images.rizalresi.com/getall.png?raw=true)
# Get Update Todo
![DESIGN IMAGE](http://images.rizalresi.com/put.png?raw=true)
# Get Specific Todo
![DESIGN IMAGE](http://images.rizalresi.com/get{id}.png?raw=true)
# Delete ToDo
![DESIGN IMAGE](http://images.rizalresi.com/Delete.png?raw=true)
![DESIGN IMAGE](http://images.rizalresi.com/show_get_delete.png?raw=true)

