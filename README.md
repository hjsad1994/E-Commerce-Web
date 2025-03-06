# E-Commerce Web Application

This is a full-featured e-commerce web application designed to allow users to browse products, make purchases, and interact with the system. The project leverages various modern technologies to provide a seamless and efficient shopping experience.

## Features

### Core Features:
1. **Login/Logout**  
   Users can log in and log out of their accounts.

2. **User Roles:**
    - **Customer**: Basic user with the ability to browse products, add items to the cart, and complete orders.
    - **Admin**: Manage the website, approve staff members, view orders, and manage inventory.
    - **Staff**: Assist customers and handle order fulfillment.

3. **Product Management:**
    - **View Product List**: Customers can see a list of all available products.
    - **Product Details**: Customers can view detailed information about each product.
    - **Add to Cart**: Users can add products to their shopping cart.
    - **Checkout & Payment**: Customers can complete their purchase. A confirmation email is sent to the customer upon successful payment.
    - **Search & Filter Products**: Allows users to search for products by name and filter them based on price.
    - **Comment and Rate Products**: Users can leave reviews and rate products with a star system.
    - **Add to Wishlist**: Users can mark products as favorites for future reference.
    
4. **User Registration**:  
   Users can register by providing the following details:
    - Full Name
    - Role (Customer or Staff)
    - Date of Birth
    - Email
    - Phone Number
    - Avatar Image  
   For **Staff**, registration must be approved by an Admin.

5. **Update Profile Information**:  
   Users can update their personal information like name, email, and profile picture.

6. **Notifications**:
    - **Staff**: Receive notifications for new orders made by customers.
    - **Customer**: Receive order status updates and notifications upon order confirmation.

7. **Customer Support**:  
   - **Email**: Direct communication with customers via email.
   - **Chat**: Real-time chat support to assist customers with their inquiries.

## Technical Stack

1. **Backend**:
   - **ASP.NET Core MVC**: Web framework for building dynamic web applications.
   - **Entity Framework**: ORM for interacting with the SQL database.
   - **LINQ**: Language Integrated Query for querying the database.
   
2. **Frontend**:
   - **HTML/CSS/JavaScript**: For structuring and styling the website.
   - **jQuery**: For simplifying JavaScript code and handling asynchronous requests.
   - **Bootstrap**: Frontend framework for responsive design.

3. **Database**:
   - **Microsoft SQL Server**: Relational database management system for storing user and product data.

## Installation

### Prerequisites:
- Install **Visual Studio 2022** or later with the ASP.NET Core workload.
- Install **SQL Server** or use **SQL Server Express** for the database.

### Steps:
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/e-commerce-web.git
