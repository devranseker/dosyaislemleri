﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 
using System.IO;

namespace dosya_klasor
{
    public partial class Metin_belgesi : Form
    {
        public Metin_belgesi()
        {
            InitializeComponent();
        }
        //Global alan 
        string fileName, fileYolu;
        StreamWriter swrt;   // StreamWriter, bir dosyaya metin yazmak için kullanılan bir sınıftır 

        // yol sec butonu 
        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileYolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = fileYolu;

            }

        }
        // olsustur butonu 
        private void button2_Click(object sender, EventArgs e)
        {
            fileName = textBox2.Text;
            swrt = File.CreateText(fileYolu + "\\" + fileName + ".txt");
            swrt.Close();
        }






    }
}















