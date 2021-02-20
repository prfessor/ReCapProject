using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Results
    {
        public SuccessResult(string message): base(true,message) //hem mesaj hem de bool döner.
        {
            
        }
        public SuccessResult() : base(true) //sadec başarıldı bool u döner, mesajsızdır.
        {

        }
    }
}
