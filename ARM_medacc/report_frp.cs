﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_medacc
{
    public partial class report_frp : Form
    {
        MySqlConnection connect;
        public report_frp(MySqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }
    }
}
