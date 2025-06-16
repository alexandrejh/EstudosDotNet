# EstudosDotNet
Repository to some study projects with .Net and C#

# About the project

## This is a Smart Orders Platform

It's a Modular E-Commerce System

🧩 Concept:
A lightweight but modular order management system that simulates a small-scale e-commerce backend. It includes user management, product catalog, order processing, and integration with third-party systems — all via microservices, event-driven architecture, and cloud-native tools.

🏗️ Technologies we will use

| Component                | Purpose                                                               |
| ------------------------ | --------------------------------------------------------------------- |
| **.NET 9 + Aspire**      | Build and orchestrate microservices, add service discovery, dashboard |
| **EF Core + SQL Server** | Data persistence in each microservice                                 |
| **Azure Functions**      | Background jobs, order validation, sending emails, billing, etc.      |
| **RabbitMQ / Kafka**     | Event-driven architecture — publish/subscribe for decoupled services  |
| **Microservices**        | Separate services: Users, Orders, Products, Payments, etc.            |
| **Minimal APIs**         | Use them for internal microservices' HTTP endpoints                   |


🧱 Example Microservices

1. UserService
    * Registers and manages users
    * SQL Server + EF Core
1. ProductService
    * Manages product catalog and inventory
    * Exposes APIs to list/search products
1. OrderService
    * Accepts orders
    * Publishes OrderCreated event to message bus
1. InventoryService
    * Listens to OrderCreated, reduces stock
    * Publishes InventoryUpdated
1. BillingService (Azure Function)
    * Triggered by OrderCreated, processes payments
1. NotificationService (Azure Function)
    * Sends email confirmations when order is completed

📬 Event Flow (RabbitMQ or Kafka)  
> [OrderService] --> publish: OrderCreated -->  
> [InventoryService], [BillingService], [NotificationService] (subscribe)

This is for learn about **event-driven architecture**, **retry logic**, and **async decoupling**.

🌐 Add-ons
* 🧪 Unit tests with xUnit + FluentAssertions + TestContainers
* 🔐 Add authentication using OAuth IdentityServer

🌐 Optional Add-ons
* ✅ Admin UI (Blazor or React) for managing products and viewing orders
* 📊 Add metrics and observability with OpenTelemetry

🚀 What we can demonstrate with this idea:
* Realistic use case with scalable complexity
* Demonstrates orchestration via Aspire
* Forces you to build loosely coupled services with events
* Combines both HTTP-based communication and message-driven design

# Coding

## Projects

* SmartOrders.IdentityServer
* SmartOrders.UserService
* SmartOrders.ProductService
* SmartOrders.OrderService
* SmartOrders.InventoryService
* SmartOrders.BillingService
* SmartOrders.NotificationService
* SmartOrders.Common
* SmartOrders.Tests

# Detailing projects

* SmartOrders.IdentityServer

> Service responsible for authentication with OAuth 2.  
> This service subscribes to UserRegistered and UserChanged events to update database with the user auth data.  
> The login endpoint validates UserName and Password and returns a Bearer token

* SmartOrders.UserService

> Service responsible for register and manage users.
> This service publishes UserRegistered and UserChanged events

* SmartOrders.ProductService

> Manages product catalog and inventory
> Exposes APIs to list/search products
> Exposes API to increase stock of products

* SmartOrders.OrderService

> Accepts orders
> Publishes OrderCreated event to message bus
> Exposes APIs to Create, List and Cancel orders (only for Authenticated users)
> Consumes ProductService API for validate products and stock

* SmartOrders.InventoryService

> Listens to OrderCreated, reduces stock
> Publishes InventoryUpdated
> Future idea -> Publish low stock event (When product stock reaches the minimum configured)

* SmartOrders.BillingService

> Triggered by OrderCreated, processes payments
> Publishes PaymentCompleted event

* SmartOrders.NotificationService

> Sends email notifications (for example Order created, payment completed)

* SmartOrders.Common

> Common features, like Middlewares, OAuth validation for endpoints

* SmartOrders.Tests

> Unit and Integration tests
