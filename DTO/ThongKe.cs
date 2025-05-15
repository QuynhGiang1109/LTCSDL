using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDTO
    {
       
        
            public string TenPhim { get; set; }   
            public DateTime NgayChieu { get; set; } 
            public TimeSpan GioChieu { get; set; } 
            public int SoVeDaBan { get; set; }      
            public decimal TienVe { get; set; }    
        
    }
}
