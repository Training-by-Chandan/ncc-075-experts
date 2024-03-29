﻿namespace NCC.ConsoleApp
{
    [Serializable]
    public class MyCustomException : Exception
    {
        public MyCustomException()
        { }

        public MyCustomException(string message) : base(message)
        {
        }

        public MyCustomException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MyCustomException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}