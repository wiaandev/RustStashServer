using Microsoft.EntityFrameworkCore;
using RustStashServer.Core.Entities;

namespace RustStashServer.Core.Services;

public class MaterialService
{
    private readonly ILogger<MaterialService> _logger;

    public MaterialService(ILogger<MaterialService> logger)
    {
        this._logger = logger;
    }

    public IQueryable<Material> GetMaterials(AppDbContext dbContext)
    {
        return dbContext.Materials.AsQueryable();
    }

    public async Task<Material> GetSingleMaterial(AppDbContext dbContext, int id)
    {
        if (dbContext.Materials is null)
        {
            throw new Exception("The material does not exist");
        }

        var material = await dbContext.Materials.SingleOrDefaultAsync(x => x.MaterialId == id);

        if (material is null)
        {
            throw new Exception($"{material} with id {id} could not be found");
        }

        return material;
    }

}