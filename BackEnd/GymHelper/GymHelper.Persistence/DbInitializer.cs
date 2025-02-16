using GymHelper.Model;
using System.Reflection;

namespace GymHelper.Persistence
{
    public class DbInitializer
    {
        public void Initialize()
        {
            DataContext dataContext = new DataContextFactory().CreateDbContext();
            dataContext.Database.EnsureCreated();

            UnitOfWork unitOfWork = new UnitOfWork(dataContext);

            if (unitOfWork.Coworkings.GetAll().Count() == 0)
            {
                #region Roles

                var adminRole = new Model.Role()
                {
                    RoleId = Roles.Admin,
                    Description = "Administrator",
                    Level = 0
                };
                unitOfWork.Roles.Add(adminRole);

                var GymHelperRole = new Model.Role()
                {
                    RoleId = Roles.GymHelper,
                    Description = "Coworking Manager",
                    Level = 1
                };
                unitOfWork.Roles.Add(GymHelperRole);

                var companyManagerRole = new Model.Role()
                {
                    RoleId = Roles.CompanyManager,
                    Description = "Company Manager",
                    Level = 2
                };
                unitOfWork.Roles.Add(companyManagerRole);

                var meetingManagerRole = new Model.Role()
                {
                    RoleId = Roles.MeetingManager,
                    Description = "Meeting Manager",
                    Level = 3
                };
                unitOfWork.Roles.Add(meetingManagerRole);

                #endregion

                #region Coworking

                var coworking = new Model.Coworking()
                {
                    Description = "Green Valley Coworking LTDA",
                    TaxCode = "32.768.724/0001-76",
                    ImageUrl = "/images/ocxVeXNBnuFoeKCb.jpeg",
                    Website = "https://greenvalleycoworking.com.br/",
                    Email = "contato@greenvalleycoworking.com.br",
                    PhoneNumber = "+55 31 88412646",
                    MeetingConfirmation = true,
                    Address = new Address()
                    {
                        Address1 = "Rua Cariri n.26",
                        Address2 = "Nova Suissa",
                        Address3 = "Sala 302",
                        Zip = "30421-239",
                        City = "BELO HORIZONTE",
                        State = "MINAS GERAIS",
                        Country = "Brasil"
                    }
                };
                unitOfWork.Coworkings.Add(coworking);

                #endregion

                #region Meeting room types

                unitOfWork.MeetingRoomTypes.Add(new MeetingRoomType() { Description = "Sala de reunião" });
                unitOfWork.MeetingRoomTypes.Add(new MeetingRoomType() { Description = "Cabine" });
                unitOfWork.MeetingRoomTypes.Add(new MeetingRoomType() { Description = "Mini-reunião" });
                unitOfWork.MeetingRoomTypes.Add(new MeetingRoomType() { Description = "Sala privativa" });
                unitOfWork.MeetingRoomTypes.Add(new MeetingRoomType() { Description = "Mesa de trabalho" });
                unitOfWork.MeetingRoomTypes.Add(new MeetingRoomType() { Description = "Open office" });

                #endregion

                #region Company

                Company company = new Company()
                {
                    CoworkingId = coworking.CoworkingId,
                    Description = "Atomos Hyla Informatica LTDA",
                    TaxCode = "32.132.444/0001-76",
                    ImageUrl = "/images/hUmpcXlEsNmCRaXi.jpeg",
                    Website = "https://atomoshyla.com.br",
                    Email = "massimiliano.papaleo@atomoshyla.com",
                    PhoneNumber = "+55 (11) 9 3202 8883",
                    Address = new Address()
                    {
                        Address1 = "Rua Cariri n.26",
                        Address2 = "Nova Suissa",
                        Address3 = "Sala 302",
                        Zip = "30421-239",
                        City = "BELO HORIZONTE",
                        State = "MINAS GERAIS",
                        Country = "Brasil"
                    }
                };
                unitOfWork.Companies.Add(company);

                #endregion

                #region Users

                var adminUser = new User()
                {
                    CompanyId = company.CompanyId,
                    Name = "Massimiliano",
                    Surname = "Papaleo",
                    PhoneNumber = "+55 (11) 9 3202 8883",
                    TaxCode = "117.396.701-08",
                    Email = "massimiliano.papaleo@atomoshyla.com",
                    ImageUrl = "/images/zxJnarvabTaNwhHN.jpeg",
                    EncryptedPassword = "1F-6F-A8-04-EE-71-59-1F-C8-10-54-E3-C2-F5-28-D5", // 123$abc!
                    Address = new Address()
                    {
                        Address1 = "Rua Cariri n.26",
                        Address2 = "Nova Suissa",
                        Address3 = "Sala 306",
                        Zip = "30421-239",
                        City = "BELO HORIZONTE",
                        State = "MINAS GERAIS",
                        Country = "Brasil"
                    },
                    Coworkings = new List<Coworking>()
                    {
                        coworking
                    },
                    Roles = new List<Role>()
                    {
                        companyManagerRole
                    }
                };

                unitOfWork.Users.Add(adminUser);

                var GymHelperUser = new User()
                {
                    CompanyId = company.CompanyId,
                    Name = "Guilherme",
                    Surname = "Maciel",
                    PhoneNumber = "+55 (31) 9296 0516",
                    TaxCode = "117.396.701-08",
                    Email = "guilherme.maciel@atomoshyla.com",
                    ImageUrl = "/images/GkEBYMousnHWKBkY.jpeg",
                    EncryptedPassword = "6F-FC-53-7B-89-D4-7A-99-D1-85-D8-88-30-A2-1E-C1", // 123$abc!
                    Address = new Address()
                    {
                        Address1 = "Rua Cariri n.26",
                        Address2 = "Nova Suissa",
                        Address3 = "Sala 306",
                        Zip = "30421-239",
                        City = "BELO HORIZONTE",
                        State = "MINAS GERAIS",
                        Country = "Brasil"
                    },
                    Coworkings = new List<Coworking>()
                    {
                        coworking
                    },
                    Roles = new List<Role>()
                    {
                        GymHelperRole
                    }
                };

                unitOfWork.Users.Add(GymHelperUser);

                var companyManagerUser = new User()
                {
                    CompanyId = company.CompanyId,
                    Name = "Maria",
                    Surname = "Almeida",
                    PhoneNumber = "+55 (31) 8463 8580",
                    TaxCode = "117.396.701-08",
                    Email = "mariaedealmeida7@gmail.com",
                    ImageUrl = "/images/FDARnuKwHeZmYBKI.jpeg",
                    EncryptedPassword = "82-37-F8-A8-C8-0E-D9-33-F3-E2-4A-EE-CA-87-8B-8E", // 123$abc!
                    Address = new Address()
                    {
                        Address1 = "Rua Cariri n.26",
                        Address2 = "Nova Suissa",
                        Address3 = "Sala 306",
                        Zip = "30421-239",
                        City = "BELO HORIZONTE",
                        State = "MINAS GERAIS",
                        Country = "Brasil"
                    },
                    Coworkings = new List<Coworking>()
                    {
                        coworking
                    },
                    Roles = new List<Role>()
                    {
                        adminRole
                    }
                };

                unitOfWork.Users.Add(companyManagerUser);

                var meetingManagerUser = new User()
                {
                    CompanyId = company.CompanyId,
                    Name = "Lorenzo",
                    Surname = "Ribeiro",
                    PhoneNumber = "+55 (31) 7151 1181",
                    TaxCode = "117.396.701-08",
                    Email = "lorenzo.ribeiro@atomoshyla.com",
                    ImageUrl = "/images/mVDrRdopbpNpMtqm.jpeg",
                    EncryptedPassword = "6B-E3-3B-D8-FC-C5-C3-36-D6-64-6D-17-02-BE-78-45", // 123$abc!
                    Address = new Address()
                    {
                        Address1 = "Rua Cariri n.26",
                        Address2 = "Nova Suissa",
                        Address3 = "Sala 306",
                        Zip = "30421-239",
                        City = "BELO HORIZONTE",
                        State = "MINAS GERAIS",
                        Country = "Brasil"
                    },
                    Coworkings = new List<Coworking>()
                    {
                        coworking
                    },
                    Roles = new List<Role>()
                    {
                        meetingManagerRole
                    }
                };

                unitOfWork.Users.Add(meetingManagerUser);

                #endregion

                #region Pages

                unitOfWork.Pages.Add(new Page()
                {
                    PageId = "terms-of-service",
                    Title = "Terms of Service",
                    Body = "These are the terms of service"
                });

                #endregion

                unitOfWork.ExecuteSql(GetScript("AddressData.sql"));
            }
            unitOfWork.Save();
        }

        protected string GetScript(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "GymHelper.Persistence.Data." + fileName;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
