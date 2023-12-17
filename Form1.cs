using System;
using System.Data;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class Form1 : Form
    {
        private string previousInput;
        private string currentInput;

        public Form1()
        {
            InitializeComponent();
            currentInput = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToMathVisual("9");
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            AddOperatorToMathVisual("+");
        }

        private void buttonsubtract_Click(object sender, EventArgs e)
        {
            AddOperatorToMathVisual("-");
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            AddOperatorToMathVisual("*");
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            AddOperatorToMathVisual("/");
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            ClearMathVisual();
        }

        private void mathvisual_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void AppendToMathVisual(string input)
        {
            currentInput += input;
            mathvisual.Text = currentInput;
        }

        private void AddOperatorToMathVisual(string operatorSymbol)
        {
            currentInput += " " + operatorSymbol + " ";
            mathvisual.Text = currentInput;
        }

        private void CalculateResult()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string));
                DataRow row = table.NewRow();
                row["expression"] = null;
                table.Rows.Add(row);

                table.Columns[0].Expression = currentInput;
                double result = double.Parse((string)row[0]);
                mathvisual.Text = result.ToString();
                previousInput = currentInput;
                currentInput = result.ToString();
            }
            catch (Exception)
            {
                mathvisual.Text = "Error";
            }
        }

        private void ClearMathVisual()
        {
            currentInput = "";
            mathvisual.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
