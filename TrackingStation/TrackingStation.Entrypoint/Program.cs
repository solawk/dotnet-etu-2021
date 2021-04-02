using AutoMapper;
using System;
using TrackingStation.BLL.Implementation;
using TrackingStation.DataAccess.Context;
using TrackingStation.DataAccess.Implementation;
using TrackingStation.Domain.Model;

namespace TrackingStation.Entrypoint
{
    class Program
    {
        static void DoStuff()
        {
            DataContext Context = new DataContext();

            MapperConfiguration MapperCfg = new MapperConfiguration(cfg => { cfg.AddProfile<AutomapperProfile>(); });
            Mapper Mapper = new Mapper(MapperCfg);

            try
            {
                //MapperCfg.AssertConfigurationIsValid();
            }
            catch (AutoMapperConfigurationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("DB active");

            BodyDataAccess BodyDA = new BodyDataAccess(Context, Mapper);
            BodyServant BodyBL = new BodyServant(BodyDA);

            while (AppLoop(BodyBL))
            {
                DisplayBodies(BodyBL);
            }
        }

        static async void DisplayBodies(BodyServant BodyBL)
        {
            var bodies = await BodyBL.Read();

            Console.WriteLine("Bodies: ");
            foreach (var b in bodies)
            {
                Console.WriteLine($"{b.Name}: {b.Radius}, {b.SMA}");
            }
        }

        static bool AppLoop(BodyServant BodyBL)
        {
            Console.WriteLine();
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Read");
            Console.WriteLine("3 - Read All");
            Console.WriteLine("4 - Update");
            Console.WriteLine("5 - Delete");
            Console.WriteLine("0 - Exit");
            Console.Write("Choice: ");

            string name;
            double radius;
            decimal sma;
            BodyModel model;
            VesselModel BodyFinder;

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:

                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine());

                    Console.Write("SMA: ");
                    sma = decimal.Parse(Console.ReadLine());

                    model = new BodyModel
                    {
                        Name = name,
                        Radius = radius,
                        SMA = sma
                    };

                    BodyBL.Create(model);

                    break;

                case 2:

                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    BodyFinder = new VesselModel
                    {
                        BodyName = name
                    };

                    //BodyBL.Read(BodyFinder);

                    break;

                case 3:

                    //BodyBL.Read();

                    break;

                case 4:

                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    BodyFinder = new VesselModel
                    {
                        BodyName = name
                    };

                    Console.Write("New name: ");
                    name = Console.ReadLine();

                    Console.Write("New radius: ");
                    radius = double.Parse(Console.ReadLine());

                    Console.Write("New SMA: ");
                    sma = decimal.Parse(Console.ReadLine());

                    model = new BodyModel
                    {
                        Name = name,
                        Radius = radius,
                        SMA = sma
                    };

                    BodyBL.Update(BodyFinder, model);

                    break;

                case 5:

                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    BodyFinder = new VesselModel();
                    BodyFinder.BodyName = name;

                    BodyBL.Delete(BodyFinder);

                    break;

                case 0:

                    return false;
            }

            return true;
        }

        /*
        static void Main(string[] args)
        {
            DoStuff();
        }*/
    }
}
