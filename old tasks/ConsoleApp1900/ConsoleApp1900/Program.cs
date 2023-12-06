using Newtonsoft.Json;

namespace ConsoleApp1900
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string modelsDirectory = @"c:\users\birinci novbe\desktop\consoleapp1900\consoleapp1900\Models";
            string dataDirectory = @"c:\users\birinci novbe\desktop\consoleapp1900\consoleapp1900\Data";
            string fileDirectory = @"c:\users\birinci novbe\desktop\consoleapp1900\consoleapp1900\Data\jsonData.json";
            List <CustomObject> CustomObjects = new List<CustomObject>();

            if (!Directory.Exists(modelsDirectory) || !Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(modelsDirectory);
                Directory.CreateDirectory(dataDirectory);
            }
            if (!File.Exists(Path.Combine(dataDirectory, fileDirectory)));
            {
                File.Create(fileDirectory).Close();
                //using (File.Create(fileDirectory));
            }

            HttpClient client = new();
            string response = await client.GetStringAsync(@"https://jsonplaceholder.typicode.com/posts");
            CustomObjects = JsonConvert.DeserializeObject<List<CustomObject>>(response);
            using (StreamWriter writer = new(fileDirectory))
            {
                writer.Write(JsonConvert.SerializeObject(CustomObjects));
            }
            
        }
    }
}