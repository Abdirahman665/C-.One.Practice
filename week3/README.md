import pypandoc

markdown = """# Chapter 3: Making Decisions in C#
**Source:** *Starting Out with Visual C#, Sixth Edition* — Chapter 3, “Making Decisions”

This README summarizes the important concepts and examples from the presentation.

## Contents
1. Decision Structures and `if`
2. Relational Operators
3. `if-else` and Nested Decisions
4. Logical Operators
5. Boolean Variables and Flags
6. Comparing Strings
7. `TryParse` and Input Validation
8. Radio Buttons and Check Boxes
9. `switch` Statements
10. ListBox Controls
11. Quick Review



## 1. Decision Structures and the `if` Statement
A **control structure** controls the order in which program statements execute. A **sequence structure** runs statements in the order written. A **decision structure** runs statements only when a condition is satisfied; it is also called a **selection structure**.
The `if` statement executes its block when its Boolean expression is `true`.
```csharp
if (condition) { /* statements run when true */ }
```
Example: `if (sales > 50000) { bonus = 500; }` assigns a bonus only when sales are greater than 50000.

## 2. Relational Operators
Relational operators compare two values and return `true` or `false`.
| Operator | Meaning | Example |
|---|---|---|
| `>` | Greater than | `x > y` |
| `<` | Less than | `x < y` |
| `>=` | Greater than or equal to | `x >= y` |
| `<=` | Less than or equal to | `x <= y` |
| `==` | Equal to | `x == y` |
| `!=` | Not equal to | `x != y` |
**Remember:** `=` assigns a value; `==` compares two values.

## 3. `if-else` and Nested Decisions
The `if-else` statement provides two paths: `if` runs when the condition is `true`, and `else` runs when it is `false`.
```csharp
if (grade >= 50) { MessageBox.Show("Pass"); }
else { MessageBox.Show("Fail"); }
```
A **nested decision** is a decision structure inside another decision structure. It is useful when a second condition should be checked only after the first condition is satisfied.
```csharp
if (condition1) {
    if (condition2) { /* both are true */ }
    else { /* condition1 true, condition2 false */ }
} else { /* condition1 false */ }
```
The `if-else-if` statement checks multiple conditions in order and executes the first block whose condition is `true`.
```csharp
if (condition1) { /* first branch */ }
else if (condition2) { /* second branch */ }
else { /* no previous condition is true */ }
```
Arrange conditions carefully so the correct branch is selected.

## 4. Logical Operators
Logical operators combine Boolean expressions or reverse a Boolean result.
| Operator | Name | Meaning |
|---|---|---|
| `&&` | AND | Both conditions must be true. |
| `||` | OR | At least one condition must be true. |
| `!` | NOT | Reverses the Boolean result. |
Examples: `if (temperature < 20 && minutes > 12)` requires both conditions. `if (temperature < 20 || temperature > 100)` requires at least one condition. `if (!(temperature > 100))` reverses the result of the expression.

## 5. Boolean Variables and Flags
The `bool` data type stores only `true` or `false`. A **flag** is a Boolean variable that indicates whether a particular condition or state exists.
Example: `bool isLoggedIn = false;` A program can test it with `if (isLoggedIn) { MessageBox.Show("Welcome"); }`.

## 6. Comparing Strings
C# allows strings to be compared using `==` and `!=`. Examples: `if (name1 == name2)` checks whether two strings are equal, and `if (name1 != "bob")` checks whether `name1` differs from `"bob"`.
The `String.Compare` method can also compare two strings. A return value of `0` indicates that the strings compare as equal: `if (String.Compare(name1, name2) == 0) { /* equal */ }`.

## 7. `TryParse` and Input Validation
Invalid user input can cause data-conversion exceptions. `TryParse` methods help prevent these exceptions when converting text into numeric data.
- Common methods: `int.TryParse`, `double.TryParse`, and `decimal.TryParse`.
- General syntax: `dataType.TryParse(stringInput, out targetVariable)`.
- The `out` keyword identifies the variable that receives the converted value.
Example:
```csharp
int hours;
if (int.TryParse(textBox1.Text, out hours)) { /* conversion succeeded */ }
```
`TryParse` returns `true` when conversion succeeds and `false` when it fails.
**Input validation** checks whether entered data is acceptable before the program uses it. For example, hours can be checked with `hours > 0 && hours <= 168`, and a test score with `testScore >= 0 && testScore <= 100`.
**Important difference:** `TryParse` checks whether text can be converted to a number; input validation checks whether the number is reasonable and allowed. For example, `999` is a valid integer, but it is not a reasonable number of working hours in one week.

## 8. Radio Buttons and Check Boxes
A **RadioButton** allows the user to select **one option** from a group. Selecting one button automatically deselects the other buttons in the same group; this is called **mutually exclusive selection**.
- `Text`: Text displayed next to the control.
- `Checked`: Boolean property indicating whether the control is selected.
Example: `if (choiceRadioButton.Checked) { /* selected */ }`.
A **CheckBox** allows the user to select **multiple options**. It is often used for yes/no, true/false, or optional settings. Its common properties are also `Text` and `Checked`. Example: `if (option1CheckBox.Checked) { /* selected */ }`.
The `CheckedChanged` event occurs when the `Checked` property changes. An event handler can respond to that change; double-clicking the control in the Designer creates the handler.
```csharp
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
    // Respond to the selection change
}
```

## 9. The `switch` Statement
The `switch` statement selects an execution path based on the value of a variable or expression. It is a **multiple-alternative decision structure** and can replace an `if-else-if` chain when testing one expression against several specific values.
```csharp
switch (testExpression) {
    case value1: /* statements */ break;
    case value2: /* statements */ break;
    default: /* no case matches */ break;
}
```
`case` defines a possible value, `break` ends the current case, and the optional `default` section runs when no case matches. The presentation lists `int`, `string`, and `bool` as possible expression types.

## 10. ListBox Controls
A **ListBox** displays a list of items and allows the user to select an item.
| Property | Purpose |
|---|---|
| `Text` | Text of the currently selected item. |
| `Items` | Collection of items in the ListBox. |
| `Items.Count` | Total number of items. |
| `SelectedItem` | Currently selected item. |
| `SelectedIndex` | Zero-based index of the selected item. |
Get the selected item with `selectedFruit = fruitListBox.SelectedItem.ToString();`.
Add items with `Items.Add`, for example: `daysListBox.Items.Add("Monday");`.
ListBox indexes start at zero: the first item is `0`, the second is `1`, and item number `n` has index `n - 1`. If no item is selected, `SelectedIndex` is `-1`. Accessing `SelectedItem` when nothing is selected can cause an exception, so check first:
```csharp
if (fruitListBox.SelectedIndex != -1) {
    selectedFruit = fruitListBox.SelectedItem.ToString();
}
```
**`Text` vs. `SelectedItem`:** `Text` is a `string` and is useful when only the displayed text is needed. `SelectedItem` is an `object` and provides the selected item itself; it may be `null` when nothing is selected and is more flexible for object or data-bound lists.
Remove an item by value with `Items.Remove("Tuesday")`; remove by index with `Items.RemoveAt(2)`; clear the entire list with `Items.Clear()`. The index used by `RemoveAt` must be valid: it cannot be below `0` or greater than or equal to the number of items, otherwise an exception occurs.

## 11. Quick Review
| Feature | Main purpose |
|---|---|
| `if` | Run statements when a condition is true. |
| `if-else` | Choose between two paths. |
| Nested `if` | Test a condition inside another decision. |
| `if-else-if` | Test multiple conditions in order. |
| `&&`, `||`, `!` | Combine or reverse Boolean conditions. |
| `bool` | Store `true` or `false`. |
| `TryParse` | Safely attempt data conversion. |
| Input validation | Check whether input values are acceptable. |
| RadioButton / CheckBox | Select one option / select multiple options. |
| `switch` | Choose a path based on matching values. |
| ListBox | Display and select items from a list. |

## Final Summary
This chapter explains how C# programs make decisions and respond to conditions. It covers decision statements, logical operators, Boolean variables, string comparisons, safe numeric conversion, input validation, and Windows Forms controls such as RadioButtons, CheckBoxes, and ListBoxes. These topics help programmers evaluate conditions, validate user input, respond to selections, and execute the correct instructions.

**Note:** The presentation identifies the material as Chapter 3, “Making Decisions,” although some slide section labels are numbered `4.1` through `4.11`. This README follows the chapter title and the topics presented in the file.
"""
output_path = "/mnt/data/README.md"
pypandoc.convert_text(markdown, "md", format="md", outputfile=output_path, extra_args=["--standalone"])
print(f"Updated English README.md ({len(markdown.splitlines())} lines).")