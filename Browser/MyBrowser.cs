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

namespace Browser
{
    public partial class MyBrowser : Form
    {
        int tabCounter = 0;
        public MyBrowser()
        {
            InitializeComponent();

            historyBox.Text = File.ReadAllText("history");
            bookmarks.Items.AddRange(File.ReadAllLines("bookmarks"));
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
            tabCounter++;
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
                File.AppendAllText("history", searchBox.Text + "\n");
                historyBox.Text = File.ReadAllText("history");
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
                tabCounter--;
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
                File.AppendAllText("history", searchBox.Text + "\n");
                historyBox.Text = File.ReadAllText("history");
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
            tabCounter++;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabController.SelectedTab.Controls[0]).Stop();
        }

        ListBox bookmarks = new ListBox();

        private void BookmarkButton_Click(object sender, EventArgs e)
        {
            tabController.TabPages.Add("Закладки");
            tabController.SelectTab(tabCounter);
            tabController.SelectedTab.Controls.Add(bookmarks);
            bookmarks.Dock = DockStyle.Fill;
            bookmarks.ContextMenuStrip = deleteHistoryMenu;
            tabCounter++;
        }

        private void AddBookmarkButton_Click(object sender, EventArgs e)
        {
            File.AppendAllText("bookmarks", tabController.SelectedTab.Text + "\n");
            bookmarks.Items.Add(tabController.SelectedTab.Text + "\n");
        }

        private void DeleteBookmarkButton_Click(object sender, EventArgs e)
        {
            List<string> bookmarksContent = new List<string>();
            bookmarksContent.AddRange(File.ReadAllLines("bookmarks"));
            bookmarksContent.RemoveAt(bookmarks.SelectedIndex);
            File.WriteAllLines("bookmarks", bookmarksContent);
            bookmarks.Items.RemoveAt(bookmarks.SelectedIndex);
        }

        RichTextBox historyBox = new RichTextBox();

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            tabController.TabPages.Add("История");
            tabController.SelectTab(tabCounter);
            tabController.SelectedTab.Controls.Add(historyBox);
            historyBox.Dock = DockStyle.Fill;
            historyBox.ReadOnly = true;
            tabCounter++;
        }
    }
}
