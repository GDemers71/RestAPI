# Context WEEK 8

For this week's project, I had to redo most of what we learned in the past weeks and put it into practice. I had to create 3 new REST API requests (1 GET 2 PUT). I also had to create a new table in mySQL called "interventions", along with that table I created a new HTML page with a new form to fill the new table "interventions". Lastly I had to create new freshdesk tickets with the information that's filled in the new form. 

Link to my Website => http://philippethivierge.xyz/

Link to my Video => https://youtu.be/tKcguiwSwcM

# JSON link for our collection of requests for Postman
```
https://www.getpostman.com/collections/a593faef0d77b1078035
```
---

# The following example shows REST API requests with Postman:

## We start by requesting all interventions with the status "Pending" and NO start_date: 

<img width="1375" alt="image" src="https://user-images.githubusercontent.com/105597570/181509057-7cac4011-7e55-4dc9-a43a-c129865fbb4e.png">

<img width="1241" alt="image" src="https://user-images.githubusercontent.com/105597570/181508602-92cee764-3edb-4aad-8740-2a5bfca6c51b.png">

## For this exemple we'll use the intervention 2, let's add a start_date and change the status to "InProgress" ( If it worked, you should see the :

<img width="1254" alt="image" src="https://user-images.githubusercontent.com/105597570/181508931-2038ca79-5d0e-4ea6-802d-743ae478a0c8.png">

<img width="1375" alt="image" src="https://user-images.githubusercontent.com/105597570/181509145-d14bdf26-e042-45b2-9f09-579324dbc1fa.png">

## We then do the first request again to make sure it worked: 

<img width="1301" alt="image" src="https://user-images.githubusercontent.com/105597570/181511338-a1605c9d-e05a-480b-af0f-aac77690e161.png">

#### As you can see the intervention 2 is gone because it no longer fits the requirements from the first request.

