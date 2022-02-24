using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_4_1204044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, "Textbox Nama tidak boleh kosong!");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                if ((txtNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtNama, "Inputan harus huruf!");
                    epWarning.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "");
                }
            }
            }

        private void txtNik_TextChanged(object sender, EventArgs e)
        {
            if (txtNik.Text == "")
            {
                epWarning.SetError(txtNik, "Textbox Nik tidak boleh kosong!");
                epWrong.SetError(txtNik, "");
                epCorrect.SetError(txtNik, "");
            }
            else
            {
                if (txtNik.TextLength == 16)
                {
                    epCorrect.SetError(txtNik, "Betul!");
                    epWarning.SetError(txtNik, "");
                    epWrong.SetError(txtNik, "");
                }
                else
                {
                    epCorrect.SetError(txtNik, "");
                    epWarning.SetError(txtNik, "");
                    epWrong.SetError(txtNik, "Inputan harus 16 digit!");
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah\ncontoh: a@b.c");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
            
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epWarning.SetError(txtAlamat, "Textbox Alamat tidak boleh kosong!");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "");
            }
            else
            {
                if ((txtAlamat.Text == txtAlamat.Text.ToUpper()))
                {
                    epWarning.SetError(txtAlamat, "");
                    epWrong.SetError(txtAlamat, "");
                    epCorrect.SetError(txtAlamat, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAlamat, "Inputan hanya boleh huruf besar!");
                    epWarning.SetError(txtAlamat, "");
                    epCorrect.SetError(txtAlamat, "");
                }
            }
        }

        private void txtJk_TextChanged(object sender, EventArgs e)
        {
            if (txtJk.Text == "")
            {
                epWarning.SetError(txtJk, "Textbox jenis kelamin  tidak boleh kosong!");
                epWrong.SetError(txtJk, "");
                epCorrect.SetError(txtJk, "");
            }
            else
            {
                if (txtJk.Text == txtJk.Text.ToLower())
                {
                    epWarning.SetError(txtJk, "");
                    epWrong.SetError(txtJk, "");
                    epCorrect.SetError(txtJk, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtJk, "Inputan harus huruf kecil!");
                    epWarning.SetError(txtJk, "");
                    epCorrect.SetError(txtJk, "");
                }
            }
        }

        private void txtUmur_TextChanged(object sender, EventArgs e)
        {
            if (txtUmur.Text == "")
            {
                epWarning.SetError(txtUmur, "Textbox Umur tidak boleh kosong!");
                epWrong.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "");
            }

            else
            {
                if (int.Parse(txtUmur.Text) < 100)
                {
                    epCorrect.SetError(txtUmur, "Betul!");
                    epWarning.SetError(txtUmur, "");
                    epWrong.SetError(txtUmur, "");
                }
                else
                {
                    epCorrect.SetError(txtUmur, "");
                    epWarning.SetError(txtUmur, "");
                    epWrong.SetError(txtUmur, "Inputan hanya boleh dibawah 100!");
                }
            }
        }

        private void tbhButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show
             ("Nama :" + txtNama.Text +
             "\nNIk :" + txtNik.Text +
             "\nJenis Kelamin  :" + txtJk.Text +
             "\nUmur :" + txtUmur.Text +
             "\nAlamat :" + txtAlamat.Text +
             "\nEmail  :" + txtEmail.Text,
             "Informasi Pendaftaran",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
