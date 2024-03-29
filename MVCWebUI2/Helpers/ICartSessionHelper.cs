﻿using Market.Entity.Domain;

namespace Market.MVCWebUI2.Helpers
{
    public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void SetCart(string key,Cart cart);
        void Clear();
    }
}
