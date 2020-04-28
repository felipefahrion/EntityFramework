using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst.BLL.Exceptions
{
    public class NotFoundExpection : Exception
    {
        public NotFoundExpection(string message) : base(message)
        {
        }
    }
}
