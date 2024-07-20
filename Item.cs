namespace ToDoList;

public class Item (string task)
{
    // public string task; //field
    // private bool isComplete = false; //field

    public string Task { get; set;} = task; //property

    public bool IsComplete {get; set; } = false;// property

    public void MarkTask ()
    {
        IsComplete = true;
    }
}
