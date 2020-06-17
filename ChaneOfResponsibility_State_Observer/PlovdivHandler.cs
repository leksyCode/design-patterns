using System;
using System.Collections.Generic;
using System.Text;

namespace ChaneOfResponsibility_State_Observer
{
    class PlovdivHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Plovdiv package")
            {
                return $"Plovdiv employee: took the package.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
