﻿namespace BugTrackingSoftware
{
    partial class BugSolutionForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_List = new System.Windows.Forms.TabPage();
            this.lbl_PpUsertypeshow = new System.Windows.Forms.Label();
            this.lbl_PpUseernameshow = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_PpUserIdshow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_PpBugId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_PpSubjectshow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt_PpUpdateCode = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxt_PpErrorCode = new System.Windows.Forms.RichTextBox();
            this.dataGridView_Bug = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ViewImage = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bug)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_List);
            this.tabControl1.Location = new System.Drawing.Point(10, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 709);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_List
            // 
            this.tab_List.Controls.Add(this.btn_Submit);
            this.tab_List.Controls.Add(this.btn_ViewImage);
            this.tab_List.Controls.Add(this.lbl_PpUsertypeshow);
            this.tab_List.Controls.Add(this.lbl_PpUseernameshow);
            this.tab_List.Controls.Add(this.label9);
            this.tab_List.Controls.Add(this.lbl_PpUserIdshow);
            this.tab_List.Controls.Add(this.label5);
            this.tab_List.Controls.Add(this.lbl_PpBugId);
            this.tab_List.Controls.Add(this.label4);
            this.tab_List.Controls.Add(this.lbl_PpSubjectshow);
            this.tab_List.Controls.Add(this.label3);
            this.tab_List.Controls.Add(this.label2);
            this.tab_List.Controls.Add(this.rtxt_PpUpdateCode);
            this.tab_List.Controls.Add(this.label1);
            this.tab_List.Controls.Add(this.rtxt_PpErrorCode);
            this.tab_List.Controls.Add(this.dataGridView_Bug);
            this.tab_List.Controls.Add(this.label6);
            this.tab_List.Location = new System.Drawing.Point(4, 28);
            this.tab_List.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_List.Name = "tab_List";
            this.tab_List.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_List.Size = new System.Drawing.Size(1180, 677);
            this.tab_List.TabIndex = 1;
            this.tab_List.Text = "List";
            this.tab_List.UseVisualStyleBackColor = true;
            // 
            // lbl_PpUsertypeshow
            // 
            this.lbl_PpUsertypeshow.AutoSize = true;
            this.lbl_PpUsertypeshow.Location = new System.Drawing.Point(116, 67);
            this.lbl_PpUsertypeshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PpUsertypeshow.Name = "lbl_PpUsertypeshow";
            this.lbl_PpUsertypeshow.Size = new System.Drawing.Size(139, 19);
            this.lbl_PpUsertypeshow.TabIndex = 27;
            this.lbl_PpUsertypeshow.Text = "<User Type Show>";
            // 
            // lbl_PpUseernameshow
            // 
            this.lbl_PpUseernameshow.AutoSize = true;
            this.lbl_PpUseernameshow.Location = new System.Drawing.Point(116, 48);
            this.lbl_PpUseernameshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PpUseernameshow.Name = "lbl_PpUseernameshow";
            this.lbl_PpUseernameshow.Size = new System.Drawing.Size(145, 19);
            this.lbl_PpUseernameshow.TabIndex = 26;
            this.lbl_PpUseernameshow.Text = "<User Name Show>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "User Name :";
            // 
            // lbl_PpUserIdshow
            // 
            this.lbl_PpUserIdshow.AutoSize = true;
            this.lbl_PpUserIdshow.Location = new System.Drawing.Point(116, 21);
            this.lbl_PpUserIdshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PpUserIdshow.Name = "lbl_PpUserIdshow";
            this.lbl_PpUserIdshow.Size = new System.Drawing.Size(77, 19);
            this.lbl_PpUserIdshow.TabIndex = 24;
            this.lbl_PpUserIdshow.Text = "<User Id>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "User Id :";
            // 
            // lbl_PpBugId
            // 
            this.lbl_PpBugId.AutoSize = true;
            this.lbl_PpBugId.Location = new System.Drawing.Point(770, 21);
            this.lbl_PpBugId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PpBugId.Name = "lbl_PpBugId";
            this.lbl_PpBugId.Size = new System.Drawing.Size(72, 19);
            this.lbl_PpBugId.TabIndex = 22;
            this.lbl_PpBugId.Text = "<Bug Id>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bug Id :";
            // 
            // lbl_PpSubjectshow
            // 
            this.lbl_PpSubjectshow.AutoSize = true;
            this.lbl_PpSubjectshow.Location = new System.Drawing.Point(1044, 20);
            this.lbl_PpSubjectshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PpSubjectshow.Name = "lbl_PpSubjectshow";
            this.lbl_PpSubjectshow.Size = new System.Drawing.Size(77, 19);
            this.lbl_PpSubjectshow.TabIndex = 20;
            this.lbl_PpSubjectshow.Text = "<Subject>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Subject :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Updated Code";
            // 
            // rtxt_PpUpdateCode
            // 
            this.rtxt_PpUpdateCode.Location = new System.Drawing.Point(370, 333);
            this.rtxt_PpUpdateCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxt_PpUpdateCode.Name = "rtxt_PpUpdateCode";
            this.rtxt_PpUpdateCode.Size = new System.Drawing.Size(788, 290);
            this.rtxt_PpUpdateCode.TabIndex = 15;
            this.rtxt_PpUpdateCode.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Error Code";
            // 
            // rtxt_PpErrorCode
            // 
            this.rtxt_PpErrorCode.Location = new System.Drawing.Point(370, 44);
            this.rtxt_PpErrorCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxt_PpErrorCode.Name = "rtxt_PpErrorCode";
            this.rtxt_PpErrorCode.ReadOnly = true;
            this.rtxt_PpErrorCode.Size = new System.Drawing.Size(788, 242);
            this.rtxt_PpErrorCode.TabIndex = 13;
            this.rtxt_PpErrorCode.Text = "";
            // 
            // dataGridView_Bug
            // 
            this.dataGridView_Bug.AllowUserToAddRows = false;
            this.dataGridView_Bug.AllowUserToDeleteRows = false;
            this.dataGridView_Bug.AllowUserToOrderColumns = true;
            this.dataGridView_Bug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bug.Location = new System.Drawing.Point(10, 130);
            this.dataGridView_Bug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Bug.Name = "dataGridView_Bug";
            this.dataGridView_Bug.ReadOnly = true;
            this.dataGridView_Bug.Size = new System.Drawing.Size(351, 493);
            this.dataGridView_Bug.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bug Reports";
            // 
            // btn_ViewImage
            // 
            this.btn_ViewImage.Location = new System.Drawing.Point(374, 633);
            this.btn_ViewImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ViewImage.Name = "btn_ViewImage";
            this.btn_ViewImage.Size = new System.Drawing.Size(112, 33);
            this.btn_ViewImage.TabIndex = 28;
            this.btn_ViewImage.Text = "View Image";
            this.btn_ViewImage.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(1046, 633);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(112, 33);
            this.btn_Submit.TabIndex = 29;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // BugSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1211, 738);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BugSolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Solution Form";
            this.tabControl1.ResumeLayout(false);
            this.tab_List.ResumeLayout(false);
            this.tab_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_List;
        private System.Windows.Forms.Label lbl_PpUsertypeshow;
        private System.Windows.Forms.Label lbl_PpUseernameshow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_PpUserIdshow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_PpBugId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_PpSubjectshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt_PpUpdateCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxt_PpErrorCode;
        private System.Windows.Forms.DataGridView dataGridView_Bug;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_ViewImage;
    }
}