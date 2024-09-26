﻿namespace ClubManager.Domain.DTOs.Financial
{
    public class UpdateEntityDTO
    {
        public long Id { get; set; }
        public bool Internal { get; set; }
        public bool External { get; set; }
        public long? ClubMemberId { get; set; }
        public long? PlayerId { get; set; }
        public string EntityType { get; set; }
        public string EntityName { get; set; }
    }
}
