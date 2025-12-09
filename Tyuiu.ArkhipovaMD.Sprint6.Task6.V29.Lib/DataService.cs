using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string data = File.ReadAllText(path);
            string[] words = data.Split(new char[] { ' ', '\t', '\n', '\r' },
                                StringSplitOptions.RemoveEmptyEntries);
            string answer = "";
            foreach (string word in words)
            {
                foreach (char liter in word)
                {
                    if (liter == 'i')
                    {
                        answer+=$"{word} ";
                        break;
                    }
                }
            }
            return answer.TrimEnd();
        }
    }
}
