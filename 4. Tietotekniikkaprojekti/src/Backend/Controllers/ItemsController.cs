using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ItemApi.Data;
using SharedLib;

namespace ItemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;
        private readonly ItemContext _context;

        public ItemsController(ILogger<ItemsController> logger, ItemContext context)
        {
            _logger = logger;
            _context = context;
        }
        //Haetaan kaikki 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDTO>>> Get()
        {
            var items = await _context.Items.OrderBy(i => i.Id).ToListAsync();
            if (items == null)
            {
                return NotFound();
            }
            var itemDtos = new List<ItemDTO>();
            foreach (var item in items)
            {
                itemDtos.Add(item.ToDTO());
            }
            return Ok(itemDtos);
        }
        //Haetaan kaikki samalla Errorilla esim. "Saumavirhe paikassa x"
        [HttpGet("item/error/{error}")]
        public async Task<ActionResult<IEnumerable<ItemDTO>>> GetItemsByError(string error)
        {
            var i = await _context.Items.Where(i => i.Error == error).ToListAsync();
            if (i == null)
            {
                return NotFound();
            }
            var itemDtos = new List<ItemDTO>();
            foreach (var item in i)
            {
                itemDtos.Add(item.ToDTO());
            }
            return Ok(itemDtos);
        }
        //Haetaan tietyllä id:llä olevat
        [HttpGet("item/id/{id}")]
        public async Task<ActionResult<ItemDTO>> GetItemsById(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(q => q.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            var newI = item.ToDTO();
            return Ok(newI);
        }
        //Haetaan kaikki samalla Descriptionilla olevat esim: "Normaalivirhe, ei vaadi tarkastusta"
        [HttpGet("item/desc/{description}")]
        public async Task<ActionResult<ItemDTO>> GetItemsByDesc(string desc)
        {
            var i = await _context.Items.Where(i => i.Description == desc).ToListAsync();
            if (i == null)
            {
                return NotFound();
            }
            var itemDtos = new List<ItemDTO>();
            foreach (var item in i)
            {
                itemDtos.Add(item.ToDTO());
            }
            return Ok(itemDtos);
        }
        //Haetaan kaikki tietyllä päivämäärällä olevat virheet
        [HttpGet("item/when/{when}")]
        public async Task<ActionResult<ItemDTO>> GetItemsByDate(DateTime when)
        {
            var i = await _context.Items.Where(i => i.When == when).ToListAsync();
            if (i == null)
            {
                return NotFound();
            }
            var itemDtos = new List<ItemDTO>();
            foreach (var item in i)
            {
                itemDtos.Add(item.ToDTO());
            }
            return Ok(itemDtos);
        }
        //Päivitetään Id:n avulla status
        [HttpPut("item/{id}/{status}")]
        public async Task<IActionResult> Update(string item, string status, [FromBody] ItemDTO itemDTO)
        {
            await _context.SaveChangesAsync();
            return NoContent();
        }
        //Poistetaan Id:llä
        [HttpDelete("item/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var i = await _context.Items.FirstOrDefaultAsync(q => q.Id == id);
            if (i == null)
            {
                return NotFound();
            }
            _context.Items.Remove(i);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
