namespace _1zajecia.Services.LAB2
{
    public class Calculate
    {
        public Calculate(int initValue) //constructor
        {
            Value = initValue;
        }
        private int Value { get; set; }
        public void Increase(int value)
        {
            Value += value;
        }
        public void Decrease(int value)
        {
            Value -= value;
        }
        public int GetValue()
        {
            return Value;
        }

    }
}
