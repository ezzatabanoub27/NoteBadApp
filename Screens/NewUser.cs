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
    public partial class NewUser : Form
    {
        WindowAppEntities we = new WindowAppEntities();


        public NewUser()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = UserNameText.Text;
            user.Password = PassText.Text;

            we.Users.Add(user);


            we.SaveChanges();
        }
    }
}
