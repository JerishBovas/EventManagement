
namespace CSAssignmentTwo
{
    partial class ViewControl
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
            this.listLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.searchId = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.ForeColor = System.Drawing.Color.Green;
            this.listLabel.Location = new System.Drawing.Point(39, 30);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(72, 38);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "List";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(181, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(870, 322);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // searchId
            // 
            this.searchId.AutoSize = true;
            this.searchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchId.Location = new System.Drawing.Point(562, 476);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(278, 25);
            this.searchId.TabIndex = 2;
            this.searchId.Text = "Please enter the Customer ID: ";
            this.searchId.Visible = false;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(958, 473);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(93, 30);
            this.idBox.TabIndex = 3;
            this.idBox.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(177, 576);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(60, 20);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "errord";
            this.errorLabel.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.DimGray;
            this.searchButton.Location = new System.Drawing.Point(834, 566);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(217, 42);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Delete Customer";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // ViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listLabel);
            this.Name = "ViewControl";
            this.Size = new System.Drawing.Size(1348, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label searchId;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button searchButton;
    }
}
