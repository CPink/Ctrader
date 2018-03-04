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
    public class MakesController : Controller
    {
        private readonly CtraderDbContext context;
        private readonly IMapper mapper;
        public MakesController(CtraderDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes =  await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}