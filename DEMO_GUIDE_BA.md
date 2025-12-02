# GitHub Copilot Demo Guide - Business Analyst (Sarah)

## Persona: Sarah - Business Analyst

**Scenario Overview:**  
Sarah is a business analyst working with an existing VB.NET and C# codebase (Expense Tracker application). She needs to understand how the code functions in order to help design changes and provide documentation to the product team. To achieve this, Sarah plans to add comments and generate documentation for the legacy code.

---

## Demo Objectives

1. **Add comments to the code base** documenting methods and important functions
2. **Create clear documentation** on the code base for a non-technical user to understand its functionality
3. **Create documentation** on how to use the application

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

### Step 2.1: Generate Application Architecture Overview

**Prompt for Copilot Chat:**
```
Based on the ExpenseTracker VB.NET project, create a high-level architecture document in markdown format that explains:
- The application structure (Models, Services, Forms, Data layers)
- How different components interact
- Key business features (authentication, expense management, recurring expenses, multi-currency, reporting)
- Use simple, non-technical language suitable for business stakeholders
```

**Expected Outcome:**
- Markdown document with architecture overview
- Layered architecture explanation
- Feature list with business descriptions

**Where to Save:** `ARCHITECTURE_OVERVIEW.md`

**Demo Talking Points:**
- "I need to explain this system to non-technical stakeholders"
- "Copilot generates documentation that bridges technical and business understanding"
- "This becomes the foundation for requirements documents"

---

### Step 2.2: Document Business Rules and Logic

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



## Demo Script Summary

### Opening (2 minutes)
"Hi, I'm Sarah, a Business Analyst. I work with development teams but I'm not a programmer myself. My job is to understand how applications work, document them, and help design improvements. Today I'll show you how GitHub Copilot helps me do this work more effectively with our VB.NET Expense Tracker application."

### Section 1: Adding Code Comments (5-7 minutes)
- Demonstrate adding  docs to methods
- Show inline comments for business logic
- Explain how this helps BAs understand code

### Section 2: Creating Documentation (8-10 minutes)
- Generate architecture overview
- Create business rules document
- Build data dictionary
- Highlight how Copilot translates technical to business language

### Section 3: User Documentation (5-7 minutes)
- Create user guide
- Generate FAQ
- Show how BAs can create end-user materials

### Section 4: Change Analysis (5 minutes)
- Demonstrate impact analysis for new feature
- Show how Copilot helps assess changes

### Section 5: Code Understanding (3-5 minutes)
- Explain complex code in business terms
- Identify improvement opportunities

### Closing (2 minutes)
"GitHub Copilot empowers Business Analysts to work more independently with codebases, create better documentation faster, and bridge the gap between technical and business teams. It's not about replacing developers - it's about making collaboration more effective."

---

## Tips for a Successful Demo

1. **Have the project already open** in VS Code with Copilot enabled
2. **Pre-select the files** you'll demo in your browser for quick access
3. **Show both Chat and inline suggestions** to demonstrate versatility
4. **Use real examples** from the Expense Tracker app for authenticity
5. **Explain the 'why'** - how this helps Sarah's actual work
6. **Show iteration** - if Copilot's first answer isn't perfect, refine the prompt
7. **Keep it business-focused** - emphasize documentation and understanding, not coding

---

## Follow-Up Resources

After the demo, share:
- `README.md` - Project overview
- `QUICKSTART.md` - Setup guide
- All generated documentation files
- GitHub Copilot for Business resources

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


