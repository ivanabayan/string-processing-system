using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private readonly StringService _service;

        public StringView()
        {
            _service = new StringService();
        }

        public void Start()
        {
            bool exitRequested = false;

            do
            {
                PrintMenu();
                Console.Write("Select option: ");
                string option = Console.ReadLine();

                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        InputText();
                        break;

                    case "2":
                        Console.WriteLine("Current Text: " + _service.Display());
                        break;

                    case "3":
                        _service.MakeUpper();
                        Console.WriteLine("Text converted to UPPERCASE.");
                        break;

                    case "4":
                        _service.MakeLower();
                        Console.WriteLine("Text converted to lowercase.");
                        break;

                    case "5":
                        Console.WriteLine("Total Characters: " + _service.GetLength());
                        break;

                    case "6":
                        CheckWord();
                        break;

                    case "7":
                        ReplaceText();
                        break;

                    case "8":
                        ExtractText();
                        break;

                    case "9":
                        _service.CleanSpaces();
                        Console.WriteLine("Extra spaces removed.");
                        break;

                    case "10":
                        _service.Restore();
                        Console.WriteLine("Text restored to original.");
                        break;

                    case "11":
                        exitRequested = true;
                        Console.WriteLine("System closing...");
                        break;

                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

                Console.WriteLine();

            } while (!exitRequested);
        }

        private void PrintMenu()
        {
            Console.WriteLine("==== STRING PROCESSING SYSTEM ====");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
            Console.WriteLine("==================================");
        }

        private void InputText()
        {
            Console.Write("Type your text: ");
            string text = Console.ReadLine();
            _service.LoadText(text);
        }

        private void CheckWord()
        {
            Console.Write("Word to search: ");
            string word = Console.ReadLine();

            bool found = _service.HasWord(word);

            Console.WriteLine(found ? "Word exists in text." : "Word not found.");
        }

        private void ReplaceText()
        {
            Console.Write("Word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("New word: ");
            string newWord = Console.ReadLine();

            _service.ChangeWord(oldWord, newWord);
            Console.WriteLine("Replacement completed.");
        }

        private void ExtractText()
        {
            Console.Write("Start index: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());

            _service.GetPart(start, length);
            Console.WriteLine("Substring extracted.");
        }
    }
}
