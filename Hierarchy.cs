using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfAppTreeViewandbinding
{
   public class Hierarchy
    {
        public ObservableCollection<CategoryViewModel> Categories { get; set; }

        public Hierarchy()
        {
            Categories = new ObservableCollection<CategoryViewModel>
            {
                new CategoryViewModel
            {
                CategoryName = "Продукты",
                Products =
                {
                    new ProductViewModel {ProductName = "Авокадо", Price = 30 },
                    new ProductViewModel {ProductName = "Лаваш", Price = 26 },
                      new ProductViewModel {ProductName = "Молоко", Price = 30 },
                    new ProductViewModel {ProductName = "Хлеб", Price = 26 },

                }
                },
                new CategoryViewModel
                { 
                CategoryName = "Косметика",
                Products =
                {
                    new ProductViewModel { ProductName = "Крем для лица", Price = 250 },
                    new ProductViewModel { ProductName = "Лосьон", Price = 200 },
                    new ProductViewModel { ProductName = "Помада", Price = 550 },
                    new ProductViewModel { ProductName = "Шампунь", Price = 150 }
                }
               },
                new CategoryViewModel
                {
                    
                    CategoryName = "Одежда",
                    Products =
                    {
                        new ProductViewModel { ProductName = "Футболка", Price = 1000 },
                        new ProductViewModel { ProductName = "Брюки", Price = 1500 }
                    }
                },
                new CategoryViewModel
                {
                
                CategoryName = "Обувь",
                Products =
                {
                    new ProductViewModel { ProductName = "Туфли", Price = 2500 },
                    new ProductViewModel { ProductName = "Ботинки", Price = 3200 }
                }
                },

                new CategoryViewModel
                {
                    CategoryName = "Электротовары",
                    Products =
                    {
                        new ProductViewModel {ProductName = "Микроволновка", Price = 3000 },
                        new ProductViewModel {ProductName = "Утюг", Price = 4000 },
                        new ProductViewModel {ProductName = "Пылесос", Price = 7500 }
                    }
                }
            };
        }
    }
}
    

