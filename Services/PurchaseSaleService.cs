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
                            FirstName = "Alyssa",
                            LastName = "LeMay",
                            Address = new Model.Address
                            {
                                Address1 = "5545 Somewhere St",
                                City = "Vale",
                                State = "NH",
                                County = "Jefferson",
                                ZipCode = 542545
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "3252323232",
                                Email = "test@mailinator.com"
                            }
                        },
                        Seller = new Model.Seller
                        {
                            SellerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Kevin",
                            LastName = "Dalphonse",
                            Address = new Model.Address
                            {
                                Address1 = "5545 Someplace St",
                                City = "Vale",
                                State = "CO",
                                County = "Aaraphoe",
                                ZipCode = 842545
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "3252323232",
                                Email = "test@mailinator.com"
                            }
                        }
                    };
                case "test2":
                    return new PurchaseSaleModel
                    {
                        Borrower = new Model.Borrower
                        {
                            BorrowerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Kevin",
                            LastName = "Dalphonse",
                            Address = new Model.Address
                            {
                                Address1 = "5545 Someplace St",
                                City = "Vale",
                                State = "CO",
                                County = "Denver",
                                ZipCode = 842545
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "3252323232",
                                Email = "test@mailinator.com"
                            }
                        },
                        Seller = new Model.Seller
                        {
                            SellerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Justin",
                            LastName = "Collin",
                            Address = new Model.Address
                            {
                                Address1 = "5545 SomewhereNice St",
                                City = "Dallas",
                                State = "TX",
                                County = "Collin",
                                ZipCode = 952545
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "3252323232",
                                Email = "test@mailinator.com"
                            }
                        }
                    };
                default:
                    return new PurchaseSaleModel
                    {
                        Borrower = new Model.Borrower
                        {
                            BorrowerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Justin",
                            LastName = "Collin",
                            Address = new Model.Address
                            {
                                Address1 = "5545 SomewhereNice St",
                                City = "Dallas",
                                State = "TX",
                                County = "Fortworth",
                                ZipCode = 952545
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "3252323232",
                                Email = "test@mailinator.com"
                            }
                        },

                        Seller = new Model.Seller
                        {
                            SellerType = Model.SellerBorrowerType.Individual.ToString(),
                            FirstName = "Kevin",
                            LastName = "Dalphonse",
                            Address = new Model.Address
                            {
                                Address1 = "5545 Someplace St",
                                City = "Vale",
                                State = "CO",
                                ZipCode = 842545,
                                County = "Denver",
                            },
                            Contacts = new Model.Contacts
                            {
                                CellPhone = "3252323232",
                                Email = "test@mailinator.com"
                            }
                        }
                    };
            }
        }
    }
}
