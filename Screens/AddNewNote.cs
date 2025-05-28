using NotApplication2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotApplication2.Screens
{
    public partial class AddNewNote : Form
    {

        private WindowAppEntities db = new WindowAppEntities();
        //private List<> Category;



        public AddNewNote()
        {
            InitializeComponent();
            categoryComBoks.DisplayMember = "Name";
            categoryComBoks.ValueMember = "Name";

            categoryComBoks.DataSource = Category.Categorys;

        }

        private void AddNota_Click(object sender, EventArgs e)
        {
            Note note = new Note();

            note.NoteId = int.Parse(numericIDNota.Value.ToString());
            note.Titel = txtNotaName.Text;
            note.Content = ContentText.Text;
            note.Category = (string)categoryComBoks.SelectedValue;
            note.ReminderDate = dateTime.Value;
            note.UserId = int.Parse(userIDnum.Value.ToString());

            db.Notes.Add(note);
            db.SaveChanges();

            MessageBox.Show("تمت إضافة الملاحظة بنجاح ✅");
        }

        DisplayAllNotas allNoat;
        private void ShowAllNota(object sender, EventArgs e)
        {
   
            if (allNoat == null || allNoat.IsDisposed) // لو الفورم مش مفتوح أو اتقفل
            {
                allNoat = new DisplayAllNotas();
                allNoat.Show();
            }
            else
            {
                allNoat.BringToFront(); // لو مفتوح، رجع النافذة للأمام
                allNoat.Focus();
            }
        }
    }
}