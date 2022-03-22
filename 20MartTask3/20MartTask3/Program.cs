using System;

namespace _20MartTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many books do you want");
            int bookCount = Convert.ToInt32(Console.ReadLine());
            Library library = new Library();
            library.books = new Book[bookCount];
            for (int i = 0; i < bookCount; i++)
            {
                string name = "", genre = "";
                double price = 0;
                int no = 0, count = 0;
                bool check = true;
                while (name.Length<1 || name.Length>50)
                {
                    Console.WriteLine("Write book name: ");
                    name = Console.ReadLine();
                }
                while (genre.Length<3 || genre.Length>20)
                {
                    Console.WriteLine("Write book genre: ");
                    genre = Console.ReadLine();
                }
                while (price <= 0)
                {
                    Console.WriteLine("Write book price: ");
                    price = Convert.ToDouble(Console.ReadLine());
                }
                while (count <= 0)
                {
                    Console.WriteLine("Write book count: ");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                while (check) 
                {
                    check = false;
                    Console.WriteLine("Write book no: ");
                    no = Convert.ToInt32(Console.ReadLine());    
                    for (int j = 0; j < i; j++)
                    {
                        if (library.books[j].no == no)
                        {
                            check = true;
                            break;
                        }
                    }
                }
                Book book = new Book(genre,no,name,price,count);
                library.AddBook(book);

            }

            bool checkOne = true;
            while (checkOne)
            {
                Console.WriteLine("Do you want filter y/n");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'y')
                {
                    while (true)
                    {

                    
                    Console.WriteLine("1-For genre 2-For price 1/2");
                    char answerWithNumber =Convert.ToChar(Console.ReadLine()) ;
                    if (answerWithNumber == '1')
                    {
                        Console.WriteLine("Write genre");
                        string genre = Console.ReadLine();
                        library.GetInfo(library.GetFilteredBooks(genre));
                        checkOne = false;
                        break;
                    }
                    else if (answerWithNumber == '2')
                    {
                        Console.WriteLine("Write min and max price ");
                        double minPrice = Convert.ToDouble(Console.ReadLine());
                        double maxPrice = Convert.ToDouble(Console.ReadLine());
                        library.GetInfo(library.GetFilteredBooks(minPrice,maxPrice));
                        checkOne = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have to write 1/2");
                    }
                    }
                }
                else if (answer =='n')
                {
                    library.GetInfo(library.books);
                    break;
                }
                else
                {
                    Console.WriteLine("You have to write y/n");
                }
            }

        }
    }
}
