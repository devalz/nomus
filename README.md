# 📦 **Nomus**

Easily convert text between different naming styles: **UPPERCCASE, lowercase, PascalCase, camelCase, snake_case, SCREAMING_SNAKE_CASE, kebab-case, UPPER-KEBAB-CASE, Title Case and Train-Case**, and automatically detect the original format.  
Ideal for automating naming conversions in .NET projects, code generation, migrations, tools, and utilities.

---

## 🚀 **Features**

✔ Convert *from any format* to:

* **UPPERCCASE**
* **lowercase**
* **PascalCase**
* **camelCase**
* **snake_case**
* **SCREAMING_SNAKE_CASE**
* **kebab-case**
* **UPPER-KEBAB-CASE**
* **Title Case**
* **Train-Case**

✔ **Automatically detects**:

* UPPERCCASE
* lowercase
* PascalCase
* camelCase
* snake_case
* SCREAMING_SNAKE_CASE
* kebab-case
* UPPER-KEBAB-CASE
* Title Case
* Train-Case
* and mixed cases  

✔ Correct handling of casing and separators  
✔ No external dependencies (Regex only)  
✔ Simple and straightforward API  

---

## 📥 Installation

```bash
dotnet add package Devjavu.Nomus
````

Or from Visual Studio:

**Project → Manage NuGet Packages → Browse → Nomus**

---

## ✨ Quick Usage

```csharp
using Nomus;

// Detect naming style
var detected = Naming.DetectNamingStyle("votesUsers");
// "camelCase"

// PascalCase
var p = Naming.ToPascalCase("user_votes_details");
// UserVotesDetails

// camelCase
var c = Naming.ToCamelCase("UserVotesDetails");
// userVotesDetails

// snake_case
var s = Naming.ToSnakeCase("userVotesDetails");
// user_votes_details

// kebab-case
var k = Naming.ToKebabCase("userVotesDetails");
// user-votes-details
```

---

# 🧩 Available Methods

---

## 🔍 **DetectNamingStyle(string input)**

Automatically detects the naming convention of the text.

### Possible results:

* `"UPPERCCASE"`
* `"lowercase"`
* `"PascalCase"`
* `"camelCase"`
* `"snake_case"`
* `"SCREAMING_SNAKE_CASE"`
* `"kebab-case"`
* `"UPPER-KEBAB-CASE"`
* `"Title Case"`
* `"Train-Case"`
* `"Unknown / Mixed"`

### Examples:

```csharp
Naming.DetectNamingStyle("UserVotesDetails");    // PascalCase
Naming.DetectNamingStyle("userVotesDetails");    // camelCase
Naming.DetectNamingStyle("user_votes_details");  // snake_case
Naming.DetectNamingStyle("user-votes-details");  // kebab-case
Naming.DetectNamingStyle("votes UsersDetails");  // Unknown / Mixed
```

---

## 🔠 **ToUpperCase(string input)**

Converts from any format to UPPERCASE.

---

## 🔡 **ToLowerCase(string input)**

Converts from any format to lowercase.

---

## 🧱 **ToPascalCase(string input)**

Converts from any format to PascalCase.

---

## 🐪 **ToCamelCase(string input)**

Converts from any format to camelCase.

---

## 🐍 **ToSnakeCase(string input)**

Converts from any format to snake_case.

---

## 🐍🔠 **ToScreamingSnakeCase(string input)**

Converts from any format to SCREAMING_SNAKE_CASE.

---

## 🔗 **ToKebabCase(string input)**

Converts from any format to kebab-case.

---

## 🔗🔠 **ToUpperKebabCase(string input)**

Converts from any format to UPPER-KEBAB-CASE.

---

## 🔤 **ToTitleCase(string input)**

Converts from any format to Title Case.

---

## 🚂 **ToTrainCase(string input)**

Converts from any format to Title Case.

---

# 🧪 Additional Examples

```csharp
Naming.ToPascalCase("hello-world");       // HelloWorld
Naming.ToCamelCase("HELLO_WORLD");        // helloWorld
Naming.ToSnakeCase("HelloWorld");         // hello_world
Naming.ToKebabCase("helloWorldTest");     // hello-world-test
Naming.ToTrainCase("helloWorldTest");     // Hello-World-Test

Naming.DetectNamingStyle("MyVariable");   // PascalCase
Naming.DetectNamingStyle("myVariable");   // camelCase
Naming.DetectNamingStyle("my_variable");  // snake_case
Naming.DetectNamingStyle("my-variable");  // kebab-case
Naming.DetectNamingStyle("My Variable");  // Title Case
```

---

## 🗂 Package Structure

```
Nomus/
 ├── Naming.cs
 ├── README.md
 └── Nomus.nuspec
```

---

## 📄 License

This project is licensed under the MIT License, which means you can freely use it in commercial and personal projects.

---

## 🤝 Contributing

Contributions are welcome!
You can:

* Report issues
* Propose improvements
* Submit PRs

---

## ⭐ Support the Project

If this package was useful to you, consider leaving a ⭐ on GitHub or sharing it with other developers.