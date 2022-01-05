﻿using RestaurantReviews.Interfaces.Models;

namespace RestaurantReviews.Models
{
    public class User : IUser
    {
        public long Id { get; set; }
        // For simplicity, not including common user properties (username, password, email, etc)
    }
}
