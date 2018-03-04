using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ctrader.Controllers.Resources;
using ctrader.Models;
using ctrader.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ctrader.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IMapper mapper;
        private readonly CtraderDbContext context;
        public FeaturesController(CtraderDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>, List<FeatureResource>>(features); 
        }
       
    }
}