using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shivam_Sood_Sec003_Ex_01
{
    public partial class Form1 : Form
    {
        Account account;
        SortedDictionary<int, Account> accounts = new SortedDictionary<int, Account>();

        LinkedList<double> generatedLists = new LinkedList<double>();

        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(tbAccNo.Text) || string.IsNullOrEmpty(tbCustName.Text) || string.IsNullOrEmpty(tbBalance.Text) || string.IsNullOrEmpty(tbBankerName.Text))
                {
                    throw new NoNullAllowedException();
                }
                int accno;
                if ((accno = int.Parse(tbAccNo.Text)) < 0)
                {
                    throw new FormatException();
                }

                string name = tbCustName.Text;

                decimal balance;
                if (!decimal.TryParse(tbBalance.Text, out decimal result))
                {
                    throw new FormatException();
                }
                else
                {
                    balance = result;
                }

                string bankerName = tbBankerName.Text;

                account = new Account(accno, name, balance, bankerName);
                MessageBox.Show($"New Account with name {name} is added sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                accounts.Add(accno, account);

                tbAccNo.Text = null;
                tbCustName.Text = null;
                tbBalance.Text = null;
                tbBankerName.Text = null;

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show($"Please Enter an positive Integer into Account Number Box or Balance Box", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex is NoNullAllowedException)
                {
                    MessageBox.Show("All Fields are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(tbAccNo.Text))
                {
                    throw new NoNullAllowedException();
                }
                int accno;
                if ((accno = int.Parse(tbAccNo.Text)) < 0)
                {
                    throw new FormatException();
                }

                if (accounts.ContainsKey(accno))
                {
                    accounts.Remove(accno);
                    MessageBox.Show($"Account Number {accno} deleted Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No Account with Account Number {accno} exists", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show($"Please Enter a positive Integer in Account Number Box", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex is NoNullAllowedException)
                {
                    MessageBox.Show("Please Enter Account Number", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {

            if (accounts.Count == 0)
            {
                MessageBox.Show($"Empty Dictionary", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbOutput.Text = null;
            }
            else
            {
                TbOutput.Text = null;
                foreach (var item in accounts.Values)
                {
                    TbOutput.Text += ($"{item.ToString()}");
                    TbOutput.AppendText(Environment.NewLine);

                }
            }

        }



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbAccNo.Text))
                {
                    throw new NoNullAllowedException();
                }
                int accno;
                if ((accno = int.Parse(tbAccNo.Text)) < 0)
                {
                    throw new FormatException();
                }

                if (accounts.ContainsKey(accno))
                {
                    MessageBox.Show($"Account with ID {accno} Exists", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"No Account with Account Number {accno} exists", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show($"Please Enter a positive Integer in Account Number Box", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex is NoNullAllowedException)
                {
                    MessageBox.Show($"Please Enter a Account Number", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            double number = 0;

            for (int i = 0; i < 5; i++)
            {
                number = rng.Next(11, 100);
                generatedLists.AddFirst(number);
            }
            LbLinkedList.Items.Clear();
            foreach (var item in generatedLists)
            {
                LbLinkedList.Items.Add(item);
            }

        }


        private void BtnAddBack_Click(object sender, EventArgs e)
        {
            if (generatedLists.Count != 0)
            {
                double number = rng.Next(11, 100);
                generatedLists.AddLast(number);
                LbLinkedList.Items.Clear();
                foreach (var item in generatedLists)
                {
                    LbLinkedList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("List is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnRemoveFront_Click(object sender, EventArgs e)
        {
            try
            {
                if (generatedLists.Count != 0)
                {
                    generatedLists.RemoveFirst();
                    LbLinkedList.Items.Clear();
                    foreach (var item in generatedLists)
                    {
                        LbLinkedList.Items.Add(item);
                    }
                    
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("List is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            try
            {
                if(generatedLists.Count!=0)
                {
                   double max= generatedLists.Max();
                    MessageBox.Show($"Max Value is {max}", "Max Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Empty List", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
