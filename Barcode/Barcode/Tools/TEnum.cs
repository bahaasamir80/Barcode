using System;
using System.Collections.Generic;
using System.Text;

namespace Barcode
{
    public enum BarcodeType : byte { Code39 = 1, Code128 = 2 }
    public enum BarcodeStyle : byte { Small = 1, Medium = 2, Large = 3 }
    public enum CollapseStatus : byte { Collapsed, Expanded }
    public enum SaveTypes : byte { Jpg, Bmp, Png, Gif, Tiff, NON };
}