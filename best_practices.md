# Best Practices
This file defines the local coding standards and quality rules for this repository.  
Qodo Merge will use these best practices to provide automated feedback during pull requests.

---

## 🧱 Error Handling
All methods must handle potential errors and invalid inputs properly.

**Guidelines:**
- Validate inputs before use.
- Wrap risky operations in `try-catch` blocks.
- Avoid assuming parameters are always valid.
- Log meaningful error messages instead of silently failing.

**Bad Example:**
```csharp
public int Divide(int a, int b)
{
    return a / b; // ⚠️ No error handling, may crash on divide by zero
}
```

**Good Example:**
```csharp
public int Divide(int a, int b)
{
    try
    {
        return a / b;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error dividing numbers: {ex.Message}");
        return 0;
    }
}
```


## Naming Conventions
Use clear, descriptive, and consistent names for all classes, methods, and variables.

**Guidelines:**
- Use PascalCase for class and method names.
- Use camelCase for variables and parameters.
- Avoid underscores or inconsistent capitalization.
- Names should describe the purpose of the code.

**Bad Example:**
```csharp
public class my_class
{
    public int add_numbers(int a, int b)
    {
        return a + b;
    }
}
```

**Good Example:**
```csharp
public class Calculator
{
    public int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
```


## Code Comments
Public methods and complex logic should have short, descriptive comments explaining their purpose.

**Guidelines:**
- Each public method should have at least one clear comment.
- Comments must explain why the code exists, not just what it does.
- Avoid redundant or outdated comments.

**Bad Example:**
```csharp
// Method
public void Save()
{
    // ...
}
```

**Good Example:**
```csharp
// Saves the current user profile to the database
public void Save()
{
    // ...
}
```

## Console Logging
Console output must clearly describe what is happening in the program.
**Guidelines:**
- Avoid vague outputs like “Done” or “OK”.
- Always include context or variable values when printing results.

**Bad Example:**
```csharp
Console.WriteLine("Done");
```

**Good Example:**
```csharp
Console.WriteLine($"Addition complete. Result: {result}");
```


## Clean and Readable Code
Code must remain easy to read, understand, and maintain.

**Guidelines:**
- Use consistent indentation (4 spaces).
- Keep methods short and focused on one task.
- Use blank lines to separate logical sections.
- Avoid deeply nested if or try blocks.


**Bad Example:**
```csharp
if(a>0){if(b>0){return a+b;}}
```

**Good Example:**
```csharp
if (a > 0 && b > 0)
{
    return a + b;
}
```
