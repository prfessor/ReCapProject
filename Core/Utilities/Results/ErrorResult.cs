using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Results
    {
        public ErrorResult(string message):base(false, message) //aynı result ın ctor larının formatında çalışır
                                                                //1 arg a 2 default
        {

        }
        public ErrorResult():base(false)
        {

        }
    }
}
