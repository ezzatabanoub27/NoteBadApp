using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotApplication2.Data
{
    public partial class DisplayAllNotas : Form
    {
        private WindowAppEntities db = new WindowAppEntities();

        public DisplayAllNotas()
        {
            InitializeComponent();
            var notesList = db.Notes.ToList();

            dataGridAllNota.DataSource = notesList;
        }
    }
}
