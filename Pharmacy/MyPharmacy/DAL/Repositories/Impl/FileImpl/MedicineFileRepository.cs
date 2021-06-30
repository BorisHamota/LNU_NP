﻿using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories.Abstract;
using System;
using System.IO;

namespace MyPharmacy.DAL.Repositories.Impl.FileImpl
{
    public class MedicineFileRepository : BaseFileRepository<Medicine>, IMedicineRepository
    {
        protected readonly string filePath;
        protected readonly char delim;
        public MedicineFileRepository()
        {
            filePath = @"C:\Users\volod\source\Lnu_VS\Individual\MyPharmacy\MyPharmacy\DAL\Files\medicineTable.txt";
            //filePath = $"{Directory.GetCurrentDirectory()}\\DAL\\Files\\medicineTable.txt";
            delim = ',';
            ReadItemsFromFile();
        }
        protected override void ReadItemsFromFile()
        {
            using (var streamReader = new StreamReader(filePath))
            {
                ReadItemsFromStream(streamReader);
            }
        }
        public override Medicine ConvertToObject(string[] strObjItems)
        {
            int fieldsCount = 5;
            if (strObjItems.Length != fieldsCount)
            {
                throw new Exception("Line is in incorrect format!");
            }
            return new Medicine(Convert.ToInt32(strObjItems[0]), strObjItems[1], strObjItems[2], Convert.ToInt32(strObjItems[3]), Convert.ToInt32(strObjItems[4]));
        }
        protected override void ReadItemsFromStream(StreamReader streamReader)
        {
            string fileLine;
            Init();

            while ((fileLine = streamReader.ReadLine()) != null)
            {

                if (fileLine == string.Empty)
                    break;

                string[] strObjItems = fileLine.Split(delim);
                entities.Add(ConvertToObject(strObjItems));

            }
        }
        public override void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                foreach (var it in entities)
                {
                    streamWriter.WriteLine($"{it.Id},{it.expirationDate},{it.name},{it.amount},{it.storageTemperature}");
                }
            }
        }
    }
}
