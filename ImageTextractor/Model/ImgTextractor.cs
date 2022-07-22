using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

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

        public void CopyText()
        {
            DataObject dataObj = new DataObject();
            dataObj.SetData(DataFormats.Text, "Text Copy Image To Clipboard");
            Clipboard.SetDataObject(dataObj, true);
        }
    }
}
