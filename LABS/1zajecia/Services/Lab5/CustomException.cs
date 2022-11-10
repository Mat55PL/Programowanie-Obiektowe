namespace _1zajecia.Services.Lab5
{
    public class CustomException
    {
        [Serializable]
        public class InvalidDepartmentException : Exception
        {
            public InvalidDepartmentException() : base() { }
            public InvalidDepartmentException(string message) : base(message) { }
            public InvalidDepartmentException(string message, Exception inner) : base(message, inner) { }
        }
    }
}
