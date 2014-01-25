        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LArchitecture.GUI.LArchitectureControls
{
    class LForm : Form
    {
        Size LDefaultMaximuamSize = new Size(1280, 720);
        //Font LDefaultFont = new Font(TimesNewRoman, Regular);


        protected override Size DefaultMaximumSize
        {
            get
            {
                return (LDefaultMaximuamSize);
            }
        }

        protected override Size DefaultSize
        {
            get
            {
                return (LDefaultMaximuamSize);
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "LForm";
            this.ResumeLayout(false);

        }

    }
}