using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCAutoApi;
using System.Windows.Automation;
using System.Threading;

namespace Calculator_Automation
{
    public partial class Form1 : Form
    {
        string testing;
        CCAutoApi.GeneralAutoToolAPI test = new GeneralAutoToolAPI();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutomationElementCollection general;
            


            
            test.StartToolUsingDirectPath("calc.exe",out testing);
            AutomationElement calc =  test.GetForm("Calculator");

            test.SelectButtonWithText(calc, "2", out testing);
            Thread.Sleep(500);
            test.SelectButtonWithAutomationId(calc, "93", out testing);
            Thread.Sleep(500);
            test.SelectButtonWithText(calc, "9", out testing);
            Thread.Sleep(500);
            test.SelectButtonWithAutomationId(calc, "121", out testing);
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.ExitTool("calc", out testing);
            Application.Exit();
        }
    }
}
