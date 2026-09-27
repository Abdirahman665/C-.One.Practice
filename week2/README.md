# Discouse chapter 2

# week2 - C# Home work Assignment1

# the code has try

try
{
    int num1, num2, sum;

    num1=int.Parse(FirstNumber.Text);
    num2=int.Parse(SecondNumber.Text);
    sum=num1+num2;
    total.Text=sum.ToString();
}

# in try has Arithmetic

sum=num1+num2;

# and the code has catch

catch (FormatException)
{
    MessageBox.Show("Please enter valid numbers.");
}