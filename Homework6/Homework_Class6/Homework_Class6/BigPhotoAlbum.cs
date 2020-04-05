using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class6
{
    class BigPhotoAlbum
    {
        private int NumOfPages;

        public BigPhotoAlbum()
        {
            NumOfPages = 64;
        }
       
        public void GetNumberOfPages()
        {
            Console.WriteLine($"The BIG PHOTO ALBUM has {NumOfPages} pages");
        }
    }
}
