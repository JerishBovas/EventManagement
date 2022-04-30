
namespace CSAssignmentTwo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSVPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRSVPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRSVPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.rSVPToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewAllCustomersToolStripMenuItem,
            this.viewCustomerDetailsToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.viewAllEventsToolStripMenuItem,
            this.viewEventDetailToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // viewAllEventsToolStripMenuItem
            // 
            this.viewAllEventsToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_view_all_48;
            this.viewAllEventsToolStripMenuItem.Name = "viewAllEventsToolStripMenuItem";
            this.viewAllEventsToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.viewAllEventsToolStripMenuItem.Text = "View All Events";
            this.viewAllEventsToolStripMenuItem.Click += new System.EventHandler(this.viewAllEventsToolStripMenuItem_Click);
            // 
            // viewEventDetailToolStripMenuItem
            // 
            this.viewEventDetailToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_more_details_64;
            this.viewEventDetailToolStripMenuItem.Name = "viewEventDetailToolStripMenuItem";
            this.viewEventDetailToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.viewEventDetailToolStripMenuItem.Text = "View Event Details";
            this.viewEventDetailToolStripMenuItem.Click += new System.EventHandler(this.viewEventDetailToolStripMenuItem_Click);
            // 
            // rSVPToolStripMenuItem
            // 
            this.rSVPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRSVPToolStripMenuItem,
            this.viewRSVPsToolStripMenuItem});
            this.rSVPToolStripMenuItem.Name = "rSVPToolStripMenuItem";
            this.rSVPToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.rSVPToolStripMenuItem.Text = "RSVP";
            // 
            // viewRSVPsToolStripMenuItem
            // 
            this.viewRSVPsToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_view_all_48;
            this.viewRSVPsToolStripMenuItem.Name = "viewRSVPsToolStripMenuItem";
            this.viewRSVPsToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.viewRSVPsToolStripMenuItem.Text = "View RSVPs";
            this.viewRSVPsToolStripMenuItem.Click += new System.EventHandler(this.viewRSVPsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1348, 690);
            this.mainPanel.TabIndex = 1;
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_add_user_male_48;
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewAllCustomersToolStripMenuItem
            // 
            this.viewAllCustomersToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_view_all_48;
            this.viewAllCustomersToolStripMenuItem.Name = "viewAllCustomersToolStripMenuItem";
            this.viewAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.viewAllCustomersToolStripMenuItem.Text = "View All Customers";
            this.viewAllCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewAllCustomersToolStripMenuItem_Click);
            // 
            // viewCustomerDetailsToolStripMenuItem
            // 
            this.viewCustomerDetailsToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_more_details_64;
            this.viewCustomerDetailsToolStripMenuItem.Name = "viewCustomerDetailsToolStripMenuItem";
            this.viewCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.viewCustomerDetailsToolStripMenuItem.Text = "View Customer Details";
            this.viewCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerDetailsToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_delete_user_male_50;
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_event_64;
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // addRSVPToolStripMenuItem
            // 
            this.addRSVPToolStripMenuItem.Image = global::CSAssignmentTwo.Properties.Resources.icons8_like_message_64;
            this.addRSVPToolStripMenuItem.Name = "addRSVPToolStripMenuItem";
            this.addRSVPToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.addRSVPToolStripMenuItem.Text = "Add RSVP";
            this.addRSVPToolStripMenuItem.Click += new System.EventHandler(this.addRSVPToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSVPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRSVPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRSVPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventDetailToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
    }
}

