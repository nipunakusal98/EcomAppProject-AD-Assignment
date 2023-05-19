using EcomApp.Data;
using EcomAppProject.Data.Enums;
using EcomAppProject.Models;
using System;

namespace EcomAppProject.Data
{
    public class AppDbInitializer
    {
       
            public static void Seed(IApplicationBuilder applicationBuilder)
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                    context.Database.EnsureCreated();

                    //Customer
                    if (!context.Customers.Any())
                    {
                        context.Customers.AddRange(new List<Customer>() {
                            //Code Goes Here
                            
                            new Customer()
                            {
                                FirstName = "Nipuna",
                                LastName = "Kusal",
                                Email = "nipunakusal98@gmail.com",
                                Password = "1234",
                                Phone = "1234567890"
                            },

                            new Customer()
                            {
                                FirstName = "John",
                                LastName = "Doe",
                                Email = "john.doe@example.com",
                                Password = "1234",
                                Phone = "1234567890"
                            },

                            new Customer()
                            {
                                FirstName = "Bill",
                                LastName = "murry",
                                Email = "bill.murry@example.com",
                                Password = "1234",
                                Phone = "1234567890"
                            }

                        });
                    

                    
                        context.SaveChanges();

                    }


                //Employee
                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(new List<Employee>() {
                        new Employee() 
                        {
                            EmployeeName="Admin",
                            EmployeeEmail="Admin@admin.com",
                            EmployeePassword="1234",
                            EmployeeType= EmployeeType.Admin
                        },
                          new Employee()
                        {
                            EmployeeName="Employee",
                            EmployeeEmail="Employee@employee.com",
                            EmployeePassword="1234",
                            EmployeeType= EmployeeType.Employee
                        }
                    });
                    

                    context.SaveChanges();

                }

                //Category
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>() {
                        new Category() 
                        {
                            CategoryName="Desktop",
                            CategoryPictureURL="https://images.easytechjunkie.com/slideshow-mobile-small/black-desktop-computer.jpg"
                        },

                        new Category()
                        {
                            CategoryName="Laptop",
                            CategoryPictureURL="https://images.easytechjunkie.com/slideshow-mobile-small/black-desktop-computer.jpg"
                        }
                    });
                    

                    context.SaveChanges();

                }

                //Series
                if (!context.Series.Any())
                {
                    context.Series.AddRange(new List<Series>() {
                        new Series()
                        {
                            SeriesName="Home Premium",
                            SeriesPictureURL="",
                            CategoryID=2

                        },

                         new Series()
                        {
                            SeriesName="Business Plus",
                            SeriesPictureURL="",
                            CategoryID=2

                        },

                         new Series()
                        {
                            SeriesName="Gamer",
                            SeriesPictureURL="",
                            CategoryID=2

                        },

                          new Series()
                        {
                            SeriesName="Budget PC",
                            SeriesPictureURL="",
                            CategoryID=1

                        },

                            new Series()
                        {
                            SeriesName="Gaming PC",
                            SeriesPictureURL="",
                            CategoryID=1

                        }


                    });


                    context.SaveChanges();

                }

                //AntivirusSoftware
                if (!context.AntivirusSoftwares.Any())
                {
                    context.AntivirusSoftwares.AddRange(new List<AntivirusSoftware>() {
                        new AntivirusSoftware() 
                        {
                            AntivirusDescription="Avast Home Security",
                            AntivirusPrice=100
                        },

                         new AntivirusSoftware()
                        {
                            AntivirusDescription="McAfee Home Security",
                            AntivirusPrice=200
                        },

                          new AntivirusSoftware()
                        {
                            AntivirusDescription="windows defender Security",
                            AntivirusPrice=300
                        }
                    });
                    

                    context.SaveChanges();

                }

                //Memory
                if (!context.Memories.Any())
                {
                    context.Memories.AddRange(new List<Memory>() {
                        new Memory() 
                        {
                            MemoryDescription="8GB DDR4 RAM",
                            MemoryPictureURL="",
                            MemoryPrice=100
                        },

                        new Memory()
                        {
                            MemoryDescription="4GB DDR4 RAM",
                            MemoryPictureURL="",
                            MemoryPrice=200
                        },
                        new Memory()
                        {
                            MemoryDescription="8GB DDR3 RAM",
                            MemoryPictureURL="",
                            MemoryPrice=300
                        }
                    });
                    //Code Goes Here

                    context.SaveChanges();

                }

                //Processor
                if (!context.Processors.Any())
                {
                    context.Processors.AddRange(new List<Processor>() {
                        new Processor() 
                        {
                            ProcessorDescription="2nd generation Intel Core i7-2860QM",
                            ProcessorPictureURL="",
                            ProcessorPrice=100  
                        },
                        new Processor()
                        {
                            ProcessorDescription="Intel Core i5-8400",
                            ProcessorPictureURL="",
                            ProcessorPrice=200
                        },
                        new Processor()
                        {
                            ProcessorDescription="AMD Ryzen 7 3700X",
                            ProcessorPictureURL="",
                            ProcessorPrice=300
                        }

                    });
                    //Code Goes Here

                    context.SaveChanges();

                }

                //VGA
                if (!context.VGAs.Any())
                {
                    context.VGAs.AddRange(new List<VGA>() {
                        new VGA()
                        {
                            VGADescription="NVIDIA GeForce GTX 1650 4GB GDDR5",
                            VGAPictureURL="",
                            VGAPrice=100
                        },
                        new VGA()
                        {
                            VGADescription="NVIDIA GeForce GTX 3452 6GB GDDR5",
                            VGAPictureURL="",
                            VGAPrice=200
                        },
                        new VGA()
                        {
                             VGADescription="NVIDIA GeForce GTX 3452 8GB GDDR5",
                            VGAPictureURL="",
                            VGAPrice=300
                        }
                    });
                    //Code Goes Here

                    context.SaveChanges();

                }

                ////Model
                //if (!context.Models.Any())
                //{
                //    context.Models.AddRange(new List<Model>() {
                //        new Model() 
                //        {
                //            ModelName="Home Premium 2000",
                //            ModelPictureURL="",
                            
                //        }
                //    });
                //    //Code Goes Here

                //    context.SaveChanges();

                //}

                ////CustomerConfiguration
                //if (!context.CustomerConfigurations.Any())
                //{
                //    context.CustomerConfigurations.AddRange(new List<CustomerConfiguration>() { });
                //    //Code Goes Here

                //    context.SaveChanges();

                //}

                ////CustomerConfiguredModelOrder
                //if (!context.CustomerConfiguredModelOrders.Any())
                //{
                //    context.CustomerConfiguredModelOrders.AddRange(new List<CustomerConfiguredModelOrder>() { });
                //    //Code Goes Here

                //    context.SaveChanges();

                //}

                ////CustomerConfiguredModelPayment
                //if (!context.CustomerConfiguredModelPayments.Any())
                //{
                //    context.CustomerConfiguredModelPayments.AddRange(new List<CustomerConfiguredModelPayment>() { });
                //    //Code Goes Here

                //    context.SaveChanges();

                //}

                ////Order
                //if (!context.Orders.Any())
                //{
                //    context.Orders.AddRange(new List<Order>() { });
                //    //Code Goes Here

                //    context.SaveChanges();

                //}

                ////Payment
                //if (!context.Payments.Any())
                //{
                //    context.Payments.AddRange(new List<Payment>() { });
                //    //Code Goes Here

                //    context.SaveChanges();

                //}






            }
        }
        }
}
