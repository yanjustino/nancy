namespace nancyex
{
    using Nancy;
    using System;
    
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            //teste
            Get["/"] = _ => Response.AsJson(new{id = Guid.NewGuid().ToString()});
        }
    }
}
