using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_book_search.Entities
{
    public class SajatForm : Form
    {
        public SajatForm () {
            Height = 943;
            Width = 696;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SajatForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "SajatForm";
            this.Load += new System.EventHandler(this.SajatForm_Load);
            this.ResumeLayout(false);

        }

        private void SajatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
