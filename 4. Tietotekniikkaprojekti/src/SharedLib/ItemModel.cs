using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public  class ItemModel
    {
        
        public int Id { get; set; }
        
        public string TheError { get; set; }
        
        public string Description { get; set; }
        
        public DateTime WhenWas { get; set; }
        
    }
}
