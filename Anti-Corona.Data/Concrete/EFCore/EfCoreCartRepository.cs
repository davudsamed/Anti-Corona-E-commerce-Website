using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public class EfCoreCartRepository : EfCoreGenericRepository<CartItem, AntiCoronaContext>, ICartRepository
    {
        public List<CartItem> GetCartItems(string userId)
        {
            using (var context=new AntiCoronaContext()) 
            {
                return context.CartItems.Include(i => i.Product).ThenInclude(i=>i.Images).Where(i => i.UserId ==userId).ToList();
            }
        }

    }
}
