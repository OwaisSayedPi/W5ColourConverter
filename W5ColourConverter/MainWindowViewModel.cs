using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5ColourConverter
{
    public class MainWindowViewModel
    {
        public DateTime ExpDate { get; set; }
        public MainWindowViewModel()
        {
            ExpDate = DateTime.Now.AddDays(+11);
        }
    }
}
