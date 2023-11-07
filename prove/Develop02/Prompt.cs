public class Prompt
{
    public List<string> _defaultPrompts;
    public List<string> _editedPrompts;

    public void ViewPrompts(List<string> editedPrompts)
    {
        foreach (string prompt in editedPrompts)
                {
                    Console.WriteLine(prompt);
                }
    }

    public List<string> AddPrompts(List<string> editedPrompts)
    {
        List <string> newPrompt = editedPrompts;

        Console.WriteLine("Begin typing your prompt: ");
        Console.Write("> ");
        string userPrompt = Console.ReadLine();

        newPrompt.Add(userPrompt);

        return newPrompt;
    }

    public List<string> DeletePrompts(List<string> editedPrompts)
    {
        List <string> newPrompt = editedPrompts;

        int indexNumber = 0;
        foreach (string prompt in newPrompt)
        {
            Console.WriteLine($"{indexNumber + 1}. {prompt}");
            indexNumber += 1;
        }
        Console.Write("Which prompt would you like to delete? ");
        string userDelete = Console.ReadLine();
        int deletePrompt = int.Parse(userDelete) - 1;

        string removePrompt = newPrompt[deletePrompt];

        newPrompt.Remove(removePrompt);

        return newPrompt;
    }
}