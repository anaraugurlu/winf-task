using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winf_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Humans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<string> names = new List<string>
            //{
            //    "elxan",
            //    "Tural",
            //    "Cavid",
            //    "Murad",
            //    "Fidan",
            //    "Anara"
            //};


            //foreach (var item in names )
            //{
            //    Humans.Items.Add(item);

            //}
            //Human human = new Human();
            //human.Name = textBox1.Text;
            //human.Surname = textBox2.Text;
            //human.Email = textBox4.Text;
            //human.BirthDate = dateTimePicker1.Text;
            //Humans.Items .Add ()
            //foreach (var item in Humans.Items  )
            //{
            //    item.ToString() = label6.Text;
            //}
//            List<Human> humans = new List<Human>
//            {
//                new Human
//                {
//                    Email ="ZeynebHesenova@gmail.com",
//                    Name="zeyneb",
//                    Surname ="hesenova",
//                    PhoneNumber ="12312323535",

//                },

//                new Human
//                {
//Name ="fuad",
//Surname ="ugurlu",
//Email ="fuad123@gmail.com",
//PhoneNumber ="+12235256"
//                },
//                new Human
//                {
//                    Name ="nezrin",
//                    Surname ="rehimli",
//                    Email="nezrin123@gmail.com",
//                    PhoneNumber ="+9941312334"
//                }



//        };
//            foreach (var item in humans )
//            {

//                Humans.Items.Add(item);
//            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            List<Human> humans = new List<Human>
            {
                new Human
                {
                    Email ="ZeynebHesenova@gmail.com",
                    Name="zeyneb",
                    Surname ="hesenova",
                    PhoneNumber ="12312323535",

                },

                new Human
                {
Name ="fuad",
Surname ="ugurlu",
Email ="fuad123@gmail.com",
PhoneNumber ="+12235256"
                },
                new Human
                {
                    Name ="nezrin",
                    Surname ="rehimli",
                    Email="nezrin123@gmail.com",
                    PhoneNumber ="+9941312334"
                }



        };
            foreach (var item in humans)
            {

                Humans.Items.Add(item);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
 Human human = new Human();
            human.Name = textBox1.Text;
            human.Surname = textBox2.Text;
            human.Email = textBox4.Text;
            human.BirthDate = dateTimePicker1.Text;
            Humans.Items.Add(human);
            //foreach (var item in Humans .Items )
            //{
            //    item.
            //}
        //    label6.Text = human.ToString();
          //  label .Text= "this human  added";
        }

        private void label6_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (var item in Humans .Items )
            //{

            //    label6 .Text =   Humans.Items.IndexOf(item).ToString ();

            //}
           
            bool isint= int.TryParse(label6.Text, out int result);
            Humans.Items.RemoveAt(result);
         //   Humans.Items[result];
        }
    }
}