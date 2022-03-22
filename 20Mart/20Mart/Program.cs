using System;

namespace _20Mart
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[] { };
            
             NotebookList(out notebooks,520,601);
            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine($"Notebookun name is {notebooks[i].Name} Brand {notebooks[i].BrandName} Price is {notebooks[i].Price}");
            }
        }

        static Notebook[] NotebookList( out Notebook[]  note, double minPrice, double maxPrice) 
        {

            Notebook notebook1 = new Notebook
            {
                Name = "fx501",
                BrandName = "Asus",
                Price = 501,
            };
            Notebook notebook2 = new Notebook
            {
                Name = "fx502",
                BrandName = "Acer",
                Price = 525,
            }; Notebook notebook3 = new Notebook
            {
                Name = "fx503",
                BrandName = "Hp",
                Price = 511,
            }; Notebook notebook4 = new Notebook
            {
                Name = "fx504",
                BrandName = "Lenova",
                Price = 600,
            };

            Notebook[] noteBook = new Notebook[] {notebook1, notebook2, notebook3, notebook4 };
            
            int count = 0;
            for (int i = 0; i < noteBook.Length; i++)
            {
                if (noteBook[i].Price < maxPrice && noteBook[i].Price > minPrice)
                {
                    count++;
                    
                }
            }
             note = new Notebook[count];
            int j = 0;
            for (int i = 0; i < noteBook.Length; i++)
            {
                if (noteBook[i].Price < maxPrice && noteBook[i].Price > minPrice)
                {
                    note[j] = noteBook[i];
                    j++;
                }
            }

            return note;


        }
    }
}
