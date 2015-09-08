﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.checkedListBoxPossibleValue.Items.Add("Ten");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if(this.checkedListBoxPossibleValue.CheckedItems.Count>0)
            {
                this.listBoxSelected.Items.Clear();

                foreach(string item in this.checkedListBoxPossibleValue.CheckedItems)
                {
                    this.listBoxSelected.Items.Add(item.ToString());
                }

                for (int i = 0; i < this.checkedListBoxPossibleValue.Items.Count; i++)
                    this.checkedListBoxPossibleValue.SetItemChecked(i, false);
            }
        }
    }
}
