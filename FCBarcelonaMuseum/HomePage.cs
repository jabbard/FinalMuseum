using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCBarcelonaMuseum
{
    public partial class HomePage : Form
    {
        public List<Visitors> LsVisitors = new List<Visitors>();

        public HomePage()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void ToCSV(String data)
        {
            String path = @"Data.csv";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(data);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Regex rx = new Regex(@"^98*([0-9]{8})$");
                Regex rgx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Regex name = new Regex(@"^\w+\s\w+\s?\w+$");

                int cardNo = 0;
                    
                String path = @"Data.csv";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                using (StreamReader reader = new StreamReader(path))
                {
                    String line = "";
                    if (File.Exists(@"Data.csv"))
                    {
                        int[] cN = new int[dataGridTable.RowCount];
                        int counter = 0;
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            String[] rowData = line.Split(',');
                            cardNo = int.Parse(rowData[0]);
                            cN[counter] = int.Parse(rowData[0]);
                            counter++;
                        }
                        int greatest = 0;
                        for(int i =0; i<cN.Length; i++)
                        {
                            if (cN[i] > greatest)
                            {
                                greatest = cN[i];
                            }
                        }
                        if (cardNo >= greatest)
                        {
                            cardNo = ++cardNo;
                        }
                        else
                        {
                            cardNo = greatest + 1;
                        }
                            
                    }

                }
                String visitorName;
                if (String.IsNullOrEmpty(txtName.Text.Trim()) || !rgx.IsMatch(txtName.Text.Trim()))
                {
                    MessageBox.Show("The name field is empty!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    visitorName = txtName.Text.Trim();
                }
                String email;
                if (String.IsNullOrEmpty(txtEmail.Text.Trim()) || !name.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("The email field is empty!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    email = txtEmail.Text.Trim();
                }
                String occupation;
                if(cmbOccupation.SelectedItem==null)
                {
                    MessageBox.Show("Please select an occupation","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnClearAll.PerformClick();
                    return; 
                } else
                {
                    occupation = cmbOccupation.Text;
                }

                String gender;

                if (radMale.Checked)
                {
                    gender = radMale.Text;
                }
                else
                {
                    gender = radFemale.Text;
                }
                    
                DateTime inTime = DateTime.Now;
                DateTime outTime = default(DateTime);
                TimeSpan opens = new TimeSpan(10, 0, 0);
                TimeSpan closes = new TimeSpan(17, 0, 0);
                DayOfWeek day = inTime.DayOfWeek;
                //if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
                //{
                //    MessageBox.Show("The museum is closed.");
                //    btnClearAll.PerformClick();
                //    return;
                //}
                //else if (inTime.TimeOfDay > opens && inTime.TimeOfDay < closes)
                //{
                        
                //}
                //else
                //{
                //    MessageBox.Show("The musuem is now close, please visit between 10 AM and 5 PM");
                //    btnClearAll.PerformClick();
                //    return;
                //}

                String phNo;
                if (String.IsNullOrEmpty(txtPhNo.Text.Trim()) || !rx.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("The name field is empty!","Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    phNo = txtPhNo.Text.Trim();
                }
                int check = ValidateRedundancy(visitorName, phNo, occupation, gender, email);
                if(check == 0)
                {
                    MessageBox.Show("This is an old visitor.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnClearAll.PerformClick();
                    return;
                }
                Visitors visitors = new Visitors(cardNo, visitorName, phNo, email, occupation, gender, inTime, outTime, day);
                LsVisitors.Add(visitors);
                String data = cardNo + "," + visitorName + "," + phNo + "," + email + "," + occupation + "," + gender + "," + inTime + "," + outTime + "," + day;
                ToCSV(data);
                LoadGrid();
                MessageBox.Show("The visitor has been registered and checked in with card no."+cardNo+".", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
            catch (Exception f)
            {
                MessageBox.Show("The values entered are either missing or incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private int ValidateRedundancy(String name, String phone, String occupation, String gender, String email)
        {
            int value = 1;
            foreach(Visitors v in LsVisitors)
            {
                if (name.Equals(v.Name) && phone.Equals(v.PhNo) && occupation.Equals(v.Occupation) && gender.Equals(v.Gender) && email.Equals(v.Email))
                {
                    value = 0;
                }
            }
            return value;
        }
        
        private void LoadGrid()
        {
            try
            {
                String path = @"Data.csv";
                using (StreamReader reader = new StreamReader(path))
                {
                    String line = "";
                    if (File.Exists(path))
                    {
                        dataGridTable.Rows.Clear();
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            String[] rowData = line.Split(',');
                            int rowNum = dataGridTable.Rows.Add();
                            DataGridViewRow row = dataGridTable.Rows[rowNum];

                            String inn = rowData[6];
                            DateTime t = DateTime.Parse(rowData[6]);

                            row.Cells["ColnCardNum"].Value = rowData[0];
                            row.Cells["ColnFullName"].Value = rowData[1];
                            row.Cells["ColnPhNum"].Value = rowData[2];
                            row.Cells["ColnEmail"].Value = rowData[3];
                            row.Cells["ColnOccupation"].Value = rowData[4];
                            row.Cells["ColnGender"].Value = rowData[5];
                            row.Cells["ColnInTime"].Value = DateTime.Parse(rowData[6]).ToString("hh:mm tt");
                            DateTime outTime = DateTime.Parse(rowData[7]);
                            if (!outTime.Equals(default(DateTime)))
                            {
                                row.Cells["ColnOutTime"].Value = outTime.ToString("hh:mm tt");
                            }
                            row.Cells["ColnDay"].Value = rowData[8];

                            Visitors visitors = new Visitors(int.Parse(rowData[0]), rowData[1], rowData[2], rowData[3], rowData[4], rowData[5], DateTime.Parse(rowData[6]), DateTime.Parse(rowData[7]), DateTime.Parse(rowData[6]).DayOfWeek);

                            LsVisitors.Add(visitors);

                        }


                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while loading data from the csv file.", "Error!");
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhNo.Text = "";
            cmbOccupation.SelectedItem = null;
            cmbOccupation.SelectedText = "Select an occupation";
            txtEmail.Text = "";
            radMale.Checked = true;
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                int cardNo = int.Parse(txtCardNo.Text);
                int cNo = 0;
                String name = "";
                String phNo = "";
                String email = "";
                String occupation = "";
                String gender = "";
                DateTime inTime = DateTime.Now;
                DateTime outTime = default(DateTime);
                DayOfWeek day = inTime.DayOfWeek;
                foreach (Visitors v in LsVisitors)
                {
                    if (v.CardNo == cardNo && !v.OutTime.Equals(default(DateTime)))
                    {
                        cNo = v.CardNo;
                        name = v.Name;
                        phNo = v.PhNo;
                        email = v.Email;
                        occupation = v.Occupation;
                        gender = v.Gender;
                        txtCardNo.Text = "";
                    } else if (v.CardNo == cardNo && v.OutTime.Equals(default(DateTime)))
                    {
                        MessageBox.Show("This visitor has not exited previously.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCardNo.Text = "";
                        return;
                    }
                }
                Visitors visit = new Visitors(cNo, name, phNo, email, occupation, gender, inTime, outTime, day);
                LsVisitors.Add(visit);
                String data = cNo + "," + name + "," + phNo + "," + email + "," + occupation + "," + gender + "," + inTime + "," + outTime + "," + day;
                ToCSV(data);
                MessageBox.Show("The visitor has checked in.", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            } catch (Exception a)
            {
                MessageBox.Show("Enter correct value!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNo.Text = "";
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                int cardNo = int.Parse(txtCardNoOut.Text);
                
                String[] lines = File.ReadAllLines(@"Data.csv");
                using (StreamWriter writer = new StreamWriter(@"Data.csv"))
                {
                    int counter = 1;
                    for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                    {
                        if (cardNo == LsVisitors[currentLine-1].CardNo && LsVisitors[currentLine-1].OutTime.Equals(default(DateTime)))
                        {
                            LsVisitors[currentLine - 1].OutTime = DateTime.Now;
                            writer.WriteLine(LsVisitors[currentLine - 1].CardNo + "," + LsVisitors[currentLine - 1].Name + "," + LsVisitors[currentLine - 1].PhNo + "," + LsVisitors[currentLine - 1].Email + "," + LsVisitors[currentLine - 1].Occupation + "," + LsVisitors[currentLine - 1].Gender + "," + LsVisitors[currentLine - 1].InTime + "," + DateTime.Now + "," + LsVisitors[currentLine - 1].Day);
                            MessageBox.Show("The user has checked out.", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCardNoOut.Text = "";
                        }
                        else if(cardNo == LsVisitors[currentLine-1].CardNo && !LsVisitors[currentLine - 1].OutTime.Equals(default(DateTime)))
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                            MessageBox.Show("The user has already checked out.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCardNoOut.Text = "";
                            return;
                        } else
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                            if (counter == lines.Length)
                            {
                                MessageBox.Show("User not found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            counter++;
                        }
                    }
                }
                LoadGrid();


            }
            catch (Exception error)
            {
                MessageBox.Show("Cannot checkout!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void WeeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.Show();
        }

        private void DailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyReport dailyReport = new DailyReport();
            dailyReport.Show();
        }
    }
}
