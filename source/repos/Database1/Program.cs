using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Dataset
            MusicologyWarehouseDataSet db = new MusicologyWarehouseDataSet();

            // TABLE Album_Type
            Album_Type newAlbumType = new AlbumType();

            int key = db.Album_Type.Count();
            key += 1;

            newAlbumType.Type_ID = key;

            newAlbumType.Type_Desc = "New album type";
            db.Album_Type.Add(newAlbumType);
            db.SaveChanges();

            // TABLE Album_Price
            Album_Price newAlbumPrice = new Album_Price();

            int key = db.Album_Price.Count();
            key += 1;

            newAlbumPrice.Price_ID = key;

            newAlbumPrice.Price_Amount = "New price amount";
            newAlbumPrice.Price_Desc = "New price Desc";
            db.Album_Price.Add(newAlbumPrice);
            db.SaveChanges();

            // TABLE Album_Category
            Album_Category newAlbumCategory = new Album_Category();

            int key = db.Album_Category.Count();
            key += 1;

            newAlbumCategory.Category_ID = key;

            newAlbumCategory.Category_Desc = "New category desc";
            db.Album_Category.Add(Album_Category);
            db.SaveChanges();
           
            Console.WriteLine("I'm done");
            Console.ReadLine();

            



        }
    }
}
