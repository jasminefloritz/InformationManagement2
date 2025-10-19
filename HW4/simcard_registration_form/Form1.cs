using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simcard_registration_form
{

        public partial class Form1 : Form
        {
            public static Form1 instance1;
            public Button browse;
            public MaskedTextBox mobile1;
            public TextBox firstname;
            public TextBox lastname;
            public RadioButton sex;
            public ComboBox status;
            public DateTimePicker birthdate;
            public TextBox location;
            public Form1()
            {
                InitializeComponent();
                instance1 = this;
                mobile1 = maskedTextBox1;
                firstname = textBox2;
                lastname = textBox1;
                sex = radioButton1.Checked ? radioButton1 : radioButton2;
                status = comboBox1;
                birthdate = dateTimePicker1;
                location = textBox3;
            }


    

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            Form2.instance2.picBox.Image = pictureBox1.Image;
            Form2.instance2.picBox.SizeMode = PictureBoxSizeMode.Zoom;

            Form2.instance2.mobile.Text = mobile1.Text;
            Form2.instance2.firstname.Text = firstname.Text;
            Form2.instance2.lastname.Text = lastname.Text;
            if (sex.Text == "Male")
            {
                Form2.instance2.sex.Checked = true;
            }
            else
            {
                Form2.instance2.sex.Checked = true;
            }

            Form2.instance2.status.Text = status.Text;
            Form2.instance2.birthdate.Text = birthdate.Text;
            Form2.instance2.location.Text = location.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog.FileName;

                
                pictureBox1.Image = new Bitmap(filePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }