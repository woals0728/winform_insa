using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public interface I_control
    {
        MainWindow mainControl { get; set; }
        void insert_button();
        void delete_button();
        void cancel_button();
    }
}
