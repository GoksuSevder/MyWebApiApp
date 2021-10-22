//using Microsoft.EntityFrameworkCore;
//using MyWebApiApp.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyWebApi.DataAccess.Concrete
//{
//    public static class SeedDatabase
//    {
//        public static void Seed()
//        {
//            var context = new MyWebApiAppContext();
//            if (context.Database.GetPendingMigrations().Count() == 0)
//            {
//                if (context.Users.Count() == 0)
//                {
//                    context.Users.AddRange(Users); 
//                    context.SaveChanges();
//                }
//                if (context.Addresses.Count() == 0)
//                {
//                    context.Addresses.AddRange(Addresses);
//                    context.SaveChanges();
//                }
//                if (context.Geos.Count() == 0)
//                {
//                    context.Geos.AddRange(Geos);
//                    context.SaveChanges();
//                }
//                if (context.Companies.Count() == 0)
//                {
//                    context.Companies.AddRange(Companies);
//                    context.SaveChanges();
//                }
//            }

//        }
//        private static User[] Users =
//         {
//            new User()
//            {
               
//                Name="Leanne Graham",
//                UserName ="Bret",
//                Email ="Sincere@april.biz",
//                Phone ="1-770-736-8031 x56442",
//                Website="hildegard.org"

//            },
//            new User()
//            {
                
//                Name="Ervin Howell",
//                UserName ="Antonette",
//                Email ="Shanna@melissa.tv",
//                Phone ="010-692-6593 x09125",
//                Website="anastasia.net"
//            },
//            new User()
//            {
               
//                Name="Clementine Bauch",
//                UserName ="Samantha",
//                Email ="Nathan@yesenia.net",
//                Phone ="1-463-123-4447",
//                Website="ramiro.info"
//            },
//            new User()
//            {
               
//                Name="Patricia Lebsack",
//                UserName ="Karianne",
//                Email ="Julianne.OConner@kory.org",
//                Phone ="493-170-9623 x156",
//                Website="kale.biz",
//            },
//            new User()
//            {
               
//                Name="Chelsey Dietrich",
//                UserName = "Kamren",
//                Email ="Lucio_Hettinger@annie.ca",
//                Phone ="(254)954-1289",
//                Website="demarco.info"
//            },
//            new User()
//            {
               
//                Name="Mrs. Dennis Schulist",
//                UserName = "Leopoldo_Corkery",
//                Email = "Karley_Dach@jasper.info",
//                Phone ="1-477-935-8478 x6430",
//                Website="ola.org"
//            },
//            new User()
//            {
               
//                Name="Kurtis Weissnat",
//                UserName = "Elwyn.Skiles",
//                Email = "Telly.Hoeger@billy.biz",
//                Phone ="210.067.6132",
//                Website="elvis.io"
//            },
//            new User()
//            {
               
//                Name="Nicholas Runolfsdottir V",
//                UserName = "Maxime_Nienow",
//                Email ="Sherwood@rosamond.me",
//                Phone ="586.493.6943 x140",
//                Website="jacynthe.com"
//            },
//            new User()
//            {
               
//                Name= "Glenna Reichert",
//                UserName ="Delphine",
//                Email ="Chaim_McDermott@dana.io",
//                Phone ="(775)976-6794 x41206",
//                Website="conrad.com"
//            },
//            new User()
//            {
               
//                Name= "Clementina DuBuque",
//                UserName ="Moriah.Stanton",
//                Email ="Rey.Padberg@karina.biz",
//                Phone ="024-648-3804",
//                Website="ambrose.net"
//            },
//        };
//        private static Address[] Addresses =
//        {
//            new Address {
                
//                Street="Kulas Light",
//                Suite="Apt. 556",
//                City ="Gwenborough",
//                Zipcode="92998-3874",
//                UserId=Users.Single(i =>i.Name=="Leanne Graham").Id
//            },
//            new Address{
                
//                Street="Victor Plains",
//                Suite="Suite 879",
//                City ="Wisokyburgh",
//                Zipcode="90566-7771",
//                UserId=Users.Single(i =>i.Name=="Ervin Howell").Id
//            },
//            new Address{
                
//                Street="Douglas Extension",
//                Suite="Suite 847",
//                City ="McKenziehaven",
//                Zipcode="59590-4157",
//                UserId=Users.Single(i =>i.Name=="Clementine Bauch").Id
//            },
//            new Address{
                
//                Street="Hoeger Mall",
//                Suite="Apt. 692",
//                City = "South Elvis",
//                Zipcode= "53919-4257",
//                UserId=Users.Single(i =>i.Name=="Patricia Lebsack").Id
//            },
//            new Address{
                
//                Street="Skiles Walks",
//                Suite="Suite 351",
//                City = "Roscoeview",
//                Zipcode= "33263",
//                UserId=Users.Single(i =>i.Name=="Chelsey Dietrich").Id
//            },
//            new Address{
               
//                Street="Norberto Crossing",
//                Suite= "Apt. 950",
//                City = "South Christy",
//                Zipcode= "23505-1337",
//                UserId=Users.Single(i =>i.Name=="Mrs. Dennis Schulist").Id
//            },
//            new Address{
//                Id=7,
//                Street="Rex Trail",
//                Suite= "Suite 280",
//                City = "Howemouth",
//                Zipcode= "58804-1099",
//                UserId=Users.Single(i =>i.Name=="Kurtis Weissnat").Id
//            },
//            new Address{
               
//                Street="Ellsworth Summit",
//                Suite= "Suite 729",
//                City = "Aliyaview",
//                Zipcode= "45169",
//                UserId=Users.Single(i =>i.Name=="Nicholas Runolfsdottir V").Id
//            },
//            new Address{
              
//                Street="Dayna Park",
//                Suite= "Suite 449",
//                City = "Bartholomebury",
//                Zipcode="76495-3109",
//                UserId=Users.Single(i =>i.Name=="Glenna Reichert").Id
//            },
//            new Address{
                
//                Street="Kattie Turnpike",
//                Suite= "Suite 198",
//                City ="Lebsackbury",
//                Zipcode= "31428-2261",
//                UserId=Users.Single(i =>i.Name=="Clementina DuBuque").Id
//            }
//        };       // Addresses.Single(i => i.UserId==).Id
//        private static Geo[] Geos =
//        {
//             new Geo(){
//                        Lat=-37.3159,
//                        Lng=81.1496,
                     
//             },
//             new Geo(){
//                        Lat=-43.9509,
//                        Lng=-34.4618,
                      
//             },
//             new Geo(){
//                        Lat=-68.6102,
//                        Lng=-47.0653,
                     
//             },
//             new Geo(){
//                        Lat=-29.4572,
//                        Lng=-164.2990,
                      
//             },
//             new Geo(){
//                        Lat=-31.8129,
//                        Lng=62.5342,
                      
//             },
//             new Geo(){
//                        Lat=-71.4197,
//                        Lng=71.7478,
                    
//             },
//             new Geo(){
//                        Lat=24.8918,
//                        Lng=21.8984,
                  
//             },
//             new Geo(){
//                        Lat=-14.3990,
//                        Lng=-120.7677,

//             },
//             new Geo(){
//                        Lat=24.6463,
//                        Lng=-168.8889,
                       
//             },
//             new Geo(){
//                        Lat=-38.2386,
//                        Lng=57.2232,
                    
//             }
//        };
//        private static Company[] Companies =
//        {
//           new Company{
//                        Name="Romaguera-Crona",
//                        CatchPhrase="Multi-layered client-server neural-net",
//                        Bs ="harness real-time e-markets",
//                        UserId=Users.Single(i =>i.Name=="Leanne Graham").Id
//           },
//           new Company{
//                        Name="Deckow-Crist",
//                        CatchPhrase="Proactive didactic contingency",
//                        Bs ="synergize scalable supply-chains",
//                        UserId=Users.Single(i =>i.Name=="Ervin Howell").Id
//           },
//           new Company{
//                        Name="Romaguera-Jacobson",
//                        CatchPhrase="Face to face bifurcated interface",
//                        Bs = "e-enable strategic applications",
//                        UserId=Users.Single(i =>i.Name=="Clementine Bauch").Id
//           },
//           new Company{
//                        Name="Robel-Corkery",
//                        CatchPhrase="Multi-tiered zero tolerance productivity",
//                        Bs = "transition cutting-edge web services",
//                        UserId=Users.Single(i =>i.Name=="Patricia Lebsack").Id
//           },
//           new Company{
//                        Name="Keebler LLC",
//                        CatchPhrase="User-centric fault-tolerant solution",
//                        Bs ="revolutionize end-to-end systems",
//                        UserId=Users.Single(i =>i.Name=="Chelsey Dietrich").Id
//           },
//           new Company{
//                        Name="Considine-Lockman",
//                        CatchPhrase="Synchronised bottom-line interface",
//                        Bs ="e-enable innovative applications",
//                        UserId=Users.Single(i =>i.Name=="Mrs. Dennis Schulist").Id
//           },
//           new Company{
//                        Name= "Johns Group",
//                        CatchPhrase="Configurable multimedia task-force",
//                        Bs ="e-enable innovative applications",
//                        UserId=Users.Single(i =>i.Name=="Kurtis Weissnat").Id
//           },
//           new Company{
//                        Name= "Abernathy Group",
//                        CatchPhrase="Implemented secondary concept",
//                        Bs ="e-enable extensible e-tailers",
//                        UserId=Users.Single(i =>i.Name=="Nicholas Runolfsdottir V").Id
//           },
//           new Company{
//                        Name= "Yost and Sons",
//                        CatchPhrase="Switchable contextually-based project",
//                        Bs ="aggregate real-time technologies",
//                        UserId=Users.Single(i =>i.Name=="Glenna Reichert").Id
//           },
//           new Company{
//                        Name= "Hoeger LLC",
//                        CatchPhrase= "Centralized empowering task-force",
//                        Bs ="target end-to-end models",
//                        UserId=Users.Single(i =>i.Name=="Clementina DuBuque").Id
//           }
//        };
//    }
//}
