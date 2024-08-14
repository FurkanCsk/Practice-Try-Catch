
// Variable to track if a valid input has been entered
bool isValidInput = false;

// Loop until the users enter a valid number
while (!isValidInput)
{
    try
    {
        // Ask the user to enter a number
        Console.WriteLine("You can enter the number you want to find the square of :");

        // Convert the user input to an integer
        int number = Convert.ToInt32(Console.ReadLine());

        // Calculate the square of the entered number
        int squareNumber = number * number;

        // Print the square of the number to the console
        Console.WriteLine($"Square of your number : {squareNumber}");

        // If a valid input was entered exit the loop
        isValidInput = true;
    }

    catch (FormatException)
    {
        // If the user entered a invalid format show an error message
        Console.WriteLine("You have entered an incorrect input. Please enter only the number.");
    }
    catch (OverflowException)
    {
        // If the user entered a number to large or too small show an error message
        Console.WriteLine("The number you entered is too large or too small. Please enter a valid number.");
    }
    catch (Exception ex)
    {
        // If an unexpected error occurs, display this message.
        Console.WriteLine($"An unexpected error occured: {ex.Message}");
    }
}
