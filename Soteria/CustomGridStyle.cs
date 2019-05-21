using System;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;

namespace Soteria
{
    // Custom style class
    public class CustomGridStyle : DataGridStyle
    {
        public CustomGridStyle()
        {
        }

        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.FromRgb(249, 249, 249);
        }
    }
}

