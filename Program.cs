Console.WriteLine("Welcome to Your To Do List.");
bool isActive = true;

while (isActive) 
{
  Console.Write("\nChoose an action (Add, View, Mark, or Exit): ");
  string? action = Console.ReadLine();

  if (string.IsNullOrEmpty(action)) {
    Console.WriteLine("\nNot a valid response.");
    continue;
  }

  switch (action.ToLower())
  {
    case "add":
      // Add a new item
      break;
    case "view":
      // Display all items
      break;
    case "mark":
      // Mark an item as complete
      break;
    case "exit":
      isActive = false;
      Console.WriteLine("\nGoodbye");
      break;
    default: 
      Console.WriteLine("\nNot a valid response.");
      break;
  }
}
