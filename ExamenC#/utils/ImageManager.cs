using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_.utils
{
    public class ImageManager
    {
        public static Image FromURL(string imageUrl)
        {
            return Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
        }
        public static Image FromPath(string imagePath)
        {
            return Image.FromFile(imagePath);
        }
    }
}
