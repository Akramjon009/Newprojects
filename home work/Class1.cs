namespace home_work
{
    internal class Class1
    {
        public Class1()
        {
            try
            {
               
                Console.Write("Enter the directory path: ");
                string directoryPath = Console.ReadLine()!;

               
                string[] filePaths = FindFiles(directoryPath);

               
                if (filePaths.Length > 0)
                {
                    Console.WriteLine($"Found files:");
                    foreach (var filePath in filePaths)
                    {
                       
                        Console.WriteLine(filePath);
                    }
                }
                else
                {
                    
                    Console.WriteLine("No files found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static string[] FindFiles(string directoryPath)
        {
            
            string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

            return files;
        }
    }
}
