
namespace Browser
{
    partial class MyBrowser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBrowser));
            this.topButtonStrip = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.addBookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.dropButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.bookmarkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.historyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tabController = new System.Windows.Forms.TabControl();
            this.deleteHistoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteBookmarkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.topButtonStrip.SuspendLayout();
            this.deleteHistoryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topButtonStrip
            // 
            this.topButtonStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.topButtonStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.refreshButton,
            this.stopButton,
            this.homeButton,
            this.searchBox,
            this.searchButton,
            this.addButton,
            this.deleteButton,
            this.addBookmarkButton,
            this.dropButton});
            this.topButtonStrip.Location = new System.Drawing.Point(0, 0);
            this.topButtonStrip.Name = "topButtonStrip";
            this.topButtonStrip.Size = new System.Drawing.Size(1105, 27);
            this.topButtonStrip.TabIndex = 0;
            this.topButtonStrip.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 24);
            this.backButton.Text = "Нажмите, чтобы вернуться";
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(29, 24);
            this.forwardButton.Text = "Нажмите, чтобы перейти вперед";
            this.forwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(29, 24);
            this.refreshButton.Text = "Обновить эту страницу";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(29, 24);
            this.stopButton.Text = "Остановить загрузку этой страницы";
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(29, 24);
            this.homeButton.Text = "Перейти на главную страницу";
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(600, 27);
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(29, 24);
            this.searchButton.Text = "Поиск";
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(29, 24);
            this.addButton.Text = "Новая вкладка";
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(29, 24);
            this.deleteButton.Text = "Удалить эту вкладку";
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addBookmarkButton
            // 
            this.addBookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addBookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("addBookmarkButton.Image")));
            this.addBookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBookmarkButton.Name = "addBookmarkButton";
            this.addBookmarkButton.Size = new System.Drawing.Size(29, 24);
            this.addBookmarkButton.Text = "Добавить эту страницу в закладки";
            this.addBookmarkButton.Click += new System.EventHandler(this.AddBookmarkButton_Click);
            // 
            // dropButton
            // 
            this.dropButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkButton,
            this.historyButton});
            this.dropButton.Image = ((System.Drawing.Image)(resources.GetObject("dropButton.Image")));
            this.dropButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(34, 24);
            this.dropButton.Text = "Ещё...";
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(224, 26);
            this.bookmarkButton.Text = "Закладки";
            this.bookmarkButton.Click += new System.EventHandler(this.BookmarkButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(224, 26);
            this.historyButton.Text = "История";
            this.historyButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // tabController
            // 
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 27);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1105, 578);
            this.tabController.TabIndex = 1;
            // 
            // deleteHistoryMenu
            // 
            this.deleteHistoryMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deleteHistoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBookmarkButton});
            this.deleteHistoryMenu.Name = "deleteHistoryMenu";
            this.deleteHistoryMenu.Size = new System.Drawing.Size(135, 28);
            this.deleteHistoryMenu.Text = "deleteHistoryMenu";
            // 
            // deleteBookmarkButton
            // 
            this.deleteBookmarkButton.Name = "deleteBookmarkButton";
            this.deleteBookmarkButton.Size = new System.Drawing.Size(134, 24);
            this.deleteBookmarkButton.Text = "Удалить";
            this.deleteBookmarkButton.Click += new System.EventHandler(this.DeleteBookmarkButton_Click);
            // 
            // MyBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 605);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.topButtonStrip);
            this.Name = "MyBrowser";
            this.Text = "MyBrowser";
            this.Load += new System.EventHandler(this.MyBrowser_Load);
            this.topButtonStrip.ResumeLayout(false);
            this.topButtonStrip.PerformLayout();
            this.deleteHistoryMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip topButtonStrip;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton homeButton;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton addBookmarkButton;
        private System.Windows.Forms.ToolStripDropDownButton dropButton;
        private System.Windows.Forms.ToolStripMenuItem bookmarkButton;
        private System.Windows.Forms.ToolStripMenuItem historyButton;
        private System.Windows.Forms.ContextMenuStrip deleteHistoryMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteBookmarkButton;
    }
}

