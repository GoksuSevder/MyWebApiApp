using Microsoft.EntityFrameworkCore;
using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAccess.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new MyWebApiAppContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(Users);

                }
                if (context.Addresses.Count() == 0)
                {
                    context.Addresses.AddRange(Addresses);

                }
                if (context.Geos.Count() == 0)
                {
                    context.Geos.AddRange(Geos);

                }
                if (context.Companies.Count() == 0)
                {
                    context.Companies.AddRange(Companies);

                }
                context.SaveChanges();
            }

        }

        private static User[] Users =
        {
            new User()
            {
                Id=1,
                Name="Leanne Graham",
                UserName ="Bret",
                Email ="Sincere@april.biz",
                Phone ="1-770-736-8031 x56442",
                Website="hildegard.org",
                AddressId=1,
                CompanyId=1,
            },
            new User()
            {
                Id=2,
                Name="Ervin Howell",
                UserName ="Antonette",
                Email ="Shanna@melissa.tv",
                Phone ="010-692-6593 x09125",
                Website="anastasia.net",
                AddressId=2,
                CompanyId=2,
            },
            new User()
            {
                Id=3,
                Name="Ervin Howell",
                UserName ="Antonette",
                Email ="Shanna@melissa.tv",
                Phone ="010-692-6593 x09125",
                Website="anastasia.net",
                AddressId=3,
                CompanyId=3,
            },
            new User()
            {
                Id=4,
                Name="Patricia Lebsack",
                UserName ="Karianne",
                Email ="Julianne.OConner@kory.org",
                Phone ="493-170-9623 x156",
                Website="kale.biz",
                AddressId=4,
                CompanyId=4,
            },
            new User()
            {
                Id=5,
                Name="Chelsey Dietrich",
                UserName = "Kamren",
                Email ="Lucio_Hettinger@annie.ca",
                Phone ="(254)954-1289",
                Website="demarco.info",
                AddressId=5,
                CompanyId=5,
            },
            new User()
            {
                Id=6,
                Name="Mrs. Dennis Schulist",
                UserName = "Leopoldo_Corkery",
                Email = "Karley_Dach@jasper.info",
                Phone ="1-477-935-8478 x6430",
                Website="ola.org",
                AddressId=6,
                CompanyId=6,
            },
            new User()
            {
                Id=7,
                Name="Kurtis Weissnat",
                UserName = "Elwyn.Skiles",
                Email = "Telly.Hoeger@billy.biz",
                Phone ="210.067.6132",
                Website="elvis.io",
                AddressId=7,
                CompanyId=7,
            },
            new User()
            {
                Id=8,
                Name="Nicholas Runolfsdottir V",
                UserName = "Maxime_Nienow",
                Email ="Sherwood@rosamond.me",
                Phone ="586.493.6943 x140",
                Website="jacynthe.com",
                AddressId=8,
                CompanyId=8,
            },
            new User()
            {
                Id=9,
                Name= "Glenna Reichert",
                UserName ="Delphine",
                Email ="Chaim_McDermott@dana.io",
                Phone ="(775)976-6794 x41206",
                Website="conrad.com",
                AddressId=9,
                CompanyId=9,
            },
            new User()
            {
                Id=10,
                Name= "Clementina DuBuque",
                UserName ="Moriah.Stanton",
                Email ="Rey.Padberg@karina.biz",
                Phone ="024-648-3804",
                Website="ambrose.net",
                AddressId=10,
                CompanyId=10,
            },


        };
        private static Address[] Addresses =
        {
            new Address()
            {
                Id=1,
                Street="Kulas Light",
                Suite="Apt. 556",
                City ="Gwenborough",
                Zipcode="92998-3874",
                GeoId=1          

            },
            new Address()
            {
                Id=2,
                Street="Victor Plains",
                Suite="Suite 879",
                City ="Wisokyburgh",
                Zipcode="90566-7771",
                GeoId=2
            },
            new Address()
            {
                Id=3,
                Street="Douglas Extension",
                Suite="Suite 847",
                City ="McKenziehaven",
                Zipcode="59590-4157",
                GeoId=3
            },
            new Address()
            {
                Id=4,
                Street="Hoeger Mall",
                Suite="Apt. 692",
                City = "South Elvis",
                Zipcode= "53919-4257",
                GeoId=4
            },
            new Address()
            {
                Id=5,
                Street="Skiles Walks",
                Suite="Suite 351",
                City = "Roscoeview",
                Zipcode= "33263",
                GeoId=5
            },
            new Address()
            {
                Id=6,
                Street="Norberto Crossing",
                Suite= "Apt. 950",
                City = "South Christy",
                Zipcode= "23505-1337",
                GeoId=6
            },
            new Address()
            {
                Id=7,
                Street="Rex Trail",
                Suite= "Suite 280",
                City = "Howemouth",
                Zipcode= "58804-1099",
                GeoId=7
            },
            new Address()
            {
                Id=8,
                Street="Ellsworth Summit",
                Suite= "Suite 729",
                City = "Aliyaview",
                Zipcode= "45169",
                GeoId=8
            },
            new Address()
            {
                Id=9,
                Street="Dayna Park",
                Suite= "Suite 449",
                City = "Bartholomebury",
                Zipcode="76495-3109",
                GeoId=9
            },
            new Address()
            {
                Id=10,
                Street="Kattie Turnpike",
                Suite= "Suite 198",
                City ="Lebsackbury",
                Zipcode= "31428-2261",
                GeoId=10
            },
        };
        private static Geo[] Geos =
        {
            new Geo()
            {
                Id=1,
                Lat=-37.3159,
                Lng=81.1496,

            },
            new Geo()
            {
                Id=2,
                Lat=-43.9509,
                Lng=-34.4618,

            },
            new Geo()
            {
                Id=3,
                Lat=-68.6102,
                Lng=-47.0653,

            },
            new Geo()
            {
                Id=4,
                Lat=-29.4572,
                Lng=-164.2990,

            },
            new Geo()
            {
                Id=5,
                Lat=-31.8129,
                Lng=62.5342,

            },
            new Geo()
            {
                Id=6,
                Lat=-71.4197,
                Lng=71.7478,

            },
            new Geo()
            {
                Id=7,
                Lat=24.8918,
                Lng=21.8984,

            },
            new Geo()
            {
                Id=8,
                Lat=-14.3990,
                Lng=-120.7677,

            },
            new Geo()
            {
                Id=9,
                Lat=24.6463,
                Lng=-168.8889,

            },
            new Geo()
            {
                Id=10,
                Lat=-38.2386,
                Lng=57.2232,

            },
        }; 
        private static Company[] Companies =
        {
            new Company()
            {
                Id=1,
                Name="Romaguera-Crona",
                CatchPhrase="Multi-layered client-server neural-net",
                Bs ="harness real-time e-markets",

            },
            new Company()
            {
                Id=2,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=3,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=4,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=5,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=6,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=7,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=8,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=9,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
            new Company()
            {
                Id=10,
                Name="Deckow-Crist",
                CatchPhrase="Proactive didactic contingency",
                Bs ="synergize scalable supply-chains",
            },
        };

    }

}
