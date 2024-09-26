﻿using ClubManager.Domain.DTOs.Identity;
using ClubManager.Domain.Entities.Identity;

namespace ClubManager.App.Interfaces.Identity
{
    public interface IInstitutionAppService
    {
        Task<InstitutionResponseDTO?> Get(long id);
        Task<List<InstitutionResponseDTO>?> GetAll();
        Task<InstitutionResponseDTO?> Create(CreateInstitutionDTO institutionBody);
        Task<InstitutionResponseDTO?> Update(UpdateInstitutionDTO institutionToUpdate);
        Task<InstitutionResponseDTO?> Delete(long id);
    }
}
