

using SharedLib;
using System.Runtime.CompilerServices;

namespace ItemApi.Data
{
    public static class Helpers
    {
        public static ItemDTO ToDTO(this Item item)
        {
            return new ItemDTO
            {
                Id = item.Id,
                Error = item.Error,
                Description = item.Description,
                When = item.When.ToString("O"),
            };
        }
    }
}
