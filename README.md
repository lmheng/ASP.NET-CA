# ASP.NET-CA
This is a project done by our team for our ASP.NET module

As it is a team project, each of our members have been assigned to work on a certain aspect of the project, the portions that I was working on are:
1) Login functionality (without hashing for now as we have not covered this)
2) Logout
3) Session management
4) Past purchases and Activation codes generation
5) Partial HTML + CSS


Project Specifications

The objective of this CA project is create a Shopping Cart web application using .NET Core.

You can assume that the users who are purchasing have already registered with your system. You just need to provision a login screen for the user so that 
you know which users have purchased what items. Also, assume that all users’ credentials are stored in the database.

Remember to perform proper validation on users’ inputs and display appropriate error messages.

Once logged in, the user will be brought to the Gallery page to purchase.

Display the user’s name on the left and a link for him to logout of your system. There should be a Search bar for users to search the products he is looking for. 
Once he hit Enter, display the list of products that satisfy his Search string. Once he has cleared the Search bar, list all the products again.

If he clicks on My Purchases, he will be brought to My Purchases page to view all the purchases he has made.

When the user clicked on the “Add To Cart” button, increment the number beside the Cart icon. 
If the Cart is currently empty and he clicked on the same item twice, the number besides the Cart icon should be 2.
When he clicks on the Cart icon, display the products as shown in.

Allow him to change the quantity of each of his selected product and re-compute the Total amount on the top right. 
If he clicks Continue Shopping, brings him to the Gallery page. 

If he clicks on Checkout, we assume that the purchase has been successful and brings him to My Purchases pages. 
Each purchased product will have a unique activation code. If the user has purchased multiple copies of a product, 
he would have multiple activation codes. Display multiple activation codes with a combo box.
