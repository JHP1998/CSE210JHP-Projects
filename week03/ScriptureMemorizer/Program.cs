using System;

class Program
{
    
    static void Main(string[] args)
    {
        ScriptureReference ref1 = new ScriptureReference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            ref1,
           " Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."    
        );
        //Display scripture scripture.GetDisplayText
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            //Ask user to continue or not
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            
            
            //Hide 3 random words scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        //Dislay final version of scripture scripture.GetDisplayText()

    }
}