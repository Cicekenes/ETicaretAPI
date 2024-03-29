﻿using ETicaretAPI.Application.ViewModels.Baskets;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions.Services
{
    public interface IBasketService
    {

        public Task<List<BasketItem>> GetBasketItemsAsync();
        public Task AddItemToBasketAsync(BasketItemCreateVM basketItem);
        public Task UpdateQuantityAsync(BasketItemUpdateVM basketItem);
        public Task RemoveBasketItemAsync(string basketItemId);
        public Basket GetUserActiveBasket { get; }
        //public Task<Basket?> GetUserActiveBasket();
    }
}
