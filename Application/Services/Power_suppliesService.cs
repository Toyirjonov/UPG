﻿using Application.Helpers;
using Application.Interfaces;
using DTOS.Power_supplies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class Power_suppliesService : IPower_suppliesService
{
    public Task AddPowerSuppliesAsync(AddPower_suppliesDTO newCategory)
    {
        throw new NotImplementedException();
    }

    public Task DeletePowerSuppliesAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<Power_suppliesDTO>> Filter(FilterParameters parametrs)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<Power_suppliesDTO>> GetPagedPowerSupplies(int pageSize, int pageNumber)
    {
        throw new NotImplementedException();
    }

    public Task<List<Power_suppliesDTO>> GetPowerSuppliesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Power_suppliesDTO> GetPowerSuppliesByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePowerSuppliesAsync(UpdatePower_suppliesDTO categoryDto)
    {
        throw new NotImplementedException();
    }
}
