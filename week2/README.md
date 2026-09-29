# chapter 2


# Reading Input with TextBox Controls


A TextBox allows users to enter or edit text. Its Text property stores the entered value as a string, and its content can be cleared when needed.

# Variables and Data Types


A variable is a named storage location in memory. It must be declared before use, and its data type determines what kind of value it can store.

string: Stores text, such as names or phone numbers.
int: Stores whole numbers.
double: Stores real numbers, including fractional values.
decimal: Stores precise decimal values, commonly used for financial calculations.
var: Lets the compiler infer a local variable's type from its initial value.
Variable names should be meaningful, contain no spaces, and avoid reserved keywords. A variable must be assigned a value before it is used.

# String Concatenation and Variable Scope


String concatenation joins strings together, commonly using the + operator. Local variables are declared inside a method and can only be accessed there. Scope is where a variable can be used; lifetime is how long it exists in memory.

Variables with the same name cannot be declared in the same scope. Assigned values must be compatible with the variable's data type.

# Numeric Data Types and Calculations


C# provides arithmetic operators for addition, subtraction, multiplication, division, and finding a remainder. Expressions follow the usual order of operations; parentheses can clarify the intended order.

Dividing two integers produces an integer result, discarding any fractional part. Mixed numeric types can affect the result type, and some combinations, such as double and decimal, require conversion before calculation.

Type casting explicitly converts a value from one data type to another.

# Inputting and Outputting Numeric Values


TextBox input is read as a string, even when the user types a number. Parsing methods such as int.Parse, double.Parse, and decimal.Parse convert numeric text to a numeric type.

To display a numeric value in a Label, TextBox, or message box, convert it to a string, commonly with the ToString method. The + operator can also combine text with numeric values.

# Formatting Numbers


The ToString method can format numbers for display. Common format strings include:

N: Number format.
F: Fixed-point format.
E: Exponential format.
C: Currency format.
P: Percentage format.
# Simple Exception Handling


An exception is an unexpected error during program execution, such as invalid numeric input or division by zero. Exception handling allows an application to respond instead of stopping abruptly.

try block: Contains statements that may cause an exception.
catch block: Contains the response when an exception occurs.
Exception Message: Provides a description of the error.


# Named Constants and Fields


A named constant is a named value that cannot be changed during program execution. Constants are declared with the const keyword.

A field is a variable declared at class level, outside methods. Its scope is the class, allowing class methods to access it.