using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Dtos.Response
{
    public class ResponseMessage
    {
        public bool Success { get; }
        public string Message { get; }

        public ResponseMessage(bool success = false, string message = null)
        {
            Success = success;
            Message = message;
        }
    }

    public class InsertResponseMessage<T>
    {
        public bool Success { get; }
        public string Message { get; }

        public T InsertedValue { get; private set; }

        public InsertResponseMessage(T insertedValue, bool success = false, string message = null)
        {
            Success = success;
            Message = message;
            InsertedValue = insertedValue;
        }
    }
}
