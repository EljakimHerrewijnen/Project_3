using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap
{
    public sealed class Checkbox
    {
        private List<System.Windows.Forms.CheckBox> all_buttons;

        public void AddButton(System.Windows.Forms.CheckBox button) { all_buttons.Add(button); }

        public List<System.Windows.Forms.CheckBox> AllButtons { get { return all_buttons; } }

    }
}
