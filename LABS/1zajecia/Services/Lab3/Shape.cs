namespace _1zajecia.Services.Lab3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }

        public int GetArea(int x) //przeciążenie -> polimorfizm
        {
            return Width * Height * x;
        }
        public int GetArea(double x) 
        {
            return Width * Height;
        }

        public virtual int GetShorterSide()
        {
            return new List<int>() { Width, Height }.Min();
        }
    }
}
