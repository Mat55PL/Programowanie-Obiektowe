using static _1zajecia.Services.Lab5.CustomException;

namespace _1zajecia.Services.Lab5
{
    public class SomeClass
    {
        public string Print(string txt)
        {
            try
            {
                return txt.Length.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new InvalidDepartmentException("Mateusz jest najlepszy");
            }

        }
    }
}
