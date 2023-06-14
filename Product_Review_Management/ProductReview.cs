﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    internal class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

        public override string ToString()
        {
            return $"Id: {ProductId} userId: {UserId} rating: {Rating} review: {Review} isLike: {IsLike}";
        }
    }
}
