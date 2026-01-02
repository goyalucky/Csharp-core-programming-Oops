# Csharp-core-programming-oops

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

---

### 🔹 `keywords` branch
This branch focuses on understanding and applying important **C# keywords** such as `static`, `this`, `readonly`, and the `is` operator through **real-world, object-oriented programs**.  
These programs help strengthen clarity on **shared data, object initialization, immutability, and type checking**.

#### 📁 Levels
- ## 📘 Level 01 - keywords practices
---

## 📝 Practice Programs

### 🏦 Bank Account System
- Create a `BankAccount` class to manage bank accounts.
- Use:
  - `static` variable `bankName` shared across all accounts.
  - `static` method `GetTotalAccounts()` to display total accounts.
  - `this` keyword to resolve ambiguity while initializing `AccountHolderName` and `AccountNumber`.
  - `readonly` variable `AccountNumber` to prevent modification after assignment.
  - `is` operator to verify if an object is a `BankAccount` before displaying details.

---

### 📚 Library Management System
- Create a `Book` class to manage library books.
- Use:
  - `static` variable `LibraryName` shared across all books.
  - `static` method `DisplayLibraryName()` to display library name.
  - `this` keyword to initialize `Title`, `Author`, and `ISBN`.
  - `readonly` variable `ISBN` to ensure book identity remains unchanged.
  - `is` operator to check if an object is a `Book` before displaying details.

---

### 🧑‍💼 Employee Management System
- Design an `Employee` class to manage employee records.
- Use:
  - `static` variable `CompanyName` common for all employees.
  - `static` method `DisplayTotalEmployees()` to show employee count.
  - `this` keyword to initialize `Name`, `Id`, and `Designation`.
  - `readonly` variable `Id` to prevent modification.
  - `is` operator to validate employee objects before printing details.

---

### 🛒 Shopping Cart System
- Create a `Product` class to manage shopping cart items.
- Use:
  - `static` variable `Discount` shared among all products.
  - `static` method `UpdateDiscount()` to modify discount percentage.
  - `this` keyword to initialize `ProductName`, `Price`, and `Quantity`.
  - `readonly` variable `ProductID` for unique product identification.
  - `is` operator to validate product objects before processing.

---

### 🎓 University Student Management
- Create a `Student` class to manage student records.
- Use:
  - `static` variable `UniversityName` shared by all students.
  - `static` method `DisplayTotalStudents()` to show enrollment count.
  - `this` keyword to initialize `Name`, `RollNumber`, and `Grade`.
  - `readonly` variable `RollNumber` to ensure immutability.
  - `is` operator to validate student objects before operations.

---

### 🚗 Vehicle Registration System
- Create a `Vehicle` class to manage vehicle registrations.
- Use:
  - `static` variable `RegistrationFee` common to all vehicles.
  - `static` method `UpdateRegistrationFee()` to modify the fee.
  - `this` keyword to initialize `OwnerName`, `VehicleType`, and `RegistrationNumber`.
  - `readonly` variable `RegistrationNumber` for unique identification.
  - `is` operator to verify vehicle objects before displaying details.

---

### 🏥 Hospital Management System
- Create a `Patient` class to manage hospital patient data.
- Use:
  - `static` variable `HospitalName` shared among all patients.
  - `static` method `GetTotalPatients()` to count admitted patients.
  - `this` keyword to initialize `Name`, `Age`, and `Ailment`.
  - `readonly` variable `PatientID` to uniquely identify patients.
  - `is` operator to validate patient objects before displaying details.

---

## 🎯 Learning Outcomes

- Understanding shared vs object-specific data using `static`
- Using `this` keyword to resolve naming conflicts
- Enforcing immutability with `readonly`
- Performing safe type checking using the `is` operator
- Applying C# keywords in real-world OOP scenarios

---

### 🔹 `📊diagrams` branch
This branch contains **UML diagrams** created to visually represent system design and object interactions for various problem statements.  
The diagrams help in understanding **class structure, object relationships, and execution flow** before implementation.

🛠 **Tool Used:** Lucidchart  
📐 **Diagram Types Covered:** Class Diagram, Object Diagram, Sequence Diagram

---

## 📘 Sample Problem 1: School Results Application

### 🧩 Class Diagram
**Classes Involved:**
- Student
- Subject
- GradeCalculator

**Relationships:**
- A `Student` has multiple `Subject` entries (**Aggregation**).
- `GradeCalculator` computes results for a `Student`.

---

### 🧱 Object Diagram
**Example Objects:**
- Student: `John`
- Subjects:
  - Maths → Marks: 90
  - Science → Marks: 85

---

### 🔄 Sequence Diagram
**Scenario:**
- A student requests their grade based on marks obtained in subjects.

**Actors:**
- Student
- GradeCalculator

**Flow:**
1. Student submits subject marks and request for grade calculation.
2. GradeCalculator processes marks.
3. Final grade is returned to the student.

---

## 📘 Sample Problem 2: Grocery Store Bill Generation Application

### 🧩 Class Diagram
**Classes Involved:**
- Customer
- Product
- BillGenerator

**Relationships:**
- A `Customer` purchases multiple `Product` items (**Composition**).
- `BillGenerator` calculates the total bill for the customer.

---

### 🧱 Object Diagram
**Example Objects:**
- Customer: `Alice`
- Products:
  - Apples → 2 kg @ $3/kg
  - Milk → 1 liter @ $2/liter

---

### 🔄 Sequence Diagram
**Scenario:**
- A customer checks out at the grocery store and receives the final bill.

**Actors:**
- Customer
- BillGenerator

**Flow:**
1. Customer selects products and then checkout.
2. BillGenerator calculates item-wise cost.
3. Total bill amount is generated and displayed.

---

## 🎯 Learning Outcomes

- Understanding system design using UML diagrams
- Visualizing object relationships and lifecycles
- Learning aggregation vs composition
- Mapping real-world scenarios to class structures
- Improving design clarity before coding

---

### 🔹 `object-modelling` branch
This branch focuses on **object-oriented design and modeling real-world systems** using core OOP relationships such as **Association, Aggregation, and Composition**.  
The problems emphasize how objects interact, depend on each other, and communicate within a system.

---

## 📝 Practice Problems

- **Library and Books (Aggregation)**  
  Model a library that contains multiple books where books can exist independently.

- **Bank and Account Holders (Association)**  
  Represent the association between a bank and its customers who open and manage accounts.

- **Company and Departments (Composition)**  
  Design a company where departments and employees cannot exist without the company.

- **School, Students, and Courses (Association & Aggregation)**  
  Model a school system where students enroll in multiple courses using many-to-many relationships.

- **University, Faculties, and Departments (Composition & Aggregation)**  
  Create a university where departments depend on it, while faculty members exist independently.

- **Hospital, Doctors, and Patients (Association & Communication)**  
  Represent doctor–patient consultations with multiple doctors and patients interacting.

- **E-Commerce Platform (Customers, Orders, and Products)**  
  Design an e-commerce system where customers place orders and orders aggregate products.

---

## 🎯 Learning Outcomes

- Understand and apply **association, aggregation, and composition**
- Model **real-world object relationships**
- Practice **object communication through methods**
- Improve **system design and UML understanding**
- Strengthen **object-oriented thinking**

---

---

### 🔹 `inheritance` Branch
This branch focuses on **Inheritance in Object-Oriented Programming (OOP)** using C#. It demonstrates how classes can **reuse, extend, and override behavior** through **single, hierarchical, multilevel, and hybrid inheritance**. 
The practice problems emphasize core OOP concepts such as **polymorphism, method overriding, base–derived class relationships, and interface-based design**.

---

## 📝 Practice Problems

### 🔸 Hierarchical Inheritance

- **Animal Hierarchy**  
  Create an `Animal` base class with `Dog`, `Cat`, and `Bird` subclasses that override
  behavior to demonstrate polymorphism.

- **Employee Management System**  
  Model different employee types (`Manager`, `Developer`, `Intern`) inheriting from a
  common `Employee` class with role-specific attributes and behaviors.

- **Vehicle and Transport System**  
  Design a `Vehicle` hierarchy (`Car`, `Truck`, `Motorcycle`) and demonstrate dynamic
  method dispatch using polymorphism.

- **Bank Account Types System**  
  Model a banking system where `SavingsAccount`, `CheckingAccount`, and
  `FixedDepositAccount` inherit from a common `BankAccount` superclass.

---

### 🔸 Single Inheritance

- **Library Management with Books and Authors**  
  Implement single inheritance where `Author` extends `Book` and displays combined
  book and author information.

---

### 🔸 Multilevel Inheritance

- **Online Retail Order Management**  
  Build a multilevel hierarchy (`Order → ShippedOrder → DeliveredOrder`) to represent
  the order lifecycle and status tracking.

---

### 🔸 Hybrid Inheritance (Using Interfaces)

- **Restaurant Management System**  
  Simulate hybrid inheritance using a `Person` superclass and a `Worker` interface
  implemented by `Chef` and `Waiter` classes.

---

## 🎯 Learning Outcomes

- Understand **code reuse and extensibility using inheritance**
- Apply **method overriding and runtime polymorphism**
- Design **single, hierarchical, and multilevel class structures**
- Simulate **multiple inheritance using interfaces**
- Model **real-world problems using OOP principles**

---

---

### 🔹 `oops-pillars` Branch
This branch focuses on mastering the **four pillars of Object-Oriented Programming**: **Abstraction, Encapsulation, Inheritance, and Polymorphism** using C#.
The programs are designed around **real-world systems** and demonstrate how abstract classes, interfaces, access control, and runtime polymorphism work together to build scalable and maintainable applications.

---

## 📝 Practice Problems

- **Employee Management System**  
  Implements abstraction using an abstract `Employee` class, encapsulation through
  properties, interfaces for department handling, and polymorphism to process different
  employee types dynamically.

- **E-Commerce Platform**  
  Models products using abstract classes and interfaces to calculate tax and discounts,
  showcasing polymorphism in final price computation across product categories.

- **Vehicle Rental System**  
  Demonstrates abstract vehicle pricing logic, insurance handling via interfaces, and
  polymorphism to calculate rental and insurance costs for different vehicle types.

- **Banking System**  
  Uses abstract bank accounts with secure balance handling, interface-based loan features,
  and polymorphism for interest calculation across account types.

- **Library Management System**  
  Applies abstraction to library items, encapsulation for borrower data, interfaces for
  reservations, and polymorphism to manage books, magazines, and DVDs uniformly.

- **Online Food Delivery System**  
  Models food items using abstraction and interfaces for discounts, allowing dynamic
  handling of veg and non-veg items through polymorphism.

- **Hospital Patient Management System**  
  Implements abstraction for patient billing, encapsulation for medical records, interfaces
  for record management, and polymorphism to handle inpatient and outpatient workflows.

---

## 🎯 Learning Outcomes

- Apply all **four OOP pillars** cohesively in real-world scenarios
- Design systems using **abstract classes and interfaces**
- Secure data using **encapsulation and access modifiers**
- Implement **runtime polymorphism** using base-class references
- Build **scalable and maintainable object-oriented applications**

---

## 👤 Author
**Lucky Goyal**  
B.Tech CSE (Artificial Intelligence and Machine Learning)  
