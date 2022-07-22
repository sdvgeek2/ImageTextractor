using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageTextractor.Model;

namespace ImageTextractor.Controller
{
    public class ImgTextractorController
    {
        public ImgTextractor Image;

        public ImgTextractorController(ImgTextractor image)
        {
            Image = image;
        }

        public void GetText()
        {
            // todo: select text
            Image.CopyText();
        }
    }
}
