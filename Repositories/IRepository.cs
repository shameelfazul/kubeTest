﻿using Quillser.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quillser.Repositories
{
    public interface IRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);
    }
}