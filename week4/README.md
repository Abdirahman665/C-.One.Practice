## Week 4 ##


# Chapter 4: Loops, Files, and Random Numbers#


1. The While Loop


A while loop repeats statements while a condition is true.
It uses a Boolean expression to control repetition.
The loop contains a condition and a body.
The condition is checked before the loop starts.
A while loop is called a pretest loop.
If the condition is false, the loop does not execute.
A counter variable tracks the number of iterations.
Each repetition is called an iteration.
The counter must be updated to avoid infinite loops.
An infinite loop continues until the program is interrupted.


2. Increment and Decrement Operators
Increment means increasing a variable's value by one.
Decrement means decreasing a variable's value by one.
The ++ operator increments a variable.
The -- operator decrements a variable.
count++ is another way to write count = count + 1.
count-- is another way to write count = count - 1.
Postfix places the operator after the variable.
Prefix places the operator before the variable.
Postfix uses the old value before changing it.
Prefix changes the value before using it.


3. The For Loop
A for loop is useful when the number of repetitions is known.
It uses a counter variable to control repetitions.
A for loop contains three main expressions.
Initialization sets the starting value of the counter.
The test expression checks whether the loop should continue.
The update expression changes the counter value.
A for loop is also a pretest loop.
The loop executes while its condition is true.
The counter can increase by one or another number.
The counter can also decrease to count backward.
Example:
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}


4. The Do-While Loop
A do-while loop repeats statements while a condition is true.
It is a posttest loop.
The statements execute before the condition is checked.
A do-while loop always executes at least once.
The condition is checked after each iteration.
It uses the do and while keywords.
A semicolon is required after the while condition.
It is different from the regular while loop.
A false condition does not prevent its first execution.
It is useful when statements must execute at least once.
Example:
int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 5);


5. Using Files for Data Storage
Files allow programs to save data for later use.
Working with files involves three main steps.
First, open the file.
Second, read or write data.
Third, close the file.
There are two main types of files: text and binary.
A text file stores data as readable characters.
A binary file stores data in binary format.
Binary files cannot normally be read using a text editor.
This chapter focuses on working with text files.


6. Reading and Writing Files
A file object connects a program to a specific file.
StreamWriter is used to write data to text files.
StreamReader is used to read data from text files.
File.CreateText() creates a new text file.
If the file already exists, CreateText() erases its old contents.
File.AppendText() adds data without deleting existing contents.
WriteLine() writes data and moves to a new line.
Write() writes data without adding a new line.
File.OpenText() opens a text file for reading.
ReadLine() reads one line and returns it as a string.
Read() reads the next character or characters.
ReadToEnd() reads all remaining data.
ReadAllText() reads all text from a file.
Close() closes the file connection.
EndOfStream indicates whether the end of a file has been reached.
Example: Writing to a File
StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Computer Science");
outputFile.WriteLine("English");
outputFile.Close();


7. OpenFileDialog and SaveFileDialog
These controls allow users to open and save files.
OpenFileDialog displays a Windows Open dialog box.
SaveFileDialog displays a Windows Save As dialog box.
These are invisible controls on the Windows Form.
They appear in the component tray in the Designer.
The ShowDialog() method displays the dialog box.
DialogResult.OK means the user clicked Open or Save.
DialogResult.Cancel means the user canceled the operation.
The FileName property stores the selected file path and name.
The InitialDirectory property sets the starting directory.
File.OpenText() can open the file selected by the user.
File.CreateText() can create the file selected by the user.
Example: Opening a File
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamReader inputFile;
    inputFile = File.OpenText(openFileDialog.FileName);
}


8. Random Numbers
C# provides the Random class to generate random numbers.
A Random object can generate different random values.
The Next() method generates a random integer.
The NextDouble() method generates a decimal number.
NextDouble() returns a value from 0.0 up to, but not including, 1.0.
Next() without arguments generates a non-negative integer.
Next(max) generates an integer from 0 up to, but not including, max.
Random.Next(100) generates numbers from 0 to 99.
Random numbers are useful in games and simulations.
Example:
Random rand = new Random();

int number = rand.Next(100);
double decimalNumber = rand.NextDouble();


9. The Load Event
The Load event occurs when a form is loaded into memory.
It happens when the application starts displaying the form.
The Load event can be created in the Windows Forms Designer.
Double-clicking the form creates its Load event handler.
The event handler contains code that runs when the form loads.
It is useful for preparing the form before the user interacts with it.
You can initialize variables inside the Load event.
You can also display messages when the form starts.
Example:
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Welcome!");
}


10. Important Summary
while checks the condition before executing.
do-while executes once before checking the condition.
for is useful for counter-controlled repetition.
StreamWriter writes data, while StreamReader reads data.
Dialog controls allow users to select files, and Random generates random values.
The Load event executes code when a Windows Form is loaded.