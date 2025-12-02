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

### Step 1.1: Add XML Documentation to AuthenticationService

**File to Open:** `ExpenseTracker/Services/AuthenticationService.vb`

**Prompt for Copilot Chat:**
```
Add XML documentation comments to all public methods in this file. Include:
- Summary of what each method does
- Parameter descriptions
- Return value descriptions
- Example usage where helpful
```

**Expected Outcome:**
- XML doc comments (`'''`) added above each method
- Clear explanations of Register, Login, ChangePassword methods
- Parameter and return type documentation

**Demo Talking Points:**
- "As a BA, I need to understand what each method does without diving deep into implementation"
- "Copilot generates standard XML documentation that developers and tools can use"
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

### Step 1.3: Document Database Helper Methods

**File to Open:** `ExpenseTracker/Data/DatabaseHelper.vb`

**Prompt for Copilot Chat:**
```
Add comprehensive comments to the DatabaseHelper class explaining:
- What each method does (InitializeDatabase, ExecuteReader, ExecuteNonQuery, ExecuteScalar)
- When to use each method
- What security measures are in place (parameterized queries)
```

**Expected Outcome:**
- Method-level documentation
- Security best practices highlighted
- Usage guidelines for each helper method

**Demo Talking Points:**
- "Understanding data access is critical for requirements gathering"
- "I can now document data flows for compliance and security reviews"
- "This helps me identify potential risks and improvements"

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

### Step 2.3: Generate Data Dictionary

**Prompt for Copilot Chat:**
```
Create a data dictionary for the ExpenseTracker application by analyzing the Models and DatabaseHelper. Include:
- All database tables and their purpose
- Column names, data types, and descriptions
- Relationships between tables
- Required vs. optional fields
Format as a markdown table for easy reading.
```

**Expected Outcome:**
- Complete data dictionary in table format
- Clear field descriptions
- Relationship documentation

**Where to Save:** `DATA_DICTIONARY.md`

**Demo Talking Points:**
- "Understanding the data model is essential for requirements analysis"
- "This helps me design reports and new features"
- "I can share this with stakeholders to discuss data needs"

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

### Step 3.2: Create Quick Start Guide

**Prompt for Copilot Chat:**
```
Create a 1-page Quick Start guide for new users of the Expense Tracker. Include:
- 5-minute setup instructions
- Adding your first expense
- Viewing your expense summary
Keep it simple, visual, and action-oriented.
```

**Expected Outcome:**
- Concise quick start document
- Focus on essential first tasks
- Friendly, encouraging tone

**Where to Save:** `QUICK_START.md`

**Demo Talking Points:**
- "New users need to get started quickly"
- "This reduces support tickets and training time"
- "Copilot helps me focus on the user journey"

---

### Step 3.3: Generate FAQ Document

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

## Part 4: Generating Change Documentation

### Step 4.1: Document a Feature Change

**Scenario:** Product team wants to add "Expense Attachments" feature

**Prompt for Copilot Chat:**
```
I need to propose adding an "Expense Attachments" feature to the ExpenseTracker app where users can attach receipts (images/PDFs) to expenses. 

Analyze the current codebase and generate:
1. Impact analysis: What files/classes would need to change?
2. Data model changes: What new fields/tables are needed?
3. UI changes: What forms need to be updated?
4. Business rules: File size limits, supported formats, storage considerations
5. Implementation complexity estimate (high/medium/low)

Format as a change request document for the development team.
```

**Expected Outcome:**
- Detailed change impact analysis
- Technical requirements in business language
- Implementation roadmap

**Where to Save:** `CHANGE_REQUEST_ATTACHMENTS.md`

**Demo Talking Points:**
- "As a BA, I need to assess the impact of proposed changes"
- "Copilot helps me understand technical implications quickly"
- "I can provide better estimates and requirements to stakeholders"

---

### Step 4.2: Create Release Notes Template

**Prompt for Copilot Chat:**
```
Based on the current features in the ExpenseTracker application, create a release notes template that I can use for future releases. Include sections for:
- New features
- Improvements
- Bug fixes
- Breaking changes
- Known issues

Provide an example filled in with the current v1.0 features.
```

**Expected Outcome:**
- Professional release notes template
- v1.0 release notes as example
- Business-friendly format

**Where to Save:** `RELEASE_NOTES_TEMPLATE.md`

**Demo Talking Points:**
- "Consistent release notes help users and stakeholders stay informed"
- "Copilot creates templates I can reuse for every release"
- "This improves communication and change management"

---

## Part 5: Code Understanding & Analysis

### Step 5.1: Explain Complex Code Sections

**File to Open:** `ExpenseTracker/Services/ExpenseService.vb` (GetRecurringExpenseInstances method)

**Prompt for Copilot Chat:**
```
Explain this GetRecurringExpenseInstances method in simple terms:
- What problem does it solve?
- How does it calculate recurring dates?
- What are the edge cases?
- Provide an example with actual dates

Explain it as if I'm describing it to a product owner.
```

**Expected Outcome:**
- Plain English explanation
- Business scenario examples
- Clear understanding of complex logic

**Demo Talking Points:**
- "I don't need to be a VB.NET expert to understand business logic"
- "Copilot translates code into business requirements"
- "This helps me validate if the implementation matches requirements"

---

### Step 5.2: Identify Potential Issues or Improvements

**Prompt for Copilot Chat:**
```
Review the ExpenseTracker application codebase and identify:
- Potential usability issues from a business perspective
- Missing features that users might expect
- Business logic that could be clearer or more flexible
- Areas where business rules might conflict or be unclear

Present findings as a BA would for a product backlog review.
```

**Expected Outcome:**
- Business-focused improvement suggestions
- Feature gap analysis
- Prioritization considerations

**Demo Talking Points:**
- "Copilot helps me identify opportunities for improvement"
- "I can build a better product backlog with AI assistance"
- "This bridges the gap between what we have and what users need"

---

## Demo Script Summary

### Opening (2 minutes)
"Hi, I'm Sarah, a Business Analyst. I work with development teams but I'm not a programmer myself. My job is to understand how applications work, document them, and help design improvements. Today I'll show you how GitHub Copilot helps me do this work more effectively with our VB.NET Expense Tracker application."

### Section 1: Adding Code Comments (5-7 minutes)
- Demonstrate adding XML docs to methods
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

---

## Success Metrics

After implementing this workflow, Sarah can measure:
- Time saved in code analysis (50-70% reduction)
- Documentation completeness (90%+ coverage)
- Stakeholder satisfaction with documentation quality
- Reduced back-and-forth with developers for clarification
- Faster onboarding for new team members

---

*Demo Guide Version 1.0 - December 2025*
