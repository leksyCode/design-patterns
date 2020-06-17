using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class CountryHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Country package")
            {
                return $"Country employee: took the package.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
