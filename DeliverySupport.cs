using System;

namespace COC2
{
    internal class DeliverySupport:CustomerSupport
    {   public override void Handle(Request request)
        {
            if (request.Type == "Delivery")
                Console.WriteLine($"Delivery Support deparment handled the request with the following description:\n{request.Description}");
            else if (NextSupport != null)
                NextSupport.Handle(request);
            else
                Console.WriteLine($"No department was able to handle the request with the following description:\n{request.Description}");
        }
    }
}

