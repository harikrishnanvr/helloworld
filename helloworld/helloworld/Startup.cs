using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(helloworld.Startup))]

namespace helloworld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //added comment
            ConfigureAuth(app);
        }
    }
}
