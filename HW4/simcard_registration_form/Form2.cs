using System;
using System.Windows.Forms;

namespace simcard_registration_form
{
    public partial class Form2 : Form
    {
        public static Form2 instance2;
        public PictureBox picBox;
        public MaskedTextBox mobile;
        public TextBox firstname;
        public TextBox lastname;
        public RadioButton sex;
        public ComboBox status;
        public DateTimePicker birthdate;
        public TextBox location;


        public Form2()
        {
            InitializeComponent();
            instance2 = this;
            picBox = pictureBox1;
            mobile = maskedTextBox1;
            firstname = textBox2;
            lastname = textBox1;
            sex = radioButton1.Checked ? radioButton1 : radioButton2;
            status = comboBox1;
            birthdate = dateTimePicker1;
            location = textBox3;




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            maskedTextBox1.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            radioButton1.AutoCheck = false;
            radioButton2.AutoCheck = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox3.ReadOnly = true;
        }
    }
    }