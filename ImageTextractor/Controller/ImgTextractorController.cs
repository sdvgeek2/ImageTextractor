using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using ImageTextractor.Model;
using IronOcr;

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
          var ocr = new IronTesseract();

          using (var file = new OcrInput(Image.Path))
          {
            var res = ocr.Read(file);
            Image.CopyText(res);
          }
        }
    }
}
