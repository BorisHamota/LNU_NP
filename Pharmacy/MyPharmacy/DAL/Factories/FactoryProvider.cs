using Microsoft.Extensions.Configuration;
using MyPharmacy.DAL.Factories.Abstract;
using MyPharmacy.DAL.Factories.Impl.FileImpl;
using MyPharmacy.DAL.Factories.Impl.MemoryImpl;
using System;
using System.IO;

namespace MyPharmacy.DAL.Factories.Impl
{
    public class FactoryProvider
    {
        public FactoryProvider()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true);
            this.Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }
        public IFactory GetFactory()
        {
            var configuration = this.Configuration.GetSection("DatabaseConfiguration");
            var factoryType = configuration.GetSection("factoryType").Value;

            switch (factoryType)
            {
                case "file":
                    return new FileFactory();
                case "memory":
                    return new MemoryFactory();
                default:
                    throw new Exception("Wrong type!");
            }
        }
    }
}