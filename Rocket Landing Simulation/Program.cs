/* 1. String Representation: Start with a string that represents the rocket. This string will include line breaks and slashes to create a simple rocket shape.
 * 2. Console Display: Your goal is to display this rocket string in the console and make it appear as though the rocket is descending step by step.
 * 3. Console Clear: Use the `Console.Clear()` method to clear the console at each step of the descent. This will make the movement of the rocket smooth and continuous.
 * 4. Descent Mechanism: Implement a mechanism to add an empty line above the rocket for each iteration. This will simulate the rocket descending.
 * 5. Final Message: Once the rocket has landed, display a message such as "The rocket has landed. Woohoo! Another successful landing!"
 * Remember, the key part of this challenge is to ensure the rocket descends smoothly,
 * giving the appearance of a controlled landing. You might need to experiment with adding empty lines and clearing the console to achieve the desired effect.
 */

string rocket = "   ^\n" +
"  / \\\n" +
" |---|\n" +
" |   |\n" +
" |   |\n" +
" |   |\n" +
" |   |\n" +
" |   |\n" +
" |   |\n" +
" /___\\\n" +
" UUUUU";

Console.WriteLine(rocket);
//Let's loop to make the rocket descend

for (int i = 0; i < 10; i++)
{
    
    Console.Clear();
    Console.WriteLine($"Descending... Step {i + 1}");
    for (int j = 0; j < i; j++)
    {

        Console.WriteLine();
    }
    
    Console.WriteLine(rocket);
    Thread.Sleep(500);
}

Console.WriteLine("\nThe rocket has landed");
Console.WriteLine("\nWoohoo! Another successful landing!");

Console.ReadKey();  