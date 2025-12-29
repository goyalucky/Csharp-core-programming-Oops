# csharp-core-programming-oops

This repository focuses on **Object-Oriented Programming (OOP) concepts in C#**, covering beginner to intermediate level practice problems. The goal of this project is to strengthen core OOP fundamentals through structured, hands-on coding examples.

---

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio
- **Version Control:** Git & GitHub

---

## ✨ Features
- Implementation of core OOP concepts:
  - Classes & Objects  
  - Encapsulation  
  - Inheritance  
  - Polymorphism  
  - Abstraction  
- Concept-wise and level-wise learning structure  
- Separate branches for each OOP topic  
- Beginner-friendly examples with clean and readable code  
- Emphasis on reusable code and design principles 

---

## 📂 Branch Structure

### 🔹 `🧩class-and-object` branch
The **class-and-object branch** focuses on the **fundamentals of Object-Oriented Programming (OOP)** in C#.  
This branch introduces how to **define classes, create objects, use attributes (fields), and implement methods**, which form the foundation of scalable and maintainable C# applications.

#### 📁 Levels
- ## 📘 Level 01 – Class and Object Fundamentals
  This level emphasizes **basic class design**, object creation, and method implementation using real-world examples.

---

### 📝 Practice Problems

- **Program to Display Employee Details**  
  Create an `Employee` class with attributes such as `name`, `id`, and `salary`.  
  Implement a method to display employee details.

- **Program to Compute Area of a Circle**  
  Create a `Circle` class with an attribute `radius`.  
  Add methods to calculate and display the **area** and **circumference** of the circle.

- **Program to Handle Book Details**  
  Create a `Book` class with attributes like `title`, `author`, and `price`.  
  Implement a method to display book information.

---

### 🎯 Learning Outcomes

- Understanding classes and objects in C#
- Defining attributes (fields) and methods
- Creating and using object instances
- Applying OOP concepts to real-world problems
- Building a foundation for advanced OOP topics

---

### 🔹 `constructors` branch
This branch focuses on **constructors in C#**, covering **default constructors, parameterized constructors, constructor chaining, copy constructors**, and their usage in real-world scenarios.  
It also introduces **instance vs class members** and **access modifiers**, strengthening core Object-Oriented Programming concepts.

#### 📁 Levels
- ## 📘 Level 01 - OOPs Fundamentals

---

- ## 📘 Part 1 – Constructor Fundamentals
  These programs emphasize creating and initializing objects using different types of constructors.

### 📝 Practice Programs

- **Book Class**
  - Create a `Book` class with attributes `title`, `author`, and `price`.
  - Implement both **default** and **parameterized constructors**.

- **Circle Class**
  - Create a `Circle` class with a `radius` attribute.
  - Use **constructor chaining** to initialize radius using default and user-provided values.

- **Person Class (Copy Constructor)**
  - Create a `Person` class with a **copy constructor** that clones another person's attributes.

- **Hotel Booking System**
  - Create a `HotelBooking` class with attributes `guestName`, `roomType`, and `nights`.
  - Use **default, parameterized, and copy constructors** to initialize booking details.

- **Library Book System**
  - Create a `Book` class with attributes `title`, `author`, `price`, and `availability`.
  - Implement a `BorrowBook()` method to update availability.

- **Car Rental System**
  - Create a `CarRental` class with attributes `customerName`, `carModel`, and `rentalDays`.
  - Add constructors to initialize details and calculate the **total rental cost**.

---

- ## 📘 Part 2 – Instance vs Class Variables and Methods
  This section demonstrates the difference between **instance members** and **static (class) members**.

### 📝 Practice Programs

- **Product Inventory**
  - Instance Variables: `productName`, `price`
  - Class Variable: `totalProducts`
  - Methods:
    - `DisplayProductDetails()` – instance method
    - `DisplayTotalProducts()` – class (static) method

- **Online Course Management**
  - Instance Variables: `courseName`, `duration`, `fee`
  - Class Variable: `instituteName`
  - Methods:
    - `DisplayCourseDetails()` – instance method
    - `UpdateInstituteName()` – class (static) method

- **Vehicle Registration**
  - Instance Variables: `ownerName`, `vehicleType`
  - Class Variable: `registrationFee`
  - Methods:
    - `DisplayVehicleDetails()` – instance method
    - `UpdateRegistrationFee()` – class (static) method

---

- ## 📘 Part 3 – Access Modifiers
  This section focuses on **encapsulation and access control** using `public`, `protected`, and `private` members.

### 📝 Practice Programs

- **University Management System**
  - `Student` class:
    - `rollNumber` (public)
    - `name` (protected)
    - `CGPA` (private)
  - Implement public methods to access and modify CGPA.
  - Create a `PostgraduateStudent` subclass to demonstrate protected access.

- **Book Library System**
  - `Book` class:
    - `ISBN` (public)
    - `title` (protected)
    - `author` (private)
  - Implement getter/setter for author.
  - Create an `EBook` subclass to access ISBN and title.

- **Bank Account Management**
  - `BankAccount` class:
    - `accountNumber` (public)
    - `accountHolder` (protected)
    - `balance` (private)
  - Implement public methods to modify balance.
  - Create a `SavingsAccount` subclass.

- **Employee Records**
  - `Employee` class:
    - `employeeID` (public)
    - `department` (protected)
    - `salary` (private)
  - Implement a public method to modify salary.
  - Create a `Manager` subclass to access employeeID and department.

---

## 🎯 Learning Outcomes

- Understanding different types of constructors
- Applying constructor chaining and copy constructors
- Differentiating instance and static members
- Implementing encapsulation using access modifiers
- Writing clean, modular, and maintainable OOP-based C# code

---

## 👤 Author
**Lucky Goyal**  
B.Tech CSE (Artificial Intelligence and Machine Learning)  
