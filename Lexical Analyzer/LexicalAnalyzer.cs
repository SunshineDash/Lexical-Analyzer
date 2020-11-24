using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lexical_Analyzer
{
    public partial class LexicalAnalyzer : MaterialForm
    {
        public LexicalAnalyzer()
        {
            InitializeComponent();
        }

        private void LexicalAnalyzer_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            errorManager.BackColor = BackColor;
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (Syntax.CheckSyntax(inputBox.Text))
            {
                errorManager.Text = "Good Syntax";
                Syntax syntax = Syntax.TextAnalyzer(inputBox.Text);
                //outputBox.Text = "Comments:" + syntax.Comment + "\n";
                outputBox.Text += "If:" + syntax.If + "\n";
                outputBox.Text += "Then:" + syntax.Then + "\n";
                outputBox.Text += "Else:" + syntax.Else + "\n";
                outputBox.Text += "Xor:" + syntax.Xor + "\n";
                outputBox.Text += "Or:" + syntax.Or + "\n";
                outputBox.Text += "And:" + syntax.And;
                //outputBox.Text = outputBox.Text + "Initilize:" + syntax.Initialize;
            }
            else
            {
                errorManager.Text = "Bad Syntax";
            }

            
        }
    }
}
