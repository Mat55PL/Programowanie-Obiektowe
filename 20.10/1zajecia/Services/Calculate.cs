namespace _1zajecia.Services
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
            this.Value += value;
        }
        public void Decrease(int value)
        {
            this.Value -= value;
        }
        public int GetValue()
        {
            return Value;
        }

    }
}
