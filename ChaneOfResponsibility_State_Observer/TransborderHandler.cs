using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class TransborderHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Transborder package")
            {
                return $"Transborder employee: took the package.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
