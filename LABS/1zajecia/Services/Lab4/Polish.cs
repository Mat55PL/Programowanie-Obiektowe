namespace _1zajecia.Services.Lab4
{
    public class Polish : Language, ILanguage
    {
        public Polish(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public override string getLang()
        {
            return "PL";
        }

        public string getLanguageName()
        {
            return Name;
        }
    }
}