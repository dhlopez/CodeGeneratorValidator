using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace CodeValidator
{
    public partial class frmCodeValidator : Form
    {
        public frmCodeValidator()
        {
            InitializeComponent();
        }
        //Ranges, W = 30000-130000; R = 300000-400000
        //No W and R at the same time.
        //No characters duplicates
        //
        private void frmCodeValidator_Load(object sender, EventArgs e)
        {
            cboWineType.SelectedIndex = 0;
        }

        public Dictionary<int, char> setDigits()
        {
            lblResult.Text = "";
            Dictionary<int, char> digits = new Dictionary<int, char>();
            char[] characters = new char[] {'1','2','3','4','5','6','7','8','9','A', 'B', 'C', 'D', 'E',
                'F', 'G', 'H', 'I', 'J', 'K', 'L','M','N','P','Q','R','S','T','U','V','W','X','Y','Z' };

            for (int i = 0; i < characters.Length; i++)
            {
                digits.Add(i + 1, characters[i]);
            }
            /*
            foreach (int key in digits.Keys)
            {
                lblResult.Text += (String.Format("{0}: {1} \n", key, digits[key]));
            }
            */
            return digits;
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string wineType = cboWineType.Text;
            string code = txtCode.Text;
            if (duplicates(code, wineType))
            {
                //Valid for simple validation
                if (validateRange(code, wineType) && unMapCheckFile(code))
                {
                    lblResult.Text = "Valid Code";
                }
                else
                {
                    lblResult.Text = "Invalid Code";
                }
            }
            
        }
        //Finding duplicates
        public bool duplicates(string code, string wineType)
        {
            bool valid = true;
            var dup = from c in code
                      group c by c into m
                      select new { Key = m.Key, Count = m.Count() };

            foreach (var c in dup)
            {
                if (c.Count > 1)
                {
                    lblResult.Text += "--Character " + c.Key + " is duplicated\n";
                    valid = false;
                }
            }
            //Both types in the same code
            if (code.IndexOf("W") > 0 && code.IndexOf("R") > 0)
            {
                lblResult.Text += "--Type white and read are included\n";
                valid = false;
            }
            //Code short or long
            if (code.Length!= 8)
            {
                lblResult.Text += "--Codes must be 8 characters long\n";
                valid = false;
            }
            //W or R are required
            if (code.IndexOf(wineType) < 0)
            {
                lblResult.Text += "--WineType is not included\n";
                valid = false;
            }
            return valid;
        }
        public bool validateRange(string code, string wineType)
        {
            bool valid = false;
            int[] valuesCode = new int[8];

            //Generate the default list
            Dictionary<int, char> digits = setDigits();

            int leftValue = 0, rightValue = 0, resultRange = 0;
            foreach (char c in code)
            {
                try
                {
                    //Get the key, in this case, key is the actual value
                    int val = digits.First(x => x.Value == c).Key;
                    
                    //Position in the current string
                    int position = code.IndexOf(c);
                    
                    //Stored the key value * 1089
                    valuesCode[position] = val * 1089;
                    if (position < 4)
                    {
                        leftValue += valuesCode[position];
                    }
                    if (position >= 4)
                    {
                        rightValue += valuesCode[position];
                    }
                }
                catch(Exception)
                {
                    lblResult.Text = "One of the characters entered is not valid\n";
                    return false;
                }
                          
            }
            //Get range value and verify
            resultRange = leftValue - rightValue;
            if (wineType == "W" && (resultRange >= 50000 && resultRange <= 80000))
            {
               // MessageBox.Show(resultRange + " Range Valid");
                valid = true;
            }
            if (wineType == "R" && (resultRange >= 45000 && resultRange <= 70000))
            {
                //MessageBox.Show(resultRange + " Range Valid");
                valid = true;
            }
            return valid;
        }
        public bool unMapCheckFile(string code)
        {
            string wineType = cboWineType.Text;
            bool valid = false;
            StringBuilder digit = new StringBuilder();
            StringBuilder chars = new StringBuilder();
            //example 91CW8D7Z, was 1789 BCZ

            digit.Append(code.Substring(0, 1));
            digit.Append(code.Substring(1, 1));
            chars.Append(code.Substring(2, 1));
            if (code.Substring(3, 1)==wineType)
            {
                //code.Append("W");
                valid = true;
            }
            
            digit.Append(code.Substring(4, 1));
            chars.Append(code.Substring(5, 1));
            digit.Append(code.Substring(6, 1));
            chars.Append(code.Substring(7, 1));
            string charsToSearch = chars.ToString();
            string digitToSearch = digit.ToString();

            var assembly = Assembly.GetExecutingAssembly();
            assembly.GetManifestResourceNames();
            var charsFromFile = "CodeValidator.Data_txt.PermutationCharacters.txt";
            var digitsFromFile = "CodeValidator.Data_txt.PermutationNumbers.txt";

            Stream streamChars = assembly.GetManifestResourceStream(charsFromFile);
            Stream streamDigits = assembly.GetManifestResourceStream(digitsFromFile);
            //find on txt digit and chars
            StreamReader charFiles = new StreamReader(streamChars);
            StreamReader numFiles = new StreamReader(streamDigits);

            
            string line;

            // Read the file and display it line by line.              
           
            while ((line = charFiles.ReadLine()) != null)
            {
                if (line.Contains(charsToSearch))
                {
                    valid = true;
                    //MessageBox.Show("chars found");
                    break;
                }
                else
                {
                    valid = false;
                }
            }
            while ((line = numFiles.ReadLine()) != null)
            {
                if (line.Contains(digitToSearch))
                {
                    valid = true;
                    //MessageBox.Show("digit found");
                    break;
                }
                else
                {
                    valid = false;
                }
            }
            //MessageBox.Show(valid+"");
            return valid;
        }
    }
}
