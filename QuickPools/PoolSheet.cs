using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace QuickPools
{
    public partial class PoolSheet : Form
    {
        public PoolSheet()
        {
            InitializeComponent();
         }

        /// <summary>
        /// Used to setup the pool sheet & Fencers
        /// </summary>
        private void PoolSheet_Load(object sender, EventArgs e)
        {
            //Create a new pool
            Pool myPool = new Pool();
            myPool.PoolList = new List<Fencer>(Main.listOfFencers);

            //Add to tab control
            myPool.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(myPool);
            this.tabPoolCollection.TabPages.Add(myTabPage);  

            //number tab page
            myTabPage.Text = "Pool1";
            myPool.PoolNumber = "1";
            myPool.Name = "Pool1";
            
        }

        /// <summary>
        /// Copy and Create a new pool of the same type
        /// </summary>
        private void duplicateSelectedPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //get selected tab
                TabPage selectedTab = this.tabPoolCollection.SelectedTab;
                string tabText = selectedTab.Text.ToString();
                Pool tabPool = new Pool();

                //Grab selected Tab's pool information
                if (selectedTab.Controls.ContainsKey(tabText))
                {
                    tabPool = (Pool)selectedTab.Controls[tabText];
                }

                //Create a new pool
                Pool myPool = new Pool();
                myPool.PoolList = new List<Fencer>(tabPool.PoolList);

                //Add to tab control
                myPool.Dock = DockStyle.Fill;
                TabPage myTabPage = new TabPage();//Create new tabpage
                myTabPage.Controls.Add(myPool);
                this.tabPoolCollection.TabPages.Add(myTabPage);

                //number tab page
                myTabPage.Text = "Pool" + (tabPoolCollection.TabPages.Count);
                myPool.PoolNumber = (tabPoolCollection.TabPages.Count).ToString();
                myPool.Name = myTabPage.Text;
            }
            catch
            {
                MessageBox.Show("Error making new tab.");
            }

          
        }

      

    }
}
