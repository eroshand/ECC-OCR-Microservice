using ECC_OCR_Microservice.Dtos;
using ECC_OCR_Microservice.Model.PurchaseSale;
using ECC_OCR_Microservice.Services.Interfaces;

namespace ECC_OCR_Microservice.Services
{
    public class PurchaseSaleService : IPurchaseSaleService
    {
        public async Task<PurchaseSaleModel> ReadFileAsync(FileUploadRequestDto fileUploadRequestDto)
        {
            var fileName = fileUploadRequestDto.FileName;
            return GetPurchaseSaleModelBasedOnFileType(fileName.Split(".")[0]);
        }
        public PurchaseSaleModel GetPurchaseSaleModelBasedOnFileType(string fileName)
        {
            switch (fileName)
            {
                case "test1":
                    return new PurchaseSaleModel
                    {
                        Borrower = new Model.Borrower
                        {
                            BorrowerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Kenny",
                            LastName = "Chesney",
                            CurrentDeedInformation = "Book 6 Page 3",
                            PurchasePrice = 540000,
                            Deposit = 20000,
                            CloseDate = DateTime.Now.AddDays(8),
                            LoanAmount = 425000,
                            MortgageContigencyDate = DateTime.UtcNow.AddDays(60),
                            Address = new Model.Address
                            {
                                Address1 = "717 General Kershaw Dr",
                                City = "Key West",
                                State = "Florida",
                                County = "Jefferson",
                                ZipCode = 33040
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "305-433-9730",
                                Email = "jim.bh@mailinator.com"
                            },
                            Attorney = new Model.Attorney
                            {
                                FirstName = "Samuel",
                                LastName = "Kaufman",
                                Company = "The Law Office.",
                                Address = new Model.Address
                                {
                                    Address1 = "3130 Overseas Hwy"
                                },
                                Contacts = new Model.Contacts
                                {
                                    CellPhone = "305-292-3926",
                                    Email = "samuel.kaufman@mailinator.com"
                                }

                            },
                        },
                        Seller = new Model.Seller
                        {
                            SellerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Jimmy",
                            LastName = "Buffett",
                            Attorney = new Model.Attorney
                            {
                                FirstName = "John",
                                LastName = "Smith",
                                Company = "Morgan and Morgan",
                                Address = new Model.Address
                                {
                                    Address1 = "30338 Overseas Hwy"
                                },
                                Contacts = new Model.Contacts
                                {
                                    CellPhone = "305-433-9730",
                                    Email = "john.smith@mailinator.com"
                                }
                                
                            },
                            Address = new Model.Address
                            {
                                Address1 = "819 Elizabeth St",
                                City = "Key West",
                                State = "Florida",
                                County = "Jefferson",
                                ZipCode = 33040
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "305-433-9730",
                                Email = "john.smith@mailinator.com"
                            }
                        }
                    };
                case "test2":
                    return new PurchaseSaleModel
                    {
                        Borrower = new Model.Borrower
                        {
                            BorrowerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Kenny",
                            LastName = "Chesney",
                            CurrentDeedInformation = "Book 6 Page 3",
                            PurchasePrice = 540000,
                            Deposit = 20000,
                            CloseDate = DateTime.Now.AddDays(8),
                            LoanAmount = 425000,
                            MortgageContigencyDate = DateTime.UtcNow.AddDays(60),
                            Address = new Model.Address
                            {
                                Address1 = "717 General Kershaw Dr",
                                City = "Key West",
                                State = "Florida",
                                County = "Jefferson",
                                ZipCode = 33040
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "305-433-9730",
                                Email = "jim.bh@mailinator.com"
                            },
                            Attorney = new Model.Attorney
                            {
                                FirstName = "Samuel",
                                LastName = "Kaufman",
                                Company = "The Law Office.",
                                Address = new Model.Address
                                {
                                    Address1 = "3130 Overseas Hwy"
                                },
                                Contacts = new Model.Contacts
                                {
                                    CellPhone = "305-292-3926",
                                    Email = "samuel.kaufman@mailinator.com"
                                }

                            },
                        },
                        Seller = new Model.Seller
                        {
                            SellerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Sydney",
                            LastName = "Fife",
                            Attorney = new Model.Attorney
                            {
                                FirstName = "John",
                                LastName = "Smith",
                                Company = "Morgan and Morgan",
                                Address = new Model.Address
                                {
                                    Address1 = "100 Main St"
                                },
                                Contacts = new Model.Contacts
                                {
                                    CellPhone = "305-433-9730",
                                    Email = "john.smith@mailinator.com"
                                }

                            },
                            Address = new Model.Address
                            {
                                Address1 = "819 Elizabeth St",
                                City = "Key West",
                                State = "Florida",
                                County = "Jefferson",
                                ZipCode = 33040
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "305-433-9730",
                                Email = "john.smith@mailinator.com"
                            }
                        }
                    };
                default:
                    return new PurchaseSaleModel
                    {
                        Borrower = new Model.Borrower
                        {
                            BorrowerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Peter",
                            LastName = "Klavin",
                            CurrentDeedInformation = "Book 15 Page 2",
                            PurchasePrice = 200100,
                            Deposit = 1000,
                            CloseDate = DateTime.Now.AddDays(6),
                            LoanAmount = 115000,
                            MortgageContigencyDate = DateTime.UtcNow.AddDays(-18),
                            Broker = new Model.Broker
                            {
                                FirstName = "Keller",
                                LastName = "Williams"
                            },
                            Address = new Model.Address
                            {
                                Address1 = "862 Mountain Rd",
                                City = "Key West",
                                State = "Florida",
                                County = "Jefferson",
                                ZipCode = 33040
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "305-433-9730",
                                Email = "jim.bh@mailinator.com"
                            },
                            Attorney = new Model.Attorney
                            {
                                FirstName = "Heather",
                                LastName = "DeLanoy",
                                Company = "Sweeney and Sweeney",
                                Address = new Model.Address
                                {
                                    Address1 = "6 Manchester St."
                                },
                                Contacts = new Model.Contacts
                                {
                                    CellPhone = "603-883-0711",
                                    Email = "heather@mailinator.com"
                                }

                            },
                        },
                        Seller = new Model.Seller
                        {
                            SellerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Jimmy",
                            LastName = "Buffett",
                            Broker = new Model.Broker
                            {
                                CompanyName = "Century 21"
                            },
                            PropertyAddress = new Model.Address
                            {
                                Address1 = "100 Main St ",
                                City = "Key West",
                                State = "Florida"
                            },
                            Attorney = new Model.Attorney
                            {
                                FirstName = "Julia",
                                LastName = "Foy",
                                Company = "Foy Law Office",
                                Address = new Model.Address
                                {
                                    Address1 = "402 Amherst Rd"
                                },
                                Contacts = new Model.Contacts
                                {
                                    CellPhone = "603-598-4030",
                                    Email = "julia.foy@mailinator.com"
                                }

                            },
                            Address = new Model.Address
                            {
                                Address1 = "819 Elizabeth St",
                                City = "Key West",
                                State = "Florida",
                                County = "Jefferson",
                                ZipCode = 33040
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "305-433-9730",
                                Email = "john.smith@mailinator.com"
                            }
                        }
                    };
            }
        }
    }
}
