﻿namespace ClubManager.Domain.DTOs.TrainingCompetition
{
    public class MatchResponseDTO
    {
        public long Id { get; set; }
        public DateTime Date { get; set; } 
        public string Opponent { get; set; } 
        public string Location { get; set; } 
        public string CompetitionType { get; set; } 
        public int TeamId { get; set; } 
        public bool IsCanceled { get; set; } 
    }
}
