# InventoryHub

## 📌 Overview
InventoryHub is a full-stack application built with **Blazor WebAssembly (ClientApp)** and **ASP.NET Core Minimal API (ServerApp)**.  
The project demonstrates seamless communication between front-end and back-end, proper JSON structuring, debugging integration issues, and performance optimization.

---

## 🚀 Project Structure
- **ClientApp** → Blazor front-end
  - Pages: `FetchProducts.razor`, `Counter.razor`, `Weather.razor`, etc.
  - Fetches product data from the back-end API and displays it in the UI.
- **ServerApp** → Minimal API back-end
  - Endpoint: `/api/productlist`
  - Returns product data in JSON format, including nested category objects.

---

## 🛠 Activities Completed
### Activity 1: Initial Integration
- Implemented API calls in Blazor to fetch product data.
- Established communication between ClientApp and ServerApp.

### Activity 2: Debugging Integration Issues
- Fixed incorrect API route (`/api/products` → `/api/productlist`).
- Resolved CORS errors by enabling `AllowAnyOrigin`, `AllowAnyMethod`, `AllowAnyHeader`.
- Added error handling for malformed JSON responses.

### Activity 3: JSON Structuring
- Modified back-end API to return standardized JSON with nested `Category` objects.
- Updated front-end `Product` and `Category` classes to match the JSON structure.

### Activity 4: Optimization
- Reduced redundant API calls in the front-end.
- Implemented caching in the back-end to minimize server load.
- Refactored repetitive code for better performance.

---

## ✅ Testing
- Tested API responses using Postman (`http://localhost:5118/api/productlist`).
- Verified front-end displays product list correctly at `/fetchproducts`.
- Confirmed no CORS or JSON-related errors in browser console.

---

## 📖 Reflective Summary
Microsoft Copilot assisted throughout the project:
- **Integration Code** → Suggested clean API call patterns and Blazor component structures.
- **Debugging** → Helped identify mismatched routes, CORS issues, and JSON deserialization errors.
- **JSON Structuring** → Generated nested JSON examples and guided front-end model alignment.
- **Optimization** → Recommended caching strategies and refactoring to reduce redundancy.

### Challenges
- Handling CORS restrictions between different ports.
- Ensuring JSON structure matched front-end models.
- Debugging silent failures when product list did not render.

### Learnings
- Copilot is highly effective for generating boilerplate code quickly.
- It accelerates debugging by pointing out common pitfalls (routes, CORS, JSON mapping).
- Using Copilot in full-stack development improves productivity and ensures industry-standard practices.

---

## 📂 How to Run
1. Start **ServerApp** → runs on `http://localhost:5118`.
2. Start **ClientApp** → runs on `http://localhost:5263`.
3. Navigate to `http://localhost:5263/fetchproducts` to view product list.

---

## 📌 Next Steps
- Deploy InventoryHub to GitHub for peer review.
- Expand functionality with database integration.
- Enhance UI with category-based filtering.

