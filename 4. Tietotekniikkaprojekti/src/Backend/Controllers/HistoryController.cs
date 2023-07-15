using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ItemApi.Data;
using SharedLib;

namespace ItemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoryController : ControllerBase
    {
        private readonly ILogger<HistoryController> _logger;
        private readonly HistoryContext _context;

        public HistoryController(ILogger<HistoryController> logger, HistoryContext context)
        {
            _logger = logger;
            _context = context;
        }
        //Haetaan kaikki 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDTO>>> Get()
        {
            var items = await _context.History.OrderBy(i => i.Id).ToListAsync();
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
            var i = await _context.History.Where(i => i.Error == error).ToListAsync();
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
            var item = await _context.History.FirstOrDefaultAsync(q => q.Id == id);
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
            var i = await _context.History.Where(i => i.Description == desc).ToListAsync();
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
            var i = await _context.History.Where(i => i.When == when).ToListAsync();
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
        [HttpPost("{id}")]
        public async Task<ActionResult<ItemDTO>> Create(int Id, [FromBody] ItemDTO itemDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Item newItem = new Item
                    {
                        Id = Id,
                        Error = itemDTO.Error,
                        Description = itemDTO.Description,
                        When = DateTime.Parse(itemDTO.When)
                    };
                    _context.History.Add(newItem);
                    await _context.SaveChangesAsync();
                    return CreatedAtAction(nameof(GetItemsById), new { Id }, newItem.ToDTO());
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest();
            }
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
            var i = await _context.History.FirstOrDefaultAsync(q => q.Id == id);
            if (i == null)
            {
                return NotFound();
            }
            _context.History.Remove(i);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
