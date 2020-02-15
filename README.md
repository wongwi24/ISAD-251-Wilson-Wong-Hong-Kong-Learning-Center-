# ISAD-251-Wilson-Wong-Hong-Kong-Learning-Center-
ISAD251 Plymouth Uni Databse Assignment by Wilson Wong from Hong Kong

# Application Fact Sheet

Youtube video Link: https://www.youtube.com/watch?v=PqR3UkVjZpo
API: http://localhost:PortNumber/api/Foods

login name and password for the app:
(Admin) name= admin@outlook.com pwd= Admin12345.(not to leave out dot in the end)
(Other Users) name= guest@outlook.com pwd= Ab12345.  name= guest1@outlook.com pwd= Ab12345.

<strong>Database .mdf file is inside the App_Data folder of the Project folder.</strong>

# How to use
This is a web application for an imaginary Tea house which allows customers to order drinks and foods and is a minimum viable product that is not recommended to use it in real life. The application and the database is not currently host in any external server but it has been tested to run on local machine. 

As Customers: To start ordering, customers can either click on Food tab in the header or Order Now button in the front page. Inside the Food menu, the customers can add items to cart by clicking on the plus sign next to the target item. A popup window will ask if you want to check out. Click close to continue shopping. When checking out, the customers have to sign in their account if they have one or else register a new account. The cart items will migrate to the new cart of the login account. Fill in the Contact info and proceed then the order is completed.  

As an Admin: First login the admin account. The Order tab in the header will show all the orders. Clicking into the details link will display the ordering details include a break down of what items the customers have ordered. The admin can also edit delete or create new items inside the Food page. There are two ways to withdraw an item from sale. One way is to delete it from database. Another way is to uncheck IsVisible checkbox inside edit page.

# Key Features

A shopping cart function allowing customers to add or remove item before checkout.

Admin can create, update, delete or hide the items.

Admin can view the order history and details.

Basic security features with simple authentication using email and password.

Searching, Paging and sorting functions for the food menu.
# ScreenShots

<strong>Register page</strong>
<img src="/PrototypePageImages/Register.png">

<strong>Login page</strong>
<img src="/PrototypePageImages/Login.png">

<strong>Admin Main page</strong>
<img src="/PrototypePageImages/AdminMain.png">

<strong>Food Menu Page</strong>
<img src="/PrototypePageImages/ProductPageAdmin.png">

<strong>Create Item Page</strong>
<img src="/PrototypePageImages/CreateProduct.png">

<strong>Edit Item Page</strong>
<img src="/PrototypePageImages/EditProduct.png">

<strong>Delete Item Page</strong>
<img src="/PrototypePageImages/DeleteProduct.png">

<strong>Order History</strong>
<img src="/PrototypePageImages/Order.png">

<strong>Details of particular order</strong>
<img src="/PrototypePageImages/OrderDetails.png">

<strong>Category Page</strong>
<img src="/PrototypePageImages/CategoryPage.png">

<strong>Customer Main Page</strong>
<img src="/PrototypePageImages/CustomerMain.png">

<strong>Popup Message When User Click Add to Cart Button</strong>
<img src="/PrototypePageImages/ContinueOrCheckout.png">

<strong>ShoppingCart</strong>
<img src="/PrototypePageImages/Cart.png">

<strong>Fill in Personal Info After Clicking Checkout in Cart</strong>
<img src="/PrototypePageImages/CheckoutForm.png">

<strong>Complete Page Shown When Order Complete</strong>
<img src="/PrototypePageImages/CompletePage.png">

# Browser Compatibility Test

<strong>Google Chrome</strong>
<img src="/BrowserCompatibility/GoogleChrome.png">

<strong>Internet Explorer 11</strong>
<img src="/BrowserCompatibility/GoogleChrome.png">

<strong>Unfortunately Firefox browser is not working on my computer so I have no chance to test it</strong>
