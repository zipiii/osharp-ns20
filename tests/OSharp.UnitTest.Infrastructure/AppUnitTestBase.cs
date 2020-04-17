using System;

using Microsoft.Extensions.DependencyInjection;


namespace OSharp.UnitTest.Infrastructure
{
    public class AppUnitTestBase
    {
        public AppUnitTestBase()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHttpContextAccessor().AddLogging();
            services.AddOSharp();
            IServiceProvider provider = services.BuildServiceProvider();
            provider.UseOsharp();
            ServiceProvider = provider;
        }

        /// <summary>
        /// ��ȡ �����ṩ��
        /// </summary>
        protected IServiceProvider ServiceProvider { get; private set; }
    }
}
