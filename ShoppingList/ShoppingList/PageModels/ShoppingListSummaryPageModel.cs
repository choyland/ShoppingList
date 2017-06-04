using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using MyShoppingList.Model.Entities;

namespace MyShoppingList.PageModels
{
    public class ShoppingListSummaryPageModel : FreshBasePageModel
    {
        public List<ShoppingList.Model.Entities.ShoppingList> ShoppingLists { get; set; }

        public ShoppingListSummaryPageModel()
        {
            
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            ShoppingLists = new List<ShoppingList>
            {
                new ShoppingList {Name = "Test Shopping List", FromDate = DateTime.Now.AddDays(-7), ToDate = DateTime.Now.AddDays(7)},
                new ShoppingList {Name = "Test Shopping List 2", FromDate = DateTime.Now.AddDays(-14), ToDate = DateTime.Now.AddDays(4)}
            };
        }
    }
}
