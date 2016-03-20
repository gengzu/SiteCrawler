using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Hosting;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Crawler.Web
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles(); // to get index.html by default
            app.UseStaticFiles();
        }
    }
}