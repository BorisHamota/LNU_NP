using MyPharmacy.DAL.Modules.Impl;
using System.Collections.Generic;

namespace MyPharmacy.DAL.Repositories
{
    public static class InitialDataLoader
    {
        public static List<Medicine> InitializeMedicineRepository()
        {
            List<Medicine> entities = new List<Medicine>();
            entities.Add(new Medicine()
            {
                Id = 65366,
                name = "Ibuprofen",
                amount = 43,
                expirationDate = "21.12.2030",
                storageTemperature = 42
            });
            entities.Add(new Medicine()
            {
                Id = 12344,
                name = "Xanax",
                amount = 22,
                expirationDate = "01.04.2023",
                storageTemperature = 453
            });
            entities.Add(new Medicine()
            {
                Id = 63250,
                name = "Naproxen",
                amount = 34,
                expirationDate = "14.03.2023",
                storageTemperature = 1
            });
            entities.Add(new Medicine()
            {
                Id = 36544,
                name = "Ciprofloxacin",
                amount = 3,
                expirationDate = "30.03.2150",
                storageTemperature = 12
            });
            return entities;
        }
        public static List<Cosmetic> InitializeCosmeticRepository()
        {
            List<Cosmetic> entities = new List<Cosmetic>();
            entities.Add(new Cosmetic()
            {
                Id = 13356,
                name = "Jardiance",
                amount = 43,
                capacity = 243,
                expirationDate = "04.12.2023",
                storageTemperature = 42
            });
            entities.Add(new Cosmetic()
            {
                Id = 34556,
                name = "Onpattro",
                amount = 22,
                capacity = 23,
                expirationDate = "05.03.2040",
                storageTemperature = 453
            });
            entities.Add(new Cosmetic()
            {
                Id = 65536,
                name = "Januvia",
                amount = 3,
                capacity = 98,
                expirationDate = "21.11.2099",
                storageTemperature = 12
            });
            entities.Add(new Cosmetic()
            {
                Id = 64350,
                name = "Caudalie",
                amount = 33,
                capacity = 21,
                expirationDate = "14.03.2025",
                storageTemperature = 88
            });
            return entities;
        }
    }
}
