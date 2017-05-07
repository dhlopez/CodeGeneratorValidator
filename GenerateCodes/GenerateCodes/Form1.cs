using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GenerateCodes
{
    public partial class frmGenerateCodes : Form
    {
        char[] result = new char[8];
        
        public frmGenerateCodes()
        {
            InitializeComponent();
        }
        //public string result(string wineType) {
        //    return "";
        //}
        private void frmGenerateCodes_Load(object sender, EventArgs e)
        {
            cboWineType.SelectedIndex = 0;
        }
        //method to generate the list of values: ex. 10->A
        public Dictionary<int, char> setDigits() {
            lblResult.Text = "";
            Dictionary<int, char> digits = new Dictionary<int, char>();
            char[] characters = new char[] {'1','2','3','4','5','6','7','8','9','A', 'B', 'C', 'D', 'E',
                'F', 'G', 'H', 'I', 'J', 'K', 'L','M','N','P','Q','R','S','T','U','V','W','X','Y','Z' };

            for (int i = 0; i < characters.Length; i++)
            {
                digits.Add(i+1, characters[i]);
            }
            foreach (int key in digits.Keys)
            {
                lblResult.Text+=(String.Format("{0}: {1} \n", key, digits[key]));
            }
            return digits;
        }
        public void getRandom(Dictionary<int, char> digits)
        {
            //lblResult2.Text = "";
            //string[] result = new string[8];
            int i = 0;
            char wineType = ' ';
            char invalidChar = ' ';
            //One value is the wine type, the other one must not be included
            if (cboWineType.Text == "W")
            {
                wineType = 'W';
                invalidChar = 'R';
            }
            if (cboWineType.Text == "R")
            {
                wineType = 'R';
                invalidChar = 'W';
            }

            //result[0] = "W";
            while (i<8)
            {
                Random random = new Random();
                int newValue = random.Next(1, 34);
                for (int j = 0; j < result.Length; j++)
                {
                    //Code for duplicates,not sure if needed, also omit the invalidChar
                    if (result[j] == digits[newValue]|| digits[newValue]== invalidChar)
                    {
                        break;
                    }
                    ////////////////////
                    if (j == result.Length-1)
                    {
                        result[i]= digits[newValue];
                        //lblResult2.Text += result[i];
                        i++;
                    }
                }
            }
            if (Array.IndexOf(result, wineType) < 0)
            {
            setMandatoryField(wineType);
            }
           
        }
        //Add the mandatory field
        public void setMandatoryField(char wineType)
        {
            Random random = new Random();
            int newValue = random.Next(0, 7);

            //string oldResult = lblResult2.Text;
            //StringBuilder resStringBuilder = new StringBuilder(oldResult);
            //resStringBuilder.Remove(newValue, 1);
            //resStringBuilder.Insert(newValue, "W");
            //lblResult2.Text = resStringBuilder.ToString();

            result[newValue] = wineType;
        }
        //Get all the values and show them
        public bool generateValues(Dictionary<int, char> values)
        {
            //lblCodeValues.Text = "";
            int rangeL = 0;
            int rangeR = 0;
            int resultRange = 0;
            string code = "";
            string codeValue = "";
            for (int i =0; i<result.Length;i++)
            {
                //Value for each character
                
                code+= result[i];
                codeValue += values.First(x => x.Value==result[i]).Key.ToString()+" ";
                if (i < 4)
                {
                    rangeL += values.First(x => x.Value == result[i]).Key*1089;
                }
                if (i >=4)
                {
                    rangeR += values.First(x => x.Value == result[i]).Key*1089;
                }
            }
            resultRange = rangeL - rangeR;
            if (resultRange >= 30000 && resultRange <= 80000)
            {
                //MessageBox.Show("ValidRange" + resultRange);
                //Store or display
                //lblResult2.Text += "\n"+code;
                rtbCodes.Text += "\n" + code;
                //lblCodeValues.Text += "\n" + codeValue;
                rtbCodesValues.Text += "\n" + codeValue;
                return true;
            }
            else
            {
                //MessageBox.Show("InvalidRange" + resultRange);
                //Start again
                return false;
            }
            //lblResult2.Text += "\n";
            //lblCodeValues.Text += "\n";

        }

        public int[] generateDigitsBlock(int[] numbers)
        {
            //numbers = new int[4]{ 1,2,3,4};
            bool invNum = true;
            int currentNum = 0;
            int pos = 3; //position


            if (numbers[pos] != 9)
            {
                currentNum = numbers[pos] + 1;
                //check if new number already exists
                while (invNum)
                {
                    if (Array.IndexOf(numbers, currentNum) >= 0)
                    {
                        //if exists add a number until it does not exists
                        currentNum += 1;
                    }
                    else
                    {
                        numbers[pos] = currentNum;
                        invNum = false;
                    }
                }
            }
            else
            {
                //number 9 found
                invNum = true;
                numbers[pos] = -1;//'Deleted' value
                //numbers[pos] = 1;
                if (pos != 0)
                {
                    pos -= 1;
                    currentNum = numbers[pos]+1;
                }
                while (invNum)
                {
                    if (Array.IndexOf(numbers, currentNum) >= 0)
                    {
                        //if exists add a number until it does not exists
                        currentNum += 1;
                    }
                    else
                    {
                        numbers[pos] = currentNum;
                        invNum = false;
                    }
                }
            }
            foreach (int digit in numbers) {
                rtbCodes.Text += digit.ToString();
            }
            rtbCodes.Text += "\n";
            //MessageBox.Show(numbers.ToString());
            return numbers;
        }
        public void replaceDigit(int[] numbers,int fixPos)
        {
            int[] deleted = new int[fixPos];
            int i = 3;
            int nextNumber = 0;
            //Remove
            while (i>0) {
                deleted[i] = numbers[i];
                numbers[i] = -1;
                if ((deleted[i]) == 9)
                {
                    nextNumber = 1;
                }
                else
                {
                    nextNumber = deleted[i] + 1;
                }
                if (Array.IndexOf(numbers, nextNumber) >= 0)
                {
                    if (!(i == 0))
                    {
                        i--;
                    }
                    else {
                        break;
                    }
                }
                else {
                    //Add
                    break;
                }
            }
            //Add new values
            while (i<=3) {
                if ((deleted[i]) == 9)
                {
                    nextNumber = 1;
                }
                else
                {
                    nextNumber = deleted[i] + 1;
                }
                numbers[i] = nextNumber;
                i++;
            }
        }

        //Generate Event
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            /*
            int noCodes = 0;
            if (int.TryParse(txtCodesToGenerate.Text, out noCodes))
            {
                Dictionary<int, char> digits = setDigits();
                int i = 0;
                while ( i < noCodes)
                {
                    getRandom(digits);
                    if (generateValues(digits)) {
                        i++;
                    }
                }
            }
            else {
                MessageBox.Show("Please enter the number of codes to generate");
                txtCodesToGenerate.Focus();
            }
            */
            int noCodes = 0;
            if (int.TryParse(txtCodesToGenerate.Text, out noCodes))
            {
                Dictionary<int, char> digits = setDigits();
                int i = 0;
                int[] numbers = new int[4] { 1, 2, 3, 7 };

                while (i < noCodes)
                {
                    generateDigitsBlock(numbers);
                    //getRandom(digits);
                    //if (generateValues(digits))
                    //{
                    i++;
                    //}
                }
            }
            else
            {
                MessageBox.Show("Please enter the number of codes to generate");
                txtCodesToGenerate.Focus();
            }

        }

        
    }
}
