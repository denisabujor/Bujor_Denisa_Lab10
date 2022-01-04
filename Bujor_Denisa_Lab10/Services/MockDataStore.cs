using Bujor_Denisa_Lab10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bujor_Denisa_Lab10.Services
{
    public class MockDataStore : IDataStore<ShopList>
    {
        readonly List<ShopList> items;

        public MockDataStore()
        {
            items = new List<ShopList>()
            {
                new ShopList { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new ShopList { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new ShopList { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new ShopList { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new ShopList { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new ShopList { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(ShopList item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ShopList item)
        {
            var oldItem = items.Where((ShopList arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ShopList arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ShopList> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ShopList>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}