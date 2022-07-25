using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using IronOcr;

namespace ImageTextractor.Model
{
    public class ImgTextractor
    {
        public Bitmap Image;
        public string Path;

        public ImgTextractor(string path)
        {
            Path = path;
            Image = new Bitmap(Path);
        }

        public void CopyText(OcrResult ocr)
        {
            DataObject dataObj = new DataObject(ocr);
            dataObj.SetData(DataFormats.Text, ocr.Text);
            Clipboard.SetDataObject(dataObj, true);
        }
    }
}
