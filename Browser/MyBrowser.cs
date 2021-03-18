using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class MyBrowser : Form
    {
        int tabCounter = 0;
        public MyBrowser()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += Browser_DocumentCompleted;
            tabController.TabPages.Add("Новая вкладка");
            tabController.SelectTab(tabCounter);
            tabController.SelectedTab.Controls.Add(browser);
            tabCounter += 1;
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabController.SelectedTab.Text = ((WebBrowser)tabController.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != null)
            {
                ((WebBrowser)tabController.SelectedTab.Controls[0]).Navigate(searchBox.Text);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabController.SelectedTab.Controls[0]).GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabController.SelectedTab.Controls[0]).GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabController.SelectedTab.Controls[0]).Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabController.SelectedTab.Controls[0]).GoHome();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (tabController.TabPages.Count > 1)
            {
                tabController.TabPages.RemoveAt(tabController.SelectedIndex);
                tabController.SelectTab(tabController.TabPages.Count - 1);
                tabCounter -= 1;
            }
            else
            {
                this.Close();
            }
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabController.SelectedTab.Controls[0]).Navigate(searchBox.Text);
            }
        }

        private void MyBrowser_Load(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += Browser_DocumentCompleted;
            tabController.TabPages.Add("Новая вкладка");
            tabController.SelectTab(tabCounter);
            tabController.SelectedTab.Controls.Add(browser);
            tabCounter += 1;
        }
    }
}
