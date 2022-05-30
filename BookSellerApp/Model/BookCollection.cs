using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellerApp.Model
{
    public class BookCollection
    {
        ObservableCollection<Book> books;
        public BookCollection()
        {
            this.books = new ObservableCollection<Book>()
            {
                new Book{ Id=1, Name="আলোহান",BookId="B001", Price=220.00M, ReleaseDate=new DateTime(2002, 05, 09),Writter="রনিন",Image="Assets/AloHan.jpg"},
                new Book{ Id=2, Name="বাচ্চাদের রবীন্দ্রনাথ",BookId="B002", Price=150.00M, ReleaseDate=new DateTime(2010, 01, 08),Writter="ড.শ্যামল চক্রবর্তী", Image="Assets/Bacchader.jpg"},
                new Book{ Id=3, Name="লালু",BookId="B003", Price=180.00M, ReleaseDate=new DateTime(1998, 10, 12),Writter="শরৎচন্দ্র চট্টোপাধ্যায়",Image="Assets/Lalu.jpg"},
                new Book{ Id=4, Name="অপেক্ষা",BookId="B004", Price=300.00M, ReleaseDate=new DateTime(2019, 10, 12),Writter="হুমায়ূন আহমেদ",Image="Assets/Opekkha.jpg"},
                new Book{ Id=5, Name="শিকার",BookId="B005", Price=230.00M, ReleaseDate=new DateTime(2020, 10, 12), Writter="সমন্ধীয় বইয়ের সংগ্রহ",Image="Assets/Shikar.jpg"},
                new Book{ Id=6, Name="তিন পুরুষ",BookId="B006", Price=190.00M, ReleaseDate=new DateTime(2020, 10, 12),Writter="সমরেশ বসু",Image="Assets/TinPurush.jpg"},
                new Book{ Id=7, Name="Double Helix",BookId="B007", Price=220.00M, ReleaseDate=new DateTime(2002, 05, 09),Writter="James D.Watson",Image="Assets/Double.jpg"},
                new Book{ Id=8, Name="Education",BookId="B008", Price=150.00M, ReleaseDate=new DateTime(2010, 01, 08),Writter="Gary Thomas", Image="Assets/Education.jpg"},
                new Book{ Id=9, Name="Families Change",BookId="B009", Price=180.00M, ReleaseDate=new DateTime(1998, 10, 12),Writter="Julie Nelson",Image="Assets/Family.jpg"},
                new Book{ Id=10, Name="Look,Grandma!",BookId="B010", Price=220.00M, ReleaseDate=new DateTime(2019, 10, 12),Writter="Modelyn Goodnight",Image="Assets/Grandma.jpg"},
                new Book{ Id=11, Name="Jamberry",BookId="B011", Price=190.00M, ReleaseDate=new DateTime(2020, 10, 12), Writter="Bruce Degen",Image="Assets/Jamberry.jpg"},
                new Book{ Id=12, Name="A Little Life",BookId="B012", Price=260.00M, ReleaseDate=new DateTime(2020, 10, 12),Writter="Hanya Yangihara",Image="Assets/Story.jpg"}
            };
        }
        public ObservableCollection<Book> Get()
        {
            return this.books;
        }
        public Book Get(int id)
        {
            return this.books.First(x => x.Id == id);
        }
    }
}
