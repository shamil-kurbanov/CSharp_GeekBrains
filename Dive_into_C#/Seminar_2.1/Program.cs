/*
 * Given a two-dimensional array.
									732
									496
									185
Sort the data in it in ascending order.
									123
									456
									789
Print the result.
 */

using System;
using System.Linq;
using static System.Console;

class Program
{
	public static void Main()
	{
		// Step 1: Define a 3x3 two-dimensional array

		int[,] twoDimensionArray =
		{
			{7,3,2 },
			{4,9,6 },
			{1,8,5 }
		};

		// Step 2: Flatten the two-dimensional array and sort the elements
		var flattenedAndSorted = twoDimensionArray.Cast<int>().OrderBy(x => x).ToArray();
		//flattenedAndSorted looks like [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ]


		// Step 3: Get the row and column count of the original array
		int rowCount = twoDimensionArray.GetLength(0);
		int colCount = twoDimensionArray.GetLength(1);


		// Step 4: Reconstruct the two-dimensional array from the sorted array
		int[,] sortedTwoDimensionArray = new int[rowCount, colCount];

		for (int i = 0; i < flattenedAndSorted.Length; i++)
		{
			//Calculate the row and column indices from the flattened index 
			int row = i / colCount;
			int col = i % colCount;

			// Assign the sorted element to the corresponding position in the new array
			sortedTwoDimensionArray[row, col] = flattenedAndSorted[i];

			/*
			 * i = 0, sortedTwoDimensionArray[0,0] = 1
			 * i = 1, sortedTwoDimensionArray[0,1] = 2
			 * i = 2, sortedTwoDimensionArray[0,2] = 3
			 * i = 3, sortedTwoDimensionArray[1,0] = 4
			 * i = 4, sortedTwoDimensionArray[1,1] = 5
			 * ... 
			 * i = 8, sortedTwoDimensionArray[2,2] = 9
			 */
		}

		// Step 5: Print the sorted result
		WriteLine("Sorted Array:");
		for (int i = 0; i < rowCount; i++)
		{
			for (int j = 0; j < colCount; j++)
			{
				// Print each element of the sorted two-dimensional array
				Write(sortedTwoDimensionArray[i, j] + " ");
			}
			WriteLine();
		}

		Console.ReadLine();

	}
}
