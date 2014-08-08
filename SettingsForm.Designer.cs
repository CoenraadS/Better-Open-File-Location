namespace ClickOnce_Open_File_Location
{
    partial class SettingsForm
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
            this.checkBoxShortcut = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxClickOnce = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxShiftShortcut = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftClickOnce = new System.Windows.Forms.CheckBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxShortcut
            // 
            this.checkBoxShortcut.AutoSize = true;
            this.checkBoxShortcut.Location = new System.Drawing.Point(12, 25);
            this.checkBoxShortcut.Name = "checkBoxShortcut";
            this.checkBoxShortcut.Size = new System.Drawing.Size(43, 17);
            this.checkBoxShortcut.TabIndex = 0;
            this.checkBoxShortcut.Text = ".lnk";
            this.checkBoxShortcut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Associate File Extensions";
            // 
            // checkBoxClickOnce
            // 
            this.checkBoxClickOnce.AutoSize = true;
            this.checkBoxClickOnce.Location = new System.Drawing.Point(12, 48);
            this.checkBoxClickOnce.Name = "checkBoxClickOnce";
            this.checkBoxClickOnce.Size = new System.Drawing.Size(75, 17);
            this.checkBoxClickOnce.TabIndex = 2;
            this.checkBoxClickOnce.Text = ".appref-ms";
            this.checkBoxClickOnce.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shift Key Modifier";
            // 
            // checkBoxShiftShortcut
            // 
            this.checkBoxShiftShortcut.AutoSize = true;
            this.checkBoxShiftShortcut.Location = new System.Drawing.Point(180, 25);
            this.checkBoxShiftShortcut.Name = "checkBoxShiftShortcut";
            this.checkBoxShiftShortcut.Size = new System.Drawing.Size(15, 14);
            this.checkBoxShiftShortcut.TabIndex = 4;
            this.checkBoxShiftShortcut.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftClickOnce
            // 
            this.checkBoxShiftClickOnce.AutoSize = true;
            this.checkBoxShiftClickOnce.Location = new System.Drawing.Point(180, 48);
            this.checkBoxShiftClickOnce.Name = "checkBoxShiftClickOnce";
            this.checkBoxShiftClickOnce.Size = new System.Drawing.Size(15, 14);
            this.checkBoxShiftClickOnce.TabIndex = 5;
            this.checkBoxShiftClickOnce.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(197, 91);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 6;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancel.Location = new System.Drawing.Point(116, 91);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.checkBoxShiftClickOnce);
            this.Controls.Add(this.checkBoxShiftShortcut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxClickOnce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Open File Location Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShortcut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxClickOnce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxShiftShortcut;
        private System.Windows.Forms.CheckBox checkBoxShiftClickOnce;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}