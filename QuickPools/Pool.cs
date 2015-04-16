using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel; 

namespace QuickPools
{
    public partial class Pool : UserControl
    {
        public Pool()
        {
            InitializeComponent();
        }


        //access to Pool Number
        public string PoolNumber
        {
            get { return txtPoolNum.Text; }
            set { txtPoolNum.Text = value; }
        }

        public List<Fencer> listOfFencers; 

        //access to List of Fencers
        public List<Fencer> PoolList
        {
            get { return listOfFencers; }
            set { listOfFencers = value; }
        }

        /// <summary>
        ///Export to Excel file
        /// </summary>
        private void btnXLS_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook|*.xls";
            DialogResult drSaveFile = sfd.ShowDialog();
            try
            {
                if (drSaveFile == System.Windows.Forms.DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel._Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    //ExcelApp.ActiveWorkbook.FileFormat = XlFileFormat.xlExcel8;   
                    // Change properties of the Workbook   
                    ExcelApp.Columns.ColumnWidth = 20;

                    // Storing header part in Excel   
                    for (int i = 1; i < dgvPoolTable.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dgvPoolTable.Columns[i - 1].HeaderText;
                    }

                    // Storing Each row and column value to excel sheet   
                    for (int i = 0; i < dgvPoolTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvPoolTable.Columns.Count; j++)
                        {
                            if (j == 2 || j == 5)
                            {
                                ExcelApp.Cells[i + 2, j + 1] = "'" + dgvPoolTable.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                ExcelApp.Cells[i + 2, j + 1] = dgvPoolTable.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

            
                    //Save file 
                    ExcelApp.ActiveWorkbook.SaveCopyAs(sfd.FileName);

                    //Close workbook and Excelapp
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                return;
            }


            //inform user
            MessageBox.Show("Completed.");

            
        }

        private void Pool_Load(object sender, EventArgs e)
        {

            //create dataTable
            System.Data.DataTable dt = new System.Data.DataTable();

            //
            //Add columns
            //

            //add Name & number
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("#", typeof(string)));


            //loop through each fencer
            foreach (Fencer fc in listOfFencers)
            {
                //add a column for Fencer's ID
                dt.Columns.Add(new DataColumn(fc.ID.ToString(), typeof(string)));

            }

            //
            //Add end Columns
            //

            //Victories
            dt.Columns.Add(new DataColumn("V", typeof(string)));

            //Touches Scored
            dt.Columns.Add(new DataColumn("TS", typeof(string)));

            //Touches Received
            dt.Columns.Add(new DataColumn("TR", typeof(string)));

            //Indicator
            dt.Columns.Add(new DataColumn("Ind", typeof(string)));

            //Place
            dt.Columns.Add(new DataColumn("Pl", typeof(string)));


            //
            // Add Rows
            //

            foreach (Fencer fc in listOfFencers)
            {
                //create a new row
                DataRow dr = dt.NewRow();

                //add name 
                string fencersName = fc.LastName + "," + fc.FirstName[0] + ".";
                dr["Name"] = fencersName;

                //add number
                dr["#"] = fc.ID;


                //add to datatable
                dt.Rows.Add(dr);

            }


            //Assign to datagridview
            dgvPoolTable.DataSource = dt;

            // Format DataGridView
            formatTable();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Grab Data
            System.Data.DataTable dataT = (System.Data.DataTable)(dgvPoolTable.DataSource);

            //get indexes
            int col1Index = dgvPoolTable.Columns["1"].Index;
            int colVIndex = dgvPoolTable.Columns["V"].Index;


            ///////////////////////
            //
            // Validate Input 
            //
            ///////////////////////

            //
            // Make sure all the values are filled in 
            // and are all integer values
            //

            //loop through columns
            for (int i = col1Index; i < colVIndex; i++)
            {

                //loop through rows 
                for (int r = 0; r < dataT.Rows.Count; r++)
                {


                    //get header number
                    int hdrNumber = Convert.ToInt32(dataT.Columns[i].ColumnName.ToString());
                    int rowIDNumber = Convert.ToInt32(dataT.Rows[r]["#"].ToString());

                    //if row ID and i are equal, skip 
                    //i.e. black square
                    if (hdrNumber == rowIDNumber)
                    {
                        continue;
                    }

                    //back sure it is numeric and not empty
                    string val = dataT.Rows[r][i].ToString();
                    int n;

                    //if nothing, stop
                    if (val == null || string.IsNullOrEmpty(val))
                    {
                        MessageBox.Show("Missing data");
                        return;
                    }

                    //if not an integer, stop
                    else if (!int.TryParse(val, out n))
                    {
                        MessageBox.Show("Invalid input");
                        return;
                    }

                }


            }


            ///////////////////////
            //
            // Calculate results 
            //
            ///////////////////////


            //
            //Touches Scored and Victories 
            //

            //loop through rows 
            for (int r = 0; r < dataT.Rows.Count; r++)
            {

                //reset & clear current values of Victories and Touches Scored
                int i_currentV = 0;
                int i_currentTS = 0;


                //loop through columns
                for (int i = col1Index; i < colVIndex; i++)
                {

                    //get score 
                    string s_score = dataT.Rows[r][i].ToString();

                    //If victory, add to V column
                    if (s_score == "V" || s_score == "5" || s_score == "V5")
                    {

                        //increase count by 1
                        i_currentV = 1 + i_currentV;

                        //add to touches scored
                        i_currentTS = 5 + i_currentTS;
                    }

                        //can't fence self
                    else if (s_score == "")
                    {
                        continue;
                    }

                    //didn't win, under 5 points
                    else
                    {
                        //get score 
                        int i_score = Convert.ToInt32(dataT.Rows[r][i]);

                        //increase touches scored
                        i_currentTS = i_score + i_currentTS;

                    }

                }

                //set values in datatable
                dataT.Rows[r]["TS"] = i_currentTS;
                dataT.Rows[r]["V"] = i_currentV;


                //
                //Calculate touches Received
                //

                int i_currentTR = 0;
                string s_currentID = dataT.Rows[r]["#"].ToString();
                int i_currentID = Convert.ToInt32(s_currentID);

                //Sum all the touches in the corresponding column 
                for (int s_rw = 0; s_rw < dataT.Rows.Count; s_rw++)
                {
                    //if not blank
                    if (dataT.Rows[s_rw][s_currentID].ToString() != "")
                    {
                        //add to i_currentTR
                        i_currentTR = i_currentTR + Convert.ToInt32(dataT.Rows[s_rw][s_currentID]);
                    }
                }


                //set to final value 
                dataT.Rows[r]["TR"] = i_currentTR;

                //
                //Calculate Indicator
                //

                int i_currentInd = i_currentTS - i_currentTR;
                dataT.Rows[r]["Ind"] = i_currentInd;

                //save values on Master List
                Fencer myFencer = listOfFencers.Find(x => x.ID == i_currentID);
                myFencer.pVictories = i_currentV;
                myFencer.pIndicator = i_currentInd;
                myFencer.pTouchesRec = i_currentTR;
                myFencer.pTouchesScored = i_currentTS;
            }


            ////////////////////////////
            // Calculate Current Places
            ////////////////////////////

            //Sort a list based on number of Victories 
            List<Fencer> tempList = listOfFencers.OrderByDescending(o => o.pVictories)
                                       .ThenByDescending(p => p.pIndicator).ToList();


            //loop through sorted list
            for (int j = 0; j < dataT.Rows.Count; j++)
            {
                //find the ID #
                int ID = Convert.ToInt32(dataT.Rows[j]["#"]);

                //find the matching place value 
                //after sorting, if in place 0, then got 1st place
                int placeValue = tempList.IndexOf(tempList.Find(x => x.ID == ID)) + 1;

                //set value on DataTable
                dataT.Rows[j]["Pl"] = placeValue;

            }
        }

        private void dgvPoolTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //reset color
            dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black; 

            //Get value entered
            string val = dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //for calulations
            int n;

            //make sue is a number
            if (!int.TryParse(val, out n))
            {

                //if not a V marking, then move on 
                if (val.ToUpper() != "V" && val.ToUpper() != "V5")
                {

                    // inform user
                    MessageBox.Show("Invalid input");

                    //clear cell and return
                    dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    return;
                }
                else
                {
                    dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "5";
                    val = "5";
                }

            }

            //convert to integer 
            int i_val = Convert.ToInt32(val);

            //Make sure the integer isn't an huge number
            if (i_val > 15)
            {
                MessageBox.Show("Invalid input");
                return;
            }


            //Get two fencer's IDs & Scores
            int i_fencerA;
            int i_fencerB;
            int i_fencerAScore;
            int i_fencerBScore;

            // A = column, B = Row
            //Get IDs
            i_fencerA = Convert.ToInt32(dgvPoolTable.Rows[e.RowIndex].Cells["#"].Value.ToString());
            i_fencerB = Convert.ToInt32(dgvPoolTable.Columns[e.ColumnIndex].HeaderText);
           
            //create dataTable 

            try
            {

                //access data through dataSource of dgv
                System.Data.DataTable DT = (System.Data.DataTable)dgvPoolTable.DataSource; 
                string s_FB = i_fencerB.ToString();
                string s_FA = i_fencerA.ToString();
           
                //if writing in fencer B 
                if (dgvPoolTable.Columns[e.ColumnIndex].HeaderText == i_fencerB.ToString())
                {
                    //already have 1 score, what we're writing in. Try to get other 
                   i_fencerBScore = Convert.ToInt32(DT.Rows[i_fencerB - 1][i_fencerA.ToString()].ToString());
   
                    //writing winning score
                    if (i_val > i_fencerBScore)
                    {
                        //won, rewrite in green 
                        dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;
                        dgvPoolTable.Rows[i_fencerB].Cells[i_fencerA.ToString()].Style.ForeColor = Color.Black;
                      
                    }

                    else if (i_val == 5 && i_val == i_fencerBScore)
                    {
                        //Show warning color of bad score 
                        dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Orange;
                        dgvPoolTable.Rows[i_fencerB].Cells[i_fencerA.ToString()].Style.ForeColor = Color.Orange;
                         
                    }

               
                    else if (i_val < i_fencerBScore)  //lost 
                    {
                        //this cell black, that one green
                        dgvPoolTable.Rows[i_fencerB].Cells[i_fencerA.ToString()].Style.ForeColor = Color.Green;
                        dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black; 
                 
                    }

                    else
                    {
                        //both black 
                        dgvPoolTable.Rows[i_fencerB].Cells[i_fencerA.ToString()].Style.ForeColor = Color.Black;
                        dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black; 


                    }


                }

                    //fencer A 
                else if (dgvPoolTable.Columns[e.ColumnIndex].HeaderText == i_fencerA.ToString())
                {
                    //already have 1 score, what we're writing in. Try to get other 
                    i_fencerAScore = Convert.ToInt32(DT.Rows[i_fencerA - 1][i_fencerB.ToString()].ToString());

                    //writing winning score
                    if (i_val > i_fencerAScore)
                    {
                        //won, rewrite in green 
                        dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;

                    }

                    else if (i_val == 5 && i_val == i_fencerAScore)
                    {
                        //Show warning color of bad score 
                        dgvPoolTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Orange;
                    }


                    else  //lost 
                    {
                        dgvPoolTable.Rows[i_fencerA].Cells[i_fencerB.ToString()].Style.ForeColor = Color.Green;
                    }

                }

 
                //FencerA's score = row of A's ID, column of B's ID



                
               
            }

            catch
            {
                //not all values are filled in yet, or are not valid values
                 return;
            }

            


        }


        /// <summary>
        /// Create blackout cells
        /// </summary>
        private void dgvPoolTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Create blackout cells

            for (int j = 0; j < dgvPoolTable.Rows.Count; j++)
            {
                for (int i = 0; i < dgvPoolTable.Columns.Count; i++)
                {
                    //Get values
                    string columnVal = dgvPoolTable.Columns[i].HeaderText;
                    string rowVal = dgvPoolTable.Rows[j].Cells["#"].Value.ToString();

                    //compare
                    if (columnVal == rowVal)
                    {
                        //black out cell 
                        dgvPoolTable.Rows[j].Cells[i].Style.BackColor = Color.Black;
                        dgvPoolTable.Rows[j].Cells[i].ReadOnly = true;
                    }

                }
            }
        }
        
        /// <summary>
        /// Cleanup Sizes and sorting
        /// </summary>
        public void formatTable()
        {
            //autosize columns
            dgvPoolTable.AutoResizeColumns();

            //remove sorting
            dgvPoolTable.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            //Read Only 
            dgvPoolTable.Columns["#"].ReadOnly = true;
            dgvPoolTable.Columns["Name"].ReadOnly = true;
            dgvPoolTable.Columns["V"].ReadOnly = true;
            dgvPoolTable.Columns["TS"].ReadOnly = true;
            dgvPoolTable.Columns["TR"].ReadOnly = true;
            dgvPoolTable.Columns["Pl"].ReadOnly = true; 



        }
        
    }
}
