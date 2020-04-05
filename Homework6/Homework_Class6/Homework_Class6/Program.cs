using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class6
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum album1 = new PhotoAlbum();
            album1.GetNumberOfPages();

            PhotoAlbum album2 = new PhotoAlbum(24);
            album2.GetNumberOfPages();

            BigPhotoAlbum bigalbum = new BigPhotoAlbum();
            bigalbum.GetNumberOfPages();
            Console.ReadLine();
        }
    }
}
