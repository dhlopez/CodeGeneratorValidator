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

namespace GenerateCodes
{
    public partial class Generator2 : Form
    {
        public Generator2()
        {
            InitializeComponent();
        }
        int totalLoop = 0;
        string codePath = "";
        string logPath = "";

        public void getDigits()
        {
            string digit = " ";
            string digitEndFile = "9876";
            string chars = " ";
            string charsEndFile = "ZYX";

            Assembly _assembly = Assembly.GetExecutingAssembly();
            //charsPath =openFile("Select the Characters file");
            //digitPath=openFile("Select the Digits file");

            //string charsPath = "C:\\Users\\dlopez\\Desktop\\WineAwakenings\\PermutationCharacters.txt";
            //string digitPath = "C:\\Users\\dlopez\\Desktop\\WineAwakenings\\PermutationNumbers.txt";
            bool cont= true;
            try
            {
                StreamReader charFiles = new StreamReader(_assembly.GetManifestResourceStream("GenerateCodes.App_Resources.PermutationCharacters.txt"));
                while (chars != null && chars!= charsEndFile&&cont)
                {
                    chars = charFiles.ReadLine().ToUpper();
                    StreamReader numFiles = new StreamReader(_assembly.GetManifestResourceStream("GenerateCodes.App_Resources.PermutationNumbers.txt"));
                    digit = "";
                    //digit is not null, not the end of file and continue is true
                    while (digit != null && digit!= digitEndFile && cont)
                    {
                        digit = numFiles.ReadLine();
                        formCode(digit, chars);
                        //if the label control equals the amount of codes to generate, then stop (cont = false)
                        
                        if (Convert.ToInt32(lblIteration.Text) == Convert.ToInt32(txtCodesToGenerate.Text))
                        {
                            rtbCodes.Text = "Last char used "+ chars + " Last digist used "+digit+ "\nPlease check your file!\n"
                                +codePath+ "\\codes"+ cboWineType.SelectedItem+".txt";
                            lblLastChar.Text = chars;
                            lblLastDigit.Text = digit;
                            saveLog(chars,digit,lblIteration.Text);
                            cont = false;
                            rtbCodes.Text += "\nTotal times looped "+totalLoop;
                            break;
                        }
                        
                    }
                    numFiles.Close();
                }
                //close the file after looping everything
                Console.WriteLine("Last value used: " + digit + " " + chars);
                charFiles.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.WriteLine("Last value used: " + digit +" " +chars);
                MessageBox.Show(e.Message);
            }
        }
        public void continueDigits()
        {
            Assembly _assembly = Assembly.GetExecutingAssembly();
            //logPath = openFile("Select your log file");
            //codePath = openFile("Select code file");

            //charsPath = openFile("Select the Characters file");
            //digitPath = openFile("Select the Digits file");

            lblIteration.Text = "0";
            string digit = " ";
            string digitEndFile = "9876";
            string chars = " ";
            string charsEndFile = "ZYX";
            bool saveChar = false, saveDig = false, cont = true;
            try
            {
                string[] lastCodeParts = loadLog();
                //MessageBox.Show(lastCodeParts[0]+" "+lastCodeParts[1]);
                StreamReader charFiles = new StreamReader(_assembly.GetManifestResourceStream("GenerateCodes.App_Resources.PermutationCharacters.txt"));
                while (chars != null && chars != charsEndFile && cont)
                {
                    chars = charFiles.ReadLine().ToUpper();
                    if (chars == lastCodeParts[0] && !saveChar) //last char used
                    {
                        lblLastChar.Text = "";
                        saveChar = true;
                        StreamReader numFiles = new StreamReader(_assembly.GetManifestResourceStream("GenerateCodes.App_Resources.PermutationNumbers.txt"));
                        digit = "";
                        while (digit != null && digit != digitEndFile)
                        {
                            digit = numFiles.ReadLine();

                            if (digit == lastCodeParts[1] && !saveDig)//last digit used
                            {
                                lblLastDigit.Text = "";
                                saveDig = true;
                                digit = numFiles.ReadLine();
                            }
                            if (saveDig)
                            {
                                formCode(digit, chars);
                                if (Convert.ToInt32(lblIteration.Text) == Convert.ToInt32(txtCodesToGenerate.Text))
                                {
                                    rtbCodes.Text = "Last char used " + chars + " Last digist used " + digit + "\nPlease check your file!\n"
                                        + codePath + "\\codes" + cboWineType.SelectedItem + ".txt";
                                    lblLastChar.Text = chars;
                                    lblLastDigit.Text = digit;
                                    saveLog(chars, digit, lblIteration.Text);
                                    cont = false;
                                    rtbCodes.Text += "\nTotal times looped " + totalLoop;
                                    break;
                                }
                            }
                        }
                        numFiles.Close();
                        // break;
                    }
                    else
                    {
                        if (saveChar && cont)
                        {
                            //chars = charFiles.ReadLine().ToUpper();
                            StreamReader numFiles = new StreamReader(_assembly.GetManifestResourceStream("GenerateCodes.App_Resources.PermutationNumbers.txt"));
                            digit = "";
                            //digit is not null, not the end of file and continue is true
                            while (digit != null && digit != digitEndFile && cont)
                            {
                                digit = numFiles.ReadLine();
                                formCode(digit, chars);
                                //if the label control equals the amount of codes to generate, then stop (cont = false)
                                if (Convert.ToInt32(lblIteration.Text) == Convert.ToInt32(txtCodesToGenerate.Text))
                                {
                                    rtbCodes.Text = "Last char used " + chars + " Last digist used " + digit + "\nPlease check your file!\n"
                                        + codePath + "\\codes" + cboWineType.SelectedItem + ".txt";
                                    lblLastChar.Text = chars;
                                    lblLastDigit.Text = digit;
                                    saveLog(chars, digit, lblIteration.Text);
                                    cont = false;
                                    rtbCodes.Text += "\nTotal times looped " + totalLoop;
                                    break;
                                }
                            }
                            numFiles.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine("Last value used: " + digit + " " + chars);
                MessageBox.Show(ex.Message);
            }
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            int number;
            lblIteration.Text = "0";
            if (txtCodesToGenerate.Text == "" || !int.TryParse(txtCodesToGenerate.Text, out number))
            {
                MessageBox.Show("Please enter the amount of codes to generate");
                txtCodesToGenerate.Focus();
            }
            else
            {
                codePath = selectPath("Please select a folder for your codes file");
                logPath = codePath;
                continueDigits();
            }
        }
        
        public void formCode(string digit, string chars)
        {
            StringBuilder code = new StringBuilder();
            
            code.Append(digit.Substring(0, 1));
            code.Append(digit.Substring(2, 1));
            code.Append(chars.Substring(1, 1));
            code.Append(cboWineType.SelectedItem);
            code.Append(digit.Substring(1, 1));
            code.Append(chars.Substring(2, 1));
            code.Append(digit.Substring(3, 1));
            code.Append(chars.Substring(0, 1));
            string finalCode = code.ToString();
            Dictionary<int, string> digits = setDigits();
            generateValues(finalCode, digits);
            //return finalCode;
        }
        public Dictionary<int, string> setDigits()
        {
            //lblResult.Text = "";
            Dictionary<int, string> digits = new Dictionary<int, string>();
            string[] characters = new string[] {"1","2","3","4","5","6","7","8","9","A", "B", "C", "D", "E",
                "F", "G", "H", "I", "J", "K", "L","M","N","P","Q","R","S","T","U","V","W","X","Y","Z" };

            for (int i = 0; i < characters.Length; i++)
            {
                digits.Add(i + 1, characters[i]);
            }
            foreach (int key in digits.Keys)
            {
                //lblResult.Text += (String.Format("{0}: {1} \n", key, digits[key]));
            }

            return digits;
        }
        public void generateValues(string finalCode, Dictionary<int, string> values)
        {
            totalLoop++;
            //lblCodeValues.Text = "";
            int rangeL = 0;
            int rangeR = 0;
            int resultRange = 0;
            string code = "";
            string codeValue = "";
            for (int i = 0; i < finalCode.Length; i++)
            {
                //Value for each character

                code += finalCode.Substring(i, 1);
                codeValue += values.First(x => x.Value == finalCode.Substring(i, 1)).Key.ToString() + " ";
                if (i < 4)
                {
                    rangeL += values.First(x => x.Value == finalCode.Substring(i, 1)).Key * (1089+(i*33));
                }
                if (i >= 4)
                {
                    rangeR += values.First(x => x.Value == finalCode.Substring(i, 1)).Key * (1089+(i*33));
                }
            }
            resultRange = rangeL - rangeR;
            string wineType = cboWineType.SelectedItem.ToString();
            if ((resultRange >= 45000 && resultRange <= 70000) && wineType.Equals("R"))
            {
                lblIteration.Text = (Convert.ToInt32(lblIteration.Text)+1)+"";
                saveCode(code);
                
            }
            if ((resultRange >= 50000 && resultRange <= 80000) && wineType.Equals("W"))
            {
                lblIteration.Text = (Convert.ToInt32(lblIteration.Text) + 1) + "";
                saveCode(code);

            }

        }
        public void saveCode(string newCode)
        {
            if (codePath.IndexOf(".txt") >= 0)
            {
                using (StreamWriter file = new StreamWriter(codePath, true))
                {
                    //MessageBox.Show(fbd.SelectedPath + "\\codes.txt");
                    file.WriteLine(newCode);
                    file.Close();
                }
            }
            else
            {
                using (StreamWriter file = new StreamWriter(codePath + "\\codes" + cboWineType.SelectedItem + ".txt", true))
                {
                    //MessageBox.Show(fbd.SelectedPath + "\\codes.txt");
                    file.WriteLine(newCode);
                    file.Close();
                }
            }

        }
        public void saveLog(string chars, string digits, string codesPerRun)
        {
            if (File.Exists(logPath+ "\\Code" + cboWineType.SelectedItem + "Log.txt"))
                //if (logPath.IndexOf(".txt") >= 0)
            {
                //Means continue button was clicked
                logPath += "\\Code" + cboWineType.SelectedItem + "Log.txt";
                using (StreamWriter file = new StreamWriter(logPath, true))
                {
                    file.WriteLine(chars + " " + digits + " " + "Codes generated last run->" + codesPerRun + "Date:" + DateTime.Now);
                    file.Close();
                }
            }
            else
            {
                using (StreamWriter file = new StreamWriter(logPath + "\\Code" + cboWineType.SelectedItem + "Log.txt", true))
                {
                    file.WriteLine(chars + " " + digits + " " + "Codes generated last run->" + codesPerRun + "Date:" + DateTime.Now);
                    file.Close();
                }
            }
        }
        public string[] loadLog()
        {
            string lastCode = "";
            using (StreamReader file = new StreamReader(logPath+"\\Code"+cboWineType.SelectedItem + "Log.txt"))
            {
                while (file.EndOfStream == false)
                {
                    lastCode = file.ReadLine();
                }
                file.Close();
            }
            string[] lastCodeParts = lastCode.Split();
            return lastCodeParts;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int number;
            lblIteration.Text = "0";
            if (txtCodesToGenerate.Text == "" || !int.TryParse(txtCodesToGenerate.Text, out number))
            {
                MessageBox.Show("Please enter the amount of codes to generate");
                txtCodesToGenerate.Focus();
            }
            else {
                // FolderBrowserDialog fbd = new FolderBrowserDialog();
                // DialogResult result = fbd.ShowDialog();
                codePath = selectPath("Please select a folder for your codes file");
                logPath = codePath;
                getDigits();
                

                //to test a specific value
                /*
                Dictionary<int, string> digits = setDigits();
                generateValues("86YR2C9B", digits);
                */
                
            }
        }
        public string openFile(string title)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = title;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = openFileDialog.OpenFile();
                string file = Path.GetFileName(openFileDialog.FileName);
                string path = Path.GetDirectoryName(openFileDialog.FileName);
                string fullPath = path + "\\" + file;
                return fullPath;
            }
            else
            {
                MessageBox.Show(title);
                return openFile(title);
            }
        }
        public string selectPath(string title) {
            string path = "";
            while (path == "")
            {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            path = fbd.SelectedPath;
                if (path == "")
                {
                    MessageBox.Show(title);
                }
            }
            return path;
        }
        private void Generator2_Load(object sender, EventArgs e)
        {
            cboWineType.SelectedIndex = 0;
            rtbCodes.Text = "For every generation select: \n -Folder for codes";
        }

        
    }
}
