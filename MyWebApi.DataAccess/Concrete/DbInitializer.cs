using Microsoft.EntityFrameworkCore;
using MyWebApi.DataAccess.Concrete;
using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.DataAccess.Concrete
{
    public static class DbInitializer
    {
        public static void Initialize()
        {
            var context = new MyWebApiAppContext();
            context.Database.EnsureCreated();
            //Look for any users.
            if (context.Users.Any())
            {
                return; //DB has been seeded
            }
            var companies = new Company[] {
                new Company{
                        Name="Romaguera-Crona",
                        CatchPhrase="Multi-layered client-server neural-net",
                        Bs ="harness real-time e-markets",
                        //UserId=users.Single(i =>i.Name=="Leanne Graham").Id
               },
               new Company{
                            Name="Deckow-Crist",
                            CatchPhrase="Proactive didactic contingency",
                            Bs ="synergize scalable supply-chains",
                            //UserId=users.Single(i =>i.Name=="Ervin Howell").Id
               },
               new Company{
                            Name="Romaguera-Jacobson",
                            CatchPhrase="Face to face bifurcated interface",
                            Bs = "e-enable strategic applications",
                            //UserId=users.Single(i =>i.Name=="Clementine Bauch").Id
               },
               new Company{
                            Name="Robel-Corkery",
                            CatchPhrase="Multi-tiered zero tolerance productivity",
                            Bs = "transition cutting-edge web services",
                            //UserId=users.Single(i =>i.Name=="Patricia Lebsack").Id
               },
               new Company{
                            Name="Keebler LLC",
                            CatchPhrase="User-centric fault-tolerant solution",
                            Bs ="revolutionize end-to-end systems",
                            //UserId=users.Single(i =>i.Name=="Chelsey Dietrich").Id
               },
               new Company{
                            Name="Considine-Lockman",
                            CatchPhrase="Synchronised bottom-line interface",
                            Bs ="e-enable innovative applications",
                            //UserId=users.Single(i =>i.Name=="Mrs. Dennis Schulist").Id
               },
               new Company{
                            Name= "Johns Group",
                            CatchPhrase="Configurable multimedia task-force",
                            Bs ="e-enable innovative applications",
                            //UserId=users.Single(i =>i.Name=="Kurtis Weissnat").Id
               },
               new Company{
                            Name= "Abernathy Group",
                            CatchPhrase="Implemented secondary concept",
                            Bs ="e-enable extensible e-tailers",
                            //UserId=users.Single(i =>i.Name=="Nicholas Runolfsdottir V").Id
               },
               new Company{
                            Name= "Yost and Sons",
                            CatchPhrase="Switchable contextually-based project",
                            Bs ="aggregate real-time technologies",
                            //UserId=users.Single(i =>i.Name=="Glenna Reichert").Id
               },
               new Company{
                            Name= "Hoeger LLC",
                            CatchPhrase= "Centralized empowering task-force",
                            Bs ="target end-to-end models",
                            //UserId=users.Single(i =>i.Name=="Clementina DuBuque").Id
               }
            };
            foreach (Company c in companies)
            {
                context.Companies.Add(c);
            }
            context.SaveChanges();
            var geos = new Geo[] {
                new Geo(){
                        Lat=-37.3159,
                        Lng=81.1496,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id 
                },
                new Geo(){
                        Lat=-43.9509,
                        Lng=-34.4618,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=-68.6102,
                        Lng=-47.0653,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=-29.4572,
                        Lng=-164.2990,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=-31.8129,
                        Lng=62.5342,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=-71.4197,
                        Lng=71.7478,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=24.8918,
                        Lng=21.8984,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=-14.3990,
                        Lng=-120.7677,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=24.6463,
                        Lng=-168.8889,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                },
                new Geo(){
                        Lat=-38.2386,
                        Lng=57.2232,
                        //Addressid=addresses.Single(a =>a.User.Name=="Ervin Howell").Id
                }
            };
            foreach (Geo g in geos)
            {
                context.Geos.Add(g);
            }
            context.SaveChanges();

         
          
            using (var transaction = context.Database.BeginTransaction())
            { 
                var addresses = new Address[] {

                    new Address {

                    Street="Kulas Light",
                    Suite="Apt. 556",
                    City ="Gwenborough",
                    Zipcode="92998-3874",
                    GeoId=1
                    },

                    new Address{

                    Street="Victor Plains",
                    Suite="Suite 879",
                    City ="Wisokyburgh",
                    Zipcode="90566-7771",
                    GeoId=2
                    },
                    new Address{
                    Street="Douglas Extension",
                    Suite="Suite 847",
                    City ="McKenziehaven",
                    Zipcode="59590-4157",
                    GeoId=3
                    },
                    new Address{
                    Street="Hoeger Mall",
                    Suite="Apt. 692",
                    City = "South Elvis",
                    Zipcode= "53919-4257",
                    GeoId=4,
                    },
                    new Address{
                    Street="Skiles Walks",
                    Suite="Suite 351",
                    City = "Roscoeview",
                    Zipcode= "33263",
                    GeoId=5
                    },
                    new Address{
                    Street="Norberto Crossing",
                    Suite= "Apt. 950",
                    City = "South Christy",
                    Zipcode= "23505-1337",
                    GeoId=6
                    },
                    new Address{
                    Id=7,
                    Street="Rex Trail",
                    Suite= "Suite 280",
                    City = "Howemouth",
                    Zipcode= "58804-1099",
                    GeoId=7
                    },
                    new Address{
                    Street="Ellsworth Summit",
                    Suite= "Suite 729",
                    City = "Aliyaview",
                    Zipcode= "45169",
                    GeoId=8
                    },
                    new Address{
                    Street="Dayna Park",
                    Suite= "Suite 449",
                    City = "Bartholomebury",
                    Zipcode="76495-3109",
                    GeoId=9
                    },
                    new Address{
                    Street="Kattie Turnpike",
                    Suite= "Suite 198",
                    City ="Lebsackbury",
                    Zipcode= "31428-2261",
                    GeoId=10
                    } 
                };           
                foreach (Address a in addresses)           
                {
                    context.Addresses.Add(a);
                }
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Addresses ON;");
                context.SaveChanges();
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Addresses OFF;");
                //transaction.Commit();
            }

            using (var transaction = context.Database.BeginTransaction())
            {
                var users = new User[] {

                new User()
                {
                    Name="Leanne Graham",
                    UserName ="Bret",
                    Email ="Sincere@april.biz",
                    Phone ="1-770-736-8031 x56442",
                    Website="hildegard.org",
                    //AddressId=1,
                    //CompanyId=1
                },
                new User()
                {
                    Name="Ervin Howell",
                    UserName ="Antonette",
                    Email ="Shanna@melissa.tv",
                    Phone ="010-692-6593 x09125",
                    Website="anastasia.net",
                    //AddressId=2,
                    //CompanyId=2
                },
                new User()
                {

                    Name="Clementine Bauch",
                    UserName ="Samantha",
                    Email ="Nathan@yesenia.net",
                    Phone ="1-463-123-4447",
                    Website="ramiro.info",
                    //AddressId=3,
                    //CompanyId=3
                },
                new User()
                {

                    Name="Patricia Lebsack",
                    UserName ="Karianne",
                    Email ="Julianne.OConner@kory.org",
                    Phone ="493-170-9623 x156",
                    Website="kale.biz",
                    //AddressId=4,
                    //CompanyId=4
                },
                new User()
                {

                    Name="Chelsey Dietrich",
                    UserName = "Kamren",
                    Email ="Lucio_Hettinger@annie.ca",
                    Phone ="(254)954-1289",
                    Website="demarco.info",
                    //AddressId=5,
                    //CompanyId=5
                },
                new User()
                {

                    Name="Mrs. Dennis Schulist",
                    UserName = "Leopoldo_Corkery",
                    Email = "Karley_Dach@jasper.info",
                    Phone ="1-477-935-8478 x6430",
                    Website="ola.org",
                    //AddressId=6,
                    //CompanyId=6
                },
                new User()
                {

                    Name="Kurtis Weissnat",
                    UserName = "Elwyn.Skiles",
                    Email = "Telly.Hoeger@billy.biz",
                    Phone ="210.067.6132",
                    Website="elvis.io",
                    //AddressId=7,
                    //CompanyId=7
                },
                new User()
                {

                    Name="Nicholas Runolfsdottir V",
                    UserName = "Maxime_Nienow",
                    Email ="Sherwood@rosamond.me",
                    Phone ="586.493.6943 x140",
                    Website="jacynthe.com",
                    //AddressId=8,
                    //CompanyId=8
                },
                new User()
                {

                    Name= "Glenna Reichert",
                    UserName ="Delphine",
                    Email ="Chaim_McDermott@dana.io",
                    Phone ="(775)976-6794 x41206",
                    Website="conrad.com",
                    //AddressId=9,
                    //CompanyId=9
                },
                new User()
                {

                    Name= "Clementina DuBuque",
                    UserName ="Moriah.Stanton",
                    Email ="Rey.Padberg@karina.biz",
                    Phone ="024-648-3804",
                    Website="ambrose.net",
                    //AddressId=10,
                    //CompanyId=10
                },
            };
                foreach (User u in users)
                {
                    context.Users.Add(u);
                }
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Users ON;");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Users OFF;");
                transaction.Commit();
            }
        }
    }
}
