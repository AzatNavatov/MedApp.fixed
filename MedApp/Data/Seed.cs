using MedApp.Models;
using System.Diagnostics;
using MedApp.Data.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace MedApp.Data;

public class Seed
{
    public static void SeedData(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();

            if (!context.Admin.Any())
            {
                context.Admin.AddRange(new List<Admin>()
                {
                    new Admin()
                    {
                        Person = new Person()
                        {
                            FirstName = "Azat",
                            LastName = "Navatov",
                            Gender = Gender.Male,
                            Age = 25,
                            Address = new Address()
                            {
                                Street = "Yugo-Vostok",
                                City = "Osh"
                            }
                        }
                        
                    },
                });
                context.SaveChanges();
            }
            if (!context.Registrators.Any())
            {
                context.Registrators.AddRange(new List<Registrator>()
                {
                    new Registrator()
                    {
                        Person = new Person()
                        {
                            FirstName = "Nurdin",
                            LastName = "Kadyrov",
                            Gender = Gender.Male,
                            Age = 25,
                            Address = new Address()
                            {
                                Street = "Aravan",
                                City = "Osh"
                            }
                        }

                    },
                });
                context.SaveChanges();
            }
            if (!context.Doctors.Any())
            {
                context.Doctors.AddRange(new List<Doctor>()
                {
                    new Doctor()
                    {
                        Person = new Person()
                        {
                            FirstName = "Erhan",
                            LastName = "Mamadyev",
                            Gender = Gender.Male,
                            Age = 25,
                            Address = new Address()
                            {
                                Street = "Furkat",
                                City = "Osh",
                            }
                        },
                        Image =
                            "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",

                        Speciality = SpecialityType.Surgeon
                    },
                    new Doctor()
                    {
                        Person = new Person()
                        {
                            FirstName = "John",
                            LastName = "Taylor",
                            Gender = Gender.Male,
                            Age = 30,
                            Address = new Address()
                            {
                                Street = "Mira 83",
                                City = "Bishkek"
                            }
                        },
                        Image =
                            "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",

                        Speciality = SpecialityType.Surgeon
                    },

                });
                context.SaveChanges();
            }

            //Races
            if (!context.Patients.Any())
            {
                context.Patients.AddRange(new List<Patient>()
                {
                    new Patient()
                    {
                        Person = new Person()
                        {
                            FirstName = "Bayaman",
                            LastName = "Abdullaev",
                            Gender = Gender.Male,
                            Age = 25,
                            Address = new Address()
                            {
                                Street = "8 mkr 18",
                                City = "Bishkek"
                            }
                        },
                        Image =
                            "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Card = new MedicalCard()
                        {
                            Diagnosis = Diagnosys.Caries,
                            Allergy = false

                        }
                    },
                    new Patient()
                    {
                        Person = new Person()
                        {
                            FirstName = "Aydar",
                            LastName = "Abakir",
                            Gender = Gender.Male,
                            Age = 25,
                            Address = new Address()
                            {
                                Street = "Asanbai",
                                City = "Bishkek"
                            }
                        },
                        Image =
                            "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Card = new MedicalCard()
                        {
                            Diagnosis = Diagnosys.Myopia,
                            Allergy = true

                        }
                    },
                });
                context.SaveChanges();
            }
        }
    }
}