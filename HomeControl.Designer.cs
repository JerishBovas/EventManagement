
namespace CSAssignmentTwo
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.createRSVP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getStartedLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addCustomerTool = new System.Windows.Forms.ToolTip(this.components);
            this.createEventTool = new System.Windows.Forms.ToolTip(this.components);
            this.mkRSVPTool = new System.Windows.Forms.ToolTip(this.components);
            this.mkRSVP = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.createEvent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.mkRSVP);
            this.panel1.Controls.Add(this.createRSVP);
            this.panel1.Controls.Add(this.addCustomer);
            this.panel1.Controls.Add(this.createEvent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getStartedLabel);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 690);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(159, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Let\'s get started using these quick links";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1030, 549);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 50);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // createRSVP
            // 
            this.createRSVP.AutoSize = true;
            this.createRSVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRSVP.ForeColor = System.Drawing.Color.ForestGreen;
            this.createRSVP.Location = new System.Drawing.Point(460, 475);
            this.createRSVP.Name = "createRSVP";
            this.createRSVP.Size = new System.Drawing.Size(219, 32);
            this.createRSVP.TabIndex = 9;
            this.createRSVP.Text = "Make an RSVP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(460, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create an Event";
            // 
            // getStartedLabel
            // 
            this.getStartedLabel.AutoSize = true;
            this.getStartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartedLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.getStartedLabel.Location = new System.Drawing.Point(462, 266);
            this.getStartedLabel.Name = "getStartedLabel";
            this.getStartedLabel.Size = new System.Drawing.Size(232, 32);
            this.getStartedLabel.TabIndex = 4;
            this.getStartedLabel.Text = "Add a Customer";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(156, 91);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(1017, 44);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to Jerish-Sanjay\'s Event Management System";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mkRSVP
            // 
            this.mkRSVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkRSVP.ForeColor = System.Drawing.Color.Black;
            this.mkRSVP.Image = global::CSAssignmentTwo.Properties.Resources.icons8_like_message_64;
            this.mkRSVP.Location = new System.Drawing.Point(709, 458);
            this.mkRSVP.Name = "mkRSVP";
            this.mkRSVP.Size = new System.Drawing.Size(85, 70);
            this.mkRSVP.TabIndex = 3;
            this.mkRSVP.UseVisualStyleBackColor = true;
            this.mkRSVP.Click += new System.EventHandler(this.mkRSVP_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Image = global::CSAssignmentTwo.Properties.Resources.icons8_add_user_male_48;
            this.addCustomer.Location = new System.Drawing.Point(709, 252);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(85, 70);
            this.addCustomer.TabIndex = 1;
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // createEvent
            // 
            this.createEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEvent.ForeColor = System.Drawing.Color.Black;
            this.createEvent.Image = global::CSAssignmentTwo.Properties.Resources.icons8_event_64;
            this.createEvent.Location = new System.Drawing.Point(709, 354);
            this.createEvent.Name = "createEvent";
            this.createEvent.Size = new System.Drawing.Size(85, 70);
            this.createEvent.TabIndex = 2;
            this.createEvent.UseVisualStyleBackColor = true;
            this.createEvent.Click += new System.EventHandler(this.createEvent_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1348, 690);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label getStartedLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createEvent;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button mkRSVP;
        private System.Windows.Forms.Label createRSVP;
        private System.Windows.Forms.ToolTip addCustomerTool;
        private System.Windows.Forms.ToolTip createEventTool;
        private System.Windows.Forms.ToolTip mkRSVPTool;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
    }
}
