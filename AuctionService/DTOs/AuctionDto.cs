﻿using AuctionService.Entities;

namespace AuctionService.DTOs
{
    public class AuctionDto
    {
        public Guid Id { get; set; }
        public int ReservePrice { get; set; }
        public string Seller { get; set; }
        public string Winenr { get; set; }
        public int SoldAmount { get; }
        public int CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime AuctionEnd { get; set; }
        public string Status { get; set; }
        public string Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string ImageUrl { get; set; }
    }
}
