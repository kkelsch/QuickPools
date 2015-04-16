using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickPools
{
    public partial class Main : Form
    {
        //Publically accessible list of fencers
        public static List<Fencer> listOfFencers
        {
            get;
            set;
        }
     

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to setup the form & ID numbers
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            //Start Off initial ID Numbers
            dgvFencers.Rows[0].Cells["ID"].Value = "1";

        }


        /// <summary>
        /// When new rows are added, update the ID numbering
        /// </summary>
        private void dgvFencers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Add New ID number
            dgvFencers.Rows[e.RowIndex].Cells["ID"].Value = e.RowIndex + 1; 
        }



        /// <summary>
        /// Next button validates data and moves to create pools
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            //
            //Make sure all values are entered into datagrid view & 
            //populate list of fencers
            //

            //clean & reset list
            listOfFencers = new List<Fencer>();
            
            //Loop through each row
            for (int j = 0; j < dgvFencers.Rows.Count - 1; j++)
            {
                //Loop through each column 
                for (int i = 0; i < dgvFencers.Rows[j].Cells.Count; i++)
                {
                    //if one is null then report 
                    if (dgvFencers.Rows[j].Cells[i].Value == null || String.IsNullOrEmpty(dgvFencers.Rows[j].Cells[i].Value.ToString()))
                    {
                        
                        //If not new row, report null data
                        MessageBox.Show("Missing " + dgvFencers.Columns[i].HeaderText + " in ID #" + (dgvFencers.Rows[j].Index + 1));
                        return; 
                    }
                }

          
                //create new fencer
                Fencer tempFencer = new Fencer();

                //populate values 
                tempFencer.ID = Convert.ToInt32(dgvFencers.Rows[j].Cells["ID"].Value);
                tempFencer.FirstName = dgvFencers.Rows[j].Cells["FirstName"].Value.ToString();
                tempFencer.LastName = dgvFencers.Rows[j].Cells["LastName"].Value.ToString();


                //Add to list
                listOfFencers.Add(tempFencer);
            }
                                
         
            //Go to next thing 
            PoolSheet form = new PoolSheet();
            form.Show();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvFencers.Rows.Clear(); 
        }

       

    }
}
