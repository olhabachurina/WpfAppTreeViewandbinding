using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfAppTreeViewandbinding
{
    public class CategoryViewModel
    {
        public string CategoryName { get; set; }
        public ObservableCollection<ProductViewModel> Products { get; set; }

        public CategoryViewModel()
        {
            Products = new ObservableCollection<ProductViewModel>();
        }
        public override string ToString()
        {
            return CategoryName;
        }
    }
}