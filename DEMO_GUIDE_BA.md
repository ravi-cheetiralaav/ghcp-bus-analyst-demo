# GitHub Copilot Demo Guide - Business Analyst (Sarah)

## Persona: Sarah - Business Analyst

**Scenario Overview:**  
Sarah is a business analyst working with an existing VB.NET and C# codebase (Expense Tracker application). She needs to understand how the code functions in order to help design changes and provide documentation to the product team. To achieve this, Sarah plans to add comments and generate documentation for the legacy code.

---

## Demo Overview

This demo showcases GitHub Copilot's capabilities in business analysis and application modernization scenarios. The ExpenseTracker application serves as a practical example for demonstrating various AI-assisted analysis and modernization techniques.

### Available Documents
- **ExpenseTracker_Modernization_Proposal.md**: Comprehensive modernization design document for converting the VB.NET desktop application to C# ASP.NET Core web application

---

## Prerequisites

- GitHub Copilot enabled in VS Code
- Expense Tracker VB.NET project open in VS Code
- Familiarity with VS Code and GitHub Copilot Chat

---

## Part 1: Adding Comments to Code (Documenting Methods & Functions)

### Step 1.1: Add Documentation to AuthenticationService

**File to Open:** `ExpenseTracker/Services/AuthenticationService.vb`

**Prompt for Copilot Chat:**
```
Add  documentation comments to all public methods in this file. Include:
- Summary of what each method does
- Parameter descriptions
- Return value descriptions
- Example usage where helpful
```

**Expected Outcome:**
- doc comments (`'''`) added above each method
- Clear explanations of Register, Login, ChangePassword methods
- Parameter and return type documentation

**Demo Talking Points:**
- "As a BA, I need to understand what each method does without diving deep into implementation"
- "Copilot generates standard  documentation that developers and tools can use"
- "This helps me create requirements and explain functionality to stakeholders"

---

### Step 1.2: Document Complex Business Logic in ExpenseService

**File to Open:** `ExpenseTracker/Services/ExpenseService.vb`

**Prompt for Copilot Chat:**
```
Add detailed comments explaining the recurring expense logic in the GetExpensesWithRecurring method. Help non-developers understand:
- What recurring expenses are
- How they're expanded
- Why we filter by date ranges
```

**Expected Outcome:**
- Inline comments explaining the business logic
- Clear explanation of recurring vs. one-time expenses
- Documentation of date filtering logic

**Demo Talking Points:**
- "This recurring expense logic is complex - I need to explain it to the product team"
- "Copilot helps me add business-focused comments, not just technical ones"
- "Now I can create user stories based on this understanding"

---

## Part 2: Creating Non-Technical Documentation

### Step 2.1: Document Business Rules and Logic

**Prompt for Copilot Chat:**
```
Analyze the ExpenseTracker codebase and create a "Business Rules" document that lists:
- User authentication rules (password requirements, username constraints)
- Expense entry rules (required fields, data validation)
- Recurring expense rules (frequencies, date ranges)
- Multi-currency support rules
- Tax deduction tracking rules
- Financial year calculation rules

Write this for a business analyst or product manager, not a developer.
```

**Expected Outcome:**
- Clear business rules extracted from code
- Easy-to-understand rule descriptions
- Potential edge cases identified

**Where to Save:** `BUSINESS_RULES.md`

**Demo Talking Points:**
- "As a BA, I need to extract business rules from existing code"
- "This helps me identify gaps or inconsistencies in requirements"
- "I can use this to validate with stakeholders and create test scenarios"

---



## Part 3: Creating User-Facing Documentation

### Step 3.1: Generate User Guide

**Prompt for Copilot Chat:**
```
Create a comprehensive end-user guide for the Expense Tracker application. Include:
- Getting started (registration and login)
- How to add expenses (one-time and recurring)
- Using filters and search
- Understanding categories and currencies
- Generating reports (monthly, calendar year, financial year)
- Printing reports
- Managing settings
Use screenshots placeholders and step-by-step instructions. Write for non-technical end users.
```

**Expected Outcome:**
- Complete user guide in markdown
- Step-by-step instructions for all features
- Business-friendly language

**Where to Save:** `USER_GUIDE.md`

**Demo Talking Points:**
- "End users need clear instructions without technical jargon"
- "Copilot helps me create comprehensive guides quickly"
- "I can update this as features change"

---



### Step 3.2: Generate FAQ Document

**Prompt for Copilot Chat:**
```
Based on the ExpenseTracker application features, create an FAQ document with 15-20 common questions users might have about:
- Account management
- Adding and editing expenses
- Recurring expenses
- Multi-currency support
- Reports and summaries
- Data security
- Tax deductions
Provide clear, helpful answers for each question.
```

**Expected Outcome:**
- Comprehensive FAQ document
- Business-focused answers
- Anticipates common user questions

**Where to Save:** `FAQ.md`

**Demo Talking Points:**
- "FAQs reduce support burden and improve user satisfaction"
- "Copilot helps me think through common scenarios"
- "I can update this based on actual user feedback"

---

## Part 6: Modernization & Migration Planning

### Step 6.1: Generate Modernization Proposal

**Scenario:** Leadership wants to modernize the VB.NET desktop app to a C# .NET web application

**Prompt for Copilot Chat:**
```
Analyze the ExpenseTracker VB.NET desktop application and create a comprehensive modernization proposal document for converting it to a C# ASP.NET Core web application. Include:

Analyze the ExpenseTracker VB.NET desktop application and create a comprehensive modernization  design for converting it to a C# /.Net web application. Include:

1. Executive summary with key benefits
2. Current state analysis (technology stack, features, limitations)
3. Proposed solution architecture (monolith app, with SQL light inmemory database and form based authentication)
4. Technical requirements (functional for all the features AS IT IS)

Use language suitable for technical teams.
Format as a professional markdown document.
```



**Where to Save:** `ExpenseTracker_Modernization_Proposal.md`

**Demo Talking Points:**
- "As a BA, I need to help leadership understand the business case for modernization"
- "Copilot helps me create comprehensive technical proposals even though I'm not a developer"
- "I can generate professional documentation that covers architecture, costs, risks, and timeline"
- "This accelerates the proposal process from weeks to hours"

---



---

## Questions Audience Might Ask

**Q: "Do BAs need to know how to code to use Copilot?"**  
A: No! Sarah uses Copilot to understand existing code and generate documentation. She doesn't write production code.

**Q: "How accurate is the documentation Copilot generates?"**  
A: Very accurate for structural documentation. Sarah should always review and validate business rules with stakeholders.

**Q: "Can this replace technical writers?"**  
A: No, it makes them more efficient. Technical writers still need to review, refine, and maintain documentation quality.

**Q: "What if the code has no comments at all?"**  
A: That's where Copilot shines! It can analyze the code and generate meaningful comments and documentation from scratch.

**Q: "How does this help with legacy code?"**  
A: Perfect for legacy code! BAs can quickly understand old systems and create documentation that was never written.


