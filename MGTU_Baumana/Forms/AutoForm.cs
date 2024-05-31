using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGTU_Baumana.ModelEF;

namespace MGTU_Baumana.Forms
{
    public partial class AutoForm : Form
    {
        public AutoForm()
        {
            InitializeComponent();

            lbError.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            //поиск пользователя по логину и паролю
            User user = model1.User.FirstOrDefault(x => x.Login == tbLogin.Text && x.Password == tbPassword.Text);
            if (user != null)
            {
                new MainForm(user).Show();
                this.Hide();
            }
            else
            {
                lbError.Text = "Неправильно введен логин или пароль";
            }
        }
    }
}
