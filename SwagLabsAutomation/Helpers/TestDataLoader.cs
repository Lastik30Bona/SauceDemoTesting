using System.Text.Json;

namespace SwagLabsAutomation.Helpers
{
    public class TestDataLoader
    {
        public static IEnumerable<LoginData> GetLoginTestData()
        {
            string filePath = Path.Combine("TestData", "loginData.json");
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<LoginData>>(json);
        }
    }
}
