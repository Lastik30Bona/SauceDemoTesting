# 🧪 SwagLabs Selenium UI Automation

This is a beginner-friendly automation framework for testing [saucedemo.com](https://www.saucedemo.com) using **Selenium WebDriver**, **C#**, and **NUnit**.

---

## ✅ Features

-  Login Test (Valid/Invalid credentials)
-  Inventory Page – Product visibility
-  Cart Page – Add to Cart
-  Checkout Page – Complete order flow
-  Hidden Menu – Logout
-  Data-driven testing with JSON
-  Page Object Model (POM) structure
-  BasePage & BaseTest abstraction


---

## 🧱 Technologies

- C# (.NET)
- Selenium WebDriver
- NUnit
- JSON for test data

---

## 📂 Project Structure

SwagLabsAutomation/
├── Helpers/
│   ├── LoginData.cs
│   └── TestDataLoader.cs
├── Pages/
│   ├── BasePage.cs
│   ├── LoginPage.cs
│   ├── InventoryPage.cs
│   ├── CartPage.cs
│   ├── CheckoutPage.cs
│   └── HiddenMenuPage.cs
├── TestData/
│   └── loginData.json
├── Tests/
│   ├── BaseTest.cs
│   ├── LoginTests.cs
│   ├── InventoryTests.cs
│   ├── CartTests.cs
│   ├── CheckoutTests.cs
│   └── HiddenMenuTests.cs
├── README.md


## 🧪 Test Enhancements (2025-06)

- ✅ Integrated JSON-based test data for login scenarios  
- ✅ Applied `TestCaseSource` for dynamic test input  
- 🔒 Disabled static login tests in favor of data-driven logic  
- ✔ Optimized WebDriver config (disabled Chrome password popup)  

---

## 💡 Notes

- Make sure `loginData.json` is set to `Copy if newer` in file properties.  
- Run tests via Test Explorer for best performance in Visual Studio.