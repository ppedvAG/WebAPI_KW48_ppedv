using Microsoft.Extensions.DependencyInjection;
using System;

namespace ServiceCollectionServiceProviderSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            
            //Meine Services lege ich hier ab (AddSingleton / AddScope / AddTransient)
            serviceCollection.AddSingleton<ITimeServiceSingleton, TimeService>();
            serviceCollection.AddScoped<ITimeServiceScope, TimeService>();
            serviceCollection.AddTransient<ITimeServiceTransient, TimeService>();

            //Diese Codezeile wird im Hintergund ausgeführt
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            ITimeService myTimeService = serviceProvider.GetRequiredService<ITimeService>();


            Console.WriteLine(myTimeService.GetCurrentTime().ToShortDateString());

        }
    }

    public interface ITimeService
    {
        DateTime GetCurrentTime();
    }

    public interface ITimeServiceSingleton : ITimeService
    {

    }

    public interface ITimeServiceScope : ITimeService
    {

    }

    public interface ITimeServiceTransient : ITimeService
    {

    }

    public class TimeService : ITimeServiceSingleton, ITimeServiceScope, ITimeServiceTransient
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }

    //public class TimeService2 : ITimeService
    //{
    //    public DateTime GetCurrentTime()
    //    {
    //        return new DateTime(2022, 7, 1);
    //    }
    //}

    //public class TimeService3 : ITimeServiceSingleton
    //{
    //    public DateTime GetCurrentTime()
    //    {
    //        return new DateTime(2100, 7, 1);
    //    }
    //}
}
