﻿using System;
using System.Runtime.Serialization;

namespace CalculateFunding.Common.ApiClient.Bearer
{
    public class MissingBearerTokenException : ApplicationException
    {
        public MissingBearerTokenException()
        {
        }

        public MissingBearerTokenException(string message) : base(message)
        {
        }

        public MissingBearerTokenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingBearerTokenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
