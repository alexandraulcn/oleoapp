using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Oleo;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Oleo.iOS;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRendere))]
namespace Oleo.iOS
{

    class CustomViewCellRendere: ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            var view = item as CustomViewCell;
            cell.SelectedBackgroundView = new UIView
            {
                BackgroundColor = view.SelectedItemBackgroundColor.ToUIColor(),
            };

            return cell;
        }
    }
}