using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories.Abstract;
using System;
using System.IO;

namespace MyPharmacy.DAL.Repositories.Impl.FileImpl
{
    public class CartFileRepository : BaseFileRepository<Flyweight>, ICartRepositoty
    {
        readonly private string filePath;
        readonly private char delim;
        public CartFileRepository()
        {
            Directory.GetCurrentDirectory();
            filePath = @"C:\Users\volod\source\Lnu_VS\Individual\MyPharmacy\MyPharmacy\DAL\Files\cartTable.txt";
            //filePath = $"{Directory.GetCurrentDirectory()}\\DAL\\Files\\cartTable.txt";
            delim = ',';
            ReadItemsFromFile();
        }

        public override void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                foreach (var it in entities)
                {
                    streamWriter.WriteLine($"{it.Id},{it.name},{it.amount}");
                }
            }
        }
        public void DeleteAll()
        {
            entities.Clear();
            Save();
        }
        public bool IsProductExist(Flyweight product)
        {
            var it = entities.Find(x => x.Id == product.Id);
            if (it == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override Flyweight ConvertToObject(string [] strObjItems)
        {
            int fieldsCount = 3;
            if (strObjItems.Length != fieldsCount)
            {
                throw new Exception("Line is in incorrect format!");
            }
            return new Flyweight(new CartEntity(Convert.ToInt32(strObjItems[0]),strObjItems[1]),Convert.ToInt32(strObjItems[2]));
        }

        protected override void ReadItemsFromFile()
        {
            using (var streamReader = new StreamReader(filePath))
            {
                ReadItemsFromStream(streamReader);
            }
        }

        protected override void ReadItemsFromStream(StreamReader streamReader)
        {
            string fileLine;
            Init();
            
            while ((fileLine = streamReader.ReadLine()) != null)
            {
                string[] strObjItems = fileLine.Split(delim);
                entities.Add(ConvertToObject(strObjItems));
                
            }
        }
    }

}
