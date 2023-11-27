/*
 *  A simple C# program that takes command line arguments and 
 *  evaluates expressions of the form a + b, a - b, a / b, a * b: 
 */

using System;

public class Calculator
{
	public static double Evaluate(double operand1, string op, double operand2)
	{
		switch (op)
		{
			case "+":
				return operand1 + operand2;
			case "-":
				return operand1 - operand2;
			case "*":
				return operand1 * operand2;
			case "/":
				if (operand2 == 0)
				{
					throw new ArgumentException("Cannot divide by zero");
				}
				return operand1 / operand2;
			default:
				throw new ArgumentException("Invalid operator. Please use +, -, *, or /");
		}
	}
}