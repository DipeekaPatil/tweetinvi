﻿using System;

namespace Tweetinvi.Core.Exceptions
{
    public class TwitterNullCredentialsException : Exception
    {
        public TwitterNullCredentialsException() : base("You must set the credentials to use the Twitter API. (Read the exception description field for more information)")
        {
        }

        public string Description
        {
            get { return "Before performing any query please set the credentials : TwitterCredentials.SetCredentials(\"Access_Token\", \"Access_Token_Secret\", \"Consumer_Key\", \"Consumer_Secret\");";  }
        }
    }
}