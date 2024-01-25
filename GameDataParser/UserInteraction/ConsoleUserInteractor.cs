namespace GameDataParser.UserInteraction
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public void PrintError(string message)
        {
            var originalColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColour;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadValidFilePath()
        {
            bool isPathValid = false;
            string fileName;
            do
            {
                Console.WriteLine("Enter the name of the file you want to read:");
                fileName = Console.ReadLine();

                if (fileName is null)
                {
                    Console.WriteLine("The file name cannot be null.");
                }
                else if (fileName == string.Empty)
                {
                    Console.WriteLine("The file cannot be empty.");
                }
                else if (!File.Exists(fileName))
                {
                    Console.WriteLine("The file does not exist.");
                }
                else
                {
                    isPathValid = true;
                }
            } while (!isPathValid);
            return fileName;
        }

    }
}