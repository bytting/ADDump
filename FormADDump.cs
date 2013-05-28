using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace ADDump
{
    public partial class FormADDump : Form
    {        
        public FormADDump()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void menuItemDump_Click(object sender, EventArgs e)
        {
            DirectorySearcher ds = null;
            SearchResultCollection src = null;
            ColumnHeader colHead;

            Cursor savedCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            Application.DoEvents();

            list.Items.Clear();
            list.Columns.Clear();
            statusLabelCounter.Text = "";            

            try
            {                
                string filter = "(|(&(objectCategory=user)(name=*)))";

                ds = new DirectorySearcher();
                ds.SearchRoot = new DirectoryEntry("");
                ds.Filter = filter;
                ds.PropertyNamesOnly = true;

                if (cbName.Checked)
                {                    
                    colHead = new ColumnHeader();
                    colHead.Text = "Name";
                    colHead.Width = 150;                    
                    list.Columns.Add(colHead);      
                    ds.PropertiesToLoad.Add("name");
                }

                if (cbUsername.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Username";
                    colHead.Width = 150;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("sAMAccountName");
                }

                if (cbFirstname.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Firstname";
                    colHead.Width = 100;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("givenName");
                }

                if (cbLastname.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Lastname";
                    colHead.Width = 100;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("sn");
                }

                if (cbMail.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Email";
                    colHead.Width = 200;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("mail");
                }

                if (cbPhone.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Phone";
                    colHead.Width = 80;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("telephoneNumber");
                }

                if (cbAlias.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Alias";
                    colHead.Width = 100;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("Alias");
                }

                if (cbTitle.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Title";
                    colHead.Width = 100;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("Title");
                }

                if (cbDepartment.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Department";
                    colHead.Width = 100;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("Department");
                }

                if (cbCompany.Checked)
                {
                    colHead = new ColumnHeader();
                    colHead.Text = "Company";
                    colHead.Width = 100;
                    list.Columns.Add(colHead);
                    ds.PropertiesToLoad.Add("Company");
                }
                
                ds.PropertiesToLoad.Add("memberOf");

                ds.CacheResults = true;
                ds.ReferralChasing = ReferralChasingOption.None;
                ds.Sort = new SortOption("Name", SortDirection.Ascending);                                                

                src = ds.FindAll();
                DirectoryEntry de = null;
                int nEntries = 0;
                foreach (SearchResult sr in src)
                {
                    de = sr.GetDirectoryEntry();
                    if (String.Compare(de.SchemaClassName, "User", true) == 0)
                    {
                        AddUserItem(de);
                        ++nEntries;
                    }
                }

                statusLabelCounter.Text = nEntries.ToString() + " entries found";                
                buttonCopyToClipboard.Enabled = true;
                copyContextMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {                
                buttonCopyToClipboard.Enabled = false;
                copyContextMenuItem.Enabled = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(src != null)
                    src.Dispose();
                if(ds != null)
                    ds.Dispose();
                Cursor.Current = savedCursor;
            }             
        }

        public void AddUserItem(DirectoryEntry de)
        {
            ListViewItem lvi = null;
            ListViewItem.ListViewSubItem lvsi = null;

            if (cbName.Checked)
            {
                lvi = new ListViewItem();
                lvi.Text = de.Name.Substring(3);                 
            }

            if (cbUsername.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["sAMAccountName"].Count <= 0 ? "" : de.Properties["sAMAccountName"][0].ToString();                
                lvi.SubItems.Add(lvsi);
            }

            if (cbFirstname.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["givenName"].Count <= 0 ? "" : de.Properties["givenName"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            if (cbLastname.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["sn"].Count <= 0 ? "" : de.Properties["sn"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            if (cbMail.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["mail"].Count <= 0 ? "" : de.Properties["mail"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            if (cbPhone.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["telephoneNumber"].Count <= 0 ? "" : de.Properties["telephoneNumber"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            if (cbAlias.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["alias"].Count <= 0 ? "" : de.Properties["alias"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            if (cbTitle.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["Title"].Count <= 0 ? "" : de.Properties["Title"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            if (cbDepartment.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["Department"].Count <= 0 ? "" : de.Properties["Department"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            if (cbCompany.Checked)
            {
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = de.Properties["Company"].Count <= 0 ? "" : de.Properties["Company"][0].ToString();
                lvi.SubItems.Add(lvsi);
            }

            //lvsi = new ListViewItem.ListViewSubItem();            
            string tip = "";
            foreach (object o in de.Properties["memberOf"])
            {
                tip += o.ToString() + "|";
            }
            //lvi.SubItems.Add(lvsi);
            
            lvi.Tag = tip;

            list.Items.Add(lvi);                        
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                buttonRemoveSelected.Enabled = true;
                removeContextMenuItem.Enabled = true;
            }
            else
            {
                buttonRemoveSelected.Enabled = false;
                removeContextMenuItem.Enabled = false;
            }
        }

        public void CopyListViewToClipboard(ListView lv)
        {
            StringBuilder buffer = new StringBuilder();            

            for (int i = 0; i < lv.Items.Count; i++)
            {
                for (int j = 0; j < lv.Columns.Count; j++)
                {
                    buffer.Append(lv.Items[i].SubItems[j].Text);
                    buffer.Append(":");
                }

                if(buffer.Length > 0)
                    buffer.Remove(buffer.Length - 1, 1);
                buffer.Append(Environment.NewLine);
            }
            Clipboard.SetText(buffer.ToString());
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            CopyListViewToClipboard(list);
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list.SelectedItems)
                list.Items.Remove(item);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void btnListGroups_Click(object sender, EventArgs e)
        {
            lbGroups.Items.Clear();            
            if (list.SelectedItems.Count > 0)
            {
                ListViewItem item = list.SelectedItems[0];

                labelCurrentGroups.Text = item.SubItems[0].Text + " groups";

                char[] dom_separators = { '|' };
                char[] unit_separators = { ',' };
                char[] kv_separators = { '=' };

                string dom = (string)item.Tag;

                string[] dirs = dom.Split(dom_separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string dir in dirs)
                {
                    string[] units = dir.Split(unit_separators, StringSplitOptions.RemoveEmptyEntries);
                    //List<string> value_list = new List<string>();
                    string grp = "";
                    foreach (string unit in units)
                    {
                        string[] kv = unit.Split(kv_separators, StringSplitOptions.RemoveEmptyEntries);
                        if (kv.Length < 2)
                            continue;
                        //value_list.Add(kv[1]);
                        grp += kv[1] + "::";
                    }

                    //value_list.Reverse();

                    //string grp = "";
                    //foreach (string s in value_list)
                        //grp += s + ":";

                    lbGroups.Items.Add(grp);
                }

                /*
                string groups = (string)item.Tag;
                char[] separators = { '|' };
                string[] grps = groups.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in grps)
                    lbGroups.Items.Add(s);
                 * */
            }
        }                  
    }
}
