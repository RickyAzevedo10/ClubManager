﻿using ClubManager.Domain.DTOs.Financial;
using ClubManager.Domain.Entities.Financial;

namespace ClubManager.App.Services.Infrastructures
{
    public interface IRevenueAppService
    {
        Task<RevenueResponseDTO?> CreateRevenue(RevenueDTO revenueBody);
        Task<RevenueResponseDTO?> DeleteRevenue(long id);
        Task<RevenueResponseDTO?> UpdateRevenue(UpdateRevenueDTO revenueToUpdate);
        Task<List<RevenueResponseDTO>?> GetAllRevenue();
        Task<RevenueResponseDTO?> GetRevenue(long revenueId);
    }
}
