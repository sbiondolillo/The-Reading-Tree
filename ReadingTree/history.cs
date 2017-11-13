using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTree
{
    public static class History
    {
        public static Stack<System.Windows.Forms.Form> prev { get; set; }
        
        public static void SetPrev(System.Windows.Forms.Form parentForm)
        {
            prev.Push(parentForm);
        }

        public static System.Windows.Forms.Form GetPrev()
        {
            return prev.Pop();
        }
        
    }
}
