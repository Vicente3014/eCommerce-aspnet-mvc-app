﻿using ePerfumes.Models;
using Microsoft.EntityFrameworkCore;

namespace ePerfumes.Data.Services
{
    public class PerfumeService : IPerfumeService
    {
        private readonly AppDBContext _dbContext;
        public PerfumeService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Perfume perfume)
        {
            await _dbContext.Perfumes.AddAsync(perfume);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Perfume>> GetAllAsync()
        {
            var result = await _dbContext.Perfumes.ToListAsync();
            return result;
        }

        public async Task<Perfume> GetByIDAsync(int id)
        {
            var result = await _dbContext.Perfumes.FirstOrDefaultAsync(n => n.Perfume_ID == id);
            return result;
        }

        public Marca Update(int id,Perfume Newperfume)
        {
            throw new NotImplementedException();
        }
    }
}
