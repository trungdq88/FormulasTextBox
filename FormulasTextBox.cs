using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Assignment4
{
    public class FormulasTextBox : TextBox
    {
        

        /******************************************************/
        /*  Private fields 
        /******************************************************/
        private Boolean _numericOnly;
        private Color _invalidFormulasColor = Color.Red;
        private Color _validFormulasColor = Color.Blue;
        private Color _inputFormulasColor = Color.White;
        private Boolean _cancelKeyDueToShortcuts;

        private Boolean IsFormulasValid { get; set; }

        /******************************************************/
        /*  Properties and events 
         *  See more:
         *  http://stackoverflow.com/a/2081964/1420186
         *  http://msdn.microsoft.com/en-us/library/system.componentmodel.categoryattribute.aspx
        /******************************************************/
        [Description("Active Numeric Only"), Category("Numeric Only")]
        public Boolean NumericOnly
        {
            get { return _numericOnly; }
            set { _numericOnly = value; }
        }

        [Description("Invalid Formulas Color"), Category("Numeric Only")]
        public Color InvalidFormulasColor
        {
            get { return _invalidFormulasColor; }
            set { _invalidFormulasColor = value; }
        }

        [Description("Valid Formulas Color"), Category("Numeric Only")]
        public Color ValidFormulasColor
        {
            get { return _validFormulasColor; }
            set { _validFormulasColor = value; }
        }

        [Description("Input Formulas Color"), Category("Numeric Only")]
        public Color InputFormulasColor
        {
            get { return _inputFormulasColor; }
            set { _inputFormulasColor = value; }
        }


        /******************************************************/
        /** Override methods
        /******************************************************/

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            // Shortcut keys to improve input speed. Make it pluggable in the future
            switch (e.KeyCode)
            {
                case Keys.T:
                    _cancelKeyDueToShortcuts = true;
                    AppendText("00");
                    break;
                case Keys.N:
                    _cancelKeyDueToShortcuts = true;
                    AppendText("000");
                    break;
                default:
                    _cancelKeyDueToShortcuts = false;
                    break;
            }
        }

        /// <summary>
        /// Decide if the pressed key is need to appended to the text box
        /// http://msdn.microsoft.com/en-us/library/vstudio/system.windows.forms.control.keydown(v=vs.100).aspx
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (_cancelKeyDueToShortcuts)
            {
                e.Handled = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            // When user is typing the input, use default color;
            BackColor = _inputFormulasColor;
        }
        
        /// <summary>
        /// Override OnLeave method to validate formulas when the control lost focus
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            IsFormulasValid = true;
            if (Text.Length > 0)
            {
                if (Text[0] == '=')
                {
                    // User is going to enter a formulas

                    String input = Text.TrimStart('=');
                    try
                    {
                        Double result = EvaluateExpression(input);
                        Text = result + "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Expression is invalid");
                    }

                } else
                {
                    // User is going to enter a value
                    try
                    {
                        Double result = Convert.ToDouble(Text);
                    }
                    catch (Exception)
                    {
                        // Input is invalid
                        IsFormulasValid = false;
                        MessageBox.Show("Invalid input value!");
                    }
                }
                
            } else
            {
                Text = "0";
            }

            // Update back color
            if (IsFormulasValid)
            {
                BackColor = _validFormulasColor;
            } else
            {
                BackColor = _invalidFormulasColor;
                Focus();
            }
        }

        /// <summary>
        /// There are many ways to implement this method
        /// As an ACM student, they would prefer the Binary Expression Tree Aglorithm:
        ///     http://en.wikipedia.org/wiki/Binary_expression_tree
        /// But ain't body got time for that, I am not relaly good at Aglorithm, so I
        /// found a nice-tricky solution from Teoman Soygul in StackoverFlow
        ///     http://stackoverflow.com/a/6052679/1420186
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private double EvaluateExpression(String expression)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);  
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
