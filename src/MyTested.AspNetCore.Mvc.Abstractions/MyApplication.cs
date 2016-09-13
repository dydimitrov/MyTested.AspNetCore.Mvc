﻿namespace MyTested.AspNetCore.Mvc
{
    using System;
    using Builders.Application;
    using Builders.Contracts.Application;
    using Internal.Application;

    public class MyApplication : ApplicationConfigurationBuilder
    {
        static MyApplication()
        {
            TestApplication.TryInitialize();
        }

        public MyApplication()
            : this(null)
        {
        }

        public MyApplication(Type startupType)
            : base(startupType)
        {
        }

        public static IApplicationConfigurationBuilder IsUsingDefaultConfiguration()
        {
            return new MyApplication();
        }

        public static IApplicationConfigurationBuilder StartsFrom<TStartup>()
            where TStartup : class
        {
            return new MyApplication(typeof(TStartup));
        }
    }
}
