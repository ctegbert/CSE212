public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Initialize the result array
        // Create a new array of doubles with the specified length to store the multiples.

        // Step 2: Generate multiples
        // Use a loop to calculate each multiple of the given number.
        // Start from 1 to length (inclusive) to avoid zero and ensure correct multiples.

        // Step 3: Populate the array
        // Assign each calculated multiple to the corresponding index in the array.

        // Step 4: Return the result
        // Return the populated array containing the multiples of the given number.

        double[] mult = new double[length];
        for (int i = 0; i < length; i++)
        {
            mult[i] = number * (i +1);
        }
        return mult;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {

    int count = data.Count;
    amount = amount % count;


    List<int> newRange = data.GetRange(count - amount, amount);
    newRange.AddRange(data.GetRange(0, count - amount));


    data.Clear();
    data.AddRange(newRange);
    }



        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

    // Step 1: Handle edge cases
    // Check if the list is null or empty and return early if so.

    // Step 2: Normalize the rotation amount
    // Convert negative amounts to a positive equivalent and use modulo to keep the amount within the list's bounds.

    // Step 3: Early exit if no rotation is needed
    // If the normalized amount is zero, return early as no rotation is needed.

    // Step 4: Extract elements to rotate
    // Get the last 'amount' elements and the rest of the list separately.

    // Step 5: Combine both parts
    // Create a new list by joining the rotated elements and the remaining elements.

    // Step 6: Update the original list
    // Clear the original list and replace it with the new list.


}