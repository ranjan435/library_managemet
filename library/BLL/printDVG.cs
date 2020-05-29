using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.BLL
{
    public class printDVG
    {
        public static void print(DataGridView dt,String keywords)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = keywords;
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Online Library Management";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dt);
        }
        
    }
}
