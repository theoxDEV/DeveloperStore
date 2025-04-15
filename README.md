🧪 Developer Evaluation Project — Sales API
This project is part of a technical assessment and consists of building a complete Sales API using:

ASP.NET Core 8

DDD (Domain-Driven Design)

CQRS (Command and Query Responsibility Segregation)

EF Core + PostgreSQL

Docker Compose

Unit Testing with xUnit + Moq

📦 Features
The API supports full CRUD operations for sales and includes:

✅ Sale number and date

✅ Customer and branch (external IDs + denormalized names)

✅ Product list with quantity, unit price, discounts, and item totals

✅ Total sale amount

✅ Sale cancellation

✅ Sale item cancellation

✅ Event logs (SaleCreated, SaleCancelled, ItemCancelled)

✅ Validation rules and business logic

✅ Unit tests with full coverage

⚙️ Business Rules
🔸 4+ items → 10% discount

🔸 10–20 items → 20% discount

🔸 More than 20 items → ❌ not allowed

🔸 Less than 4 items → ❌ no discount

These rules are applied at the domain layer (Sale → AddItem).

🚀 How to Run
🔧 Requirements
.NET 8 SDK

Docker + Docker Compose

Any REST client (Postman, curl, etc.)

▶️ Running the project
bash
Copiar
docker-compose up --build -d
📬 API URL
bash
Copiar
https://localhost:8081/swagger
Swagger UI will be available at https://localhost:8081/swagger.

🧪 Testing
To run unit tests:

bash
Copiar
dotnet test tests/Ambev.DeveloperEvaluation.Tests.Unit
Tests include:

CreateSaleHandler

UpdateSaleHandler

DeleteSaleHandler

CancelSaleHandler

GetSaleByIdHandler

GetAllSalesHandler

Business rules validation

🗃️ Project Structure
css
Copiar
src/
├── WebApi               → HTTP Controllers, DI, Program.cs
├── Application          → CQRS Handlers, Commands, Responses
├── Domain               → Entities, Interfaces, Business logic
├── ORM                  → DbContext, Mappings, Migrations

tests/
└── Tests.Unit           → xUnit tests for all application use cases
🧾 Sample Payloads
➕ Create Sale (POST /api/sales)
json
Copiar
{
  "customerId": "11111111-1111-1111-1111-111111111111",
  "customerName": "Customer A",
  "branchId": "22222222-2222-2222-2222-222222222222",
  "branchName": "Main Branch",
  "items": [
    {
      "description": "Mouse Gamer",
      "quantity": 5,
      "price": 100
    }
  ]
}
✅ Expected discount: 10%, total = 5 x 100 x 0.9 = 450
📌 Notes
Discounts are not passed from the client — they are calculated in the domain logic.

Sale numbers are auto-generated in the format SALE-XXXXXX.

Items cannot exceed 20 units or be less than 1.

Logging is added for SaleCreated, SaleCancelled, and ItemCancelled events.

👨‍💻 Author
Made with ❤️ for the Developer Evaluation.
Feel free to contact me if you have any questions.
