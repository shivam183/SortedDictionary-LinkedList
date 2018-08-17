using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Shivam_Sood_Sec003_Ex_01
{
    public partial class Form1 : Form
    {
        //Object of Accout class not Initialized
        Account account;
        /// <summary>
        /// Sorted Dictionary with intger as key that will store account numbers and account as object
        /// to retrive any information as required for example name, balance etc.
        /// </summary>
        SortedDictionary<int, Account> accounts = new SortedDictionary<int, Account>();
        /// <summary>
        /// Linked List for second part of Exam it is of type double 
        /// </summary>
        LinkedList<double> generatedLists = new LinkedList<double>();
        // object of Random class to obtain random integers
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                //Check if any TextBoxes are Empty
                if (string.IsNullOrEmpty(tbAccNo.Text) || string.IsNullOrEmpty(tbCustName.Text) || string.IsNullOrEmpty(tbBalance.Text) || string.IsNullOrEmpty(tbBankerName.Text))
                {
                    throw new NoNullAllowedException();
                }
                //Trying to Parse the value from Textbox to Intgers. Throws an Error if fails
                //TryParsing is better if not using try/catch. Works both ways though.
                int accno;
                if (!int.TryParse(tbAccNo.Text,out int results))
                {
                    throw new FormatException();
                }
                else
                {
                    accno = results;
                }
                //Don't need to check for validation Name can be anything
                //Even Number 
                string name = tbCustName.Text;

                //Trying to Parse the value from Textbox to Double. Throws an Error if fails
                //Decimal value type is better for Handling money for precision in decimal points 
                decimal balance;
                if (!decimal.TryParse(tbBalance.Text, out decimal result))
                {
                    throw new FormatException();
                }
                else
                {
                    balance = result;
                }
                //Don't need to Check for validation
                string bankerName = tbBankerName.Text;
                //Calling non-default constructor and adding values from all textboxs and making new account
                //Initialized the Object here. Better to do it here because sometimes it can throw NullPointException
                account = new Account(accno, name, balance, bankerName);
                //MessageBox Display after account gets added sucessfully
                MessageBox.Show($"New Account with name {name} is added sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Adding the newly made Account to SortedDictionary with key as account number and Account as an Value
                accounts.Add(accno, account);
                //Making all TextBoxes text null so thats its ready to add another account 
                //Saves Time
                tbAccNo.Text = null;
                tbCustName.Text = null;
                tbBalance.Text = null;
                tbBankerName.Text = null;

            }
            //Catching all types of Exception Specified Above
            catch (Exception ex)
            {
                //Checking for FormatException
                if (ex is FormatException)
                {
                    MessageBox.Show($"Please Enter an positive Integer into Account Number Box or Balance Box", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Checking For NoNullAllowedException
                if (ex is NoNullAllowedException)
                {
                    MessageBox.Show("All Fields are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        /// <summary>
        /// This Methods Check first Checks for Empty Textbox then Try to Parse the Entered Value
        /// then It Checks Wheather the Entered Account Number Exist By using the "ContainsKey" method
        /// If it Exist then Remove the Entered Account Number Otherwise Shows No Account Exist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {

            try
            {   
                if (string.IsNullOrEmpty(tbAccNo.Text))
                {
                    throw new NoNullAllowedException();
                }
                int accno;
                if (!int.TryParse(tbAccNo.Text,out int result))
                {
                    throw new FormatException();
                }
                else
                {
                    accno = result;
                }

                if (accounts.ContainsKey(accno))
                {
                    DialogResult dialog= MessageBox.Show($"Are you sure you want to Remove the account with ID {accno}?\nThis Cannot be Undone!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog==DialogResult.Yes)
                    {
                        accounts.Remove(accno);
                        MessageBox.Show($"Account Number {accno} deleted Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
       
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
            finally
            {
                RefreshList();
                tbAccNo.Text = null;
            }



        }
        /// <summary>
        /// This Method First Check if the Sorted Dictionary is Empty or Not
        /// If not then goes through all the elements and displays them in the output multiline textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnDisplay_Click(object sender, EventArgs e)
        {

            if (accounts.Count == 0)
            {
                MessageBox.Show($"Empty Dictionary", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbOutput.Text = null;
            }
            else
            {
                RefreshList();
            }

        }
        /// <summary>
        /// This Method refreshes the list everytime when account is deleted Automatically
        /// </summary>
        private void RefreshList()
        {
            TbOutput.Text = null;
            foreach (var item in accounts.Values)
            {
                TbOutput.Text += ($"{item.ToString()}");
                TbOutput.AppendText(Environment.NewLine);

            }
        }


        /// <summary>
        /// This Method first checks for empty tetbox then try to parse the input from user
        /// then checks of the account exist for entered key using "ContainsKey" Method
        /// if account found just display it exist otherwise doesnot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbAccNo.Text))
                {
                    throw new NoNullAllowedException();
                }
                int accno;
                if (!int.TryParse(tbAccNo.Text,out int result)) 
                {
                    throw new FormatException();
                }
                else
                {
                    accno = result;
                }

                if (accounts.ContainsKey(accno))
                {
                    MessageBox.Show($"Account with ID {accno} Exists", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbAccNo.Text = null;
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
            finally
            {
                RefreshList();
                tbAccNo.Text = null;
            }



        }
        /// <summary>
        /// This Method Generates 5 Random Numbers and Add to the First of LinkedList
        /// Then Goes through all the elements of LinkedList and displays on ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// This Method Generates 1 Random Number and adds to the back of generated LinkedList
        /// Then foreach loop loops through the list and upadtes the ListBox
        /// It also checks if the list is Empty before adding to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
                MessageBox.Show("List is Empty!! \nPlease Click Generate Button to populate the List", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// This Method removes the First Element on click
        /// It also checks if the list is empty from start/All the elements are removed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("List is Empty!! \nPlease Click button Generate to populate the List ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// This Method Just Display whats the largest number in the LinkedList
        /// Checks if the list is Empty to Begin With
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("List is Empty!! \nPlease Click Generate Button to Populate the List", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
