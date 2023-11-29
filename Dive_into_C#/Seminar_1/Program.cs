using System;
using static System.Console;


class Program
{
	static void Main(string[] args)
	{
		if (args.Length != 3)
		{
			WriteLine("Usage: Program.exe <operand1> <operator> <operand2>");
			return;
		}

		if (!double.TryParse(args[0], out double operand1) || !double.TryParse(args[2], out double operand2))
		{
			WriteLine("Invalid operands. Please enter valid numeric values");
			return;
		}

		try
		{
			double result = Calculator.Evaluate(operand1, args[1], operand2);
			WriteLine($"{operand1} {args[1]} {operand2} = {result}");
		}
		catch(ArgumentException ex)
		{
			WriteLine(ex.Message);
		}
	}
}
