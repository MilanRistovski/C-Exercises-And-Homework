using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class6
{
    class PhotoAlbum
    {
        private int NumOfPages;
        public PhotoAlbum()
        {
            NumOfPages = 16;

        }
        public PhotoAlbum(int numOfPages)
        {
            NumOfPages = numOfPages;
        }

        public void GetNumberOfPages()
        {
            Console.WriteLine($"The photo album has {NumOfPages} pages");
        }
    }
}
