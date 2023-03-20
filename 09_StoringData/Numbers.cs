namespace _09_StoringData
{
    public static class Numbers
    {
        public static int[] ints = new int[] { 1, 2, 3, 4, 5 };

        public static void Write()
        {
            // Create a StreamWriter instance
            StreamWriter writer = new StreamWriter("numbers.txt");

            // Ensure the writer will be closed when no longer used
            using (writer)
            {
                // Loop through the numbers from 1 to 20 and write them
                foreach (int number in ints)
                {
                    writer.WriteLine(number);
                }
            }
        }

        public static List<int> Read()
        {
            List<int> result = new List<int>();

            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("numbers.txt");
            using (reader)
            {
                int lineNumber = 0;
                // Read first line from the text file
                string line = reader.ReadLine();

                // Read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;

                    result.Add(int.Parse(line));

                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}