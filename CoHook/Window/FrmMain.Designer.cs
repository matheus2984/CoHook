using System.ComponentModel;
using System.Windows.Forms;

namespace CoHook.Window
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnAutoPot = new System.Windows.Forms.Button();
            this.btnAutoClick = new System.Windows.Forms.Button();
            this.btnStartClient = new System.Windows.Forms.Button();
            this.btnBypassClient = new System.Windows.Forms.Button();
            this.btnRemoveEffects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutoPot
            // 
            this.btnAutoPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPot.ForeColor = System.Drawing.Color.Green;
            this.btnAutoPot.Location = new System.Drawing.Point(12, 12);
            this.btnAutoPot.Name = "btnAutoPot";
            this.btnAutoPot.Size = new System.Drawing.Size(120, 29);
            this.btnAutoPot.TabIndex = 0;
            this.btnAutoPot.Text = "Auto Pot";
            this.btnAutoPot.UseVisualStyleBackColor = true;
            this.btnAutoPot.Click += new System.EventHandler(this.btnAutoPot_Click);
            // 
            // btnAutoClick
            // 
            this.btnAutoClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoClick.ForeColor = System.Drawing.Color.Green;
            this.btnAutoClick.Location = new System.Drawing.Point(144, 12);
            this.btnAutoClick.Name = "btnAutoClick";
            this.btnAutoClick.Size = new System.Drawing.Size(120, 29);
            this.btnAutoClick.TabIndex = 1;
            this.btnAutoClick.Text = "Auto Click";
            this.btnAutoClick.UseVisualStyleBackColor = true;
            this.btnAutoClick.Click += new System.EventHandler(this.btnAutoClick_Click);
            // 
            // btnStartClient
            // 
            this.btnStartClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartClient.ForeColor = System.Drawing.Color.Black;
            this.btnStartClient.Location = new System.Drawing.Point(12, 59);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(120, 29);
            this.btnStartClient.TabIndex = 2;
            this.btnStartClient.Text = "Start Client";
            this.btnStartClient.UseVisualStyleBackColor = true;
            this.btnStartClient.Click += new System.EventHandler(this.btnStartClient_Click);
            // 
            // btnBypassClient
            // 
            this.btnBypassClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBypassClient.ForeColor = System.Drawing.Color.Black;
            this.btnBypassClient.Location = new System.Drawing.Point(144, 59);
            this.btnBypassClient.Name = "btnBypassClient";
            this.btnBypassClient.Size = new System.Drawing.Size(120, 29);
            this.btnBypassClient.TabIndex = 3;
            this.btnBypassClient.Text = "Bypass Client";
            this.btnBypassClient.UseVisualStyleBackColor = true;
            this.btnBypassClient.Click += new System.EventHandler(this.btnBypassClient_Click);
            // 
            // btnRemoveEffects
            // 
            this.btnRemoveEffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEffects.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveEffects.Location = new System.Drawing.Point(70, 103);
            this.btnRemoveEffects.Name = "btnRemoveEffects";
            this.btnRemoveEffects.Size = new System.Drawing.Size(139, 29);
            this.btnRemoveEffects.TabIndex = 4;
            this.btnRemoveEffects.Text = "Remove Effects";
            this.btnRemoveEffects.UseVisualStyleBackColor = true;
            this.btnRemoveEffects.Click += new System.EventHandler(this.btnRemoveEffects_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 144);
            this.Controls.Add(this.btnRemoveEffects);
            this.Controls.Add(this.btnBypassClient);
            this.Controls.Add(this.btnStartClient);
            this.Controls.Add(this.btnAutoClick);
            this.Controls.Add(this.btnAutoPot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAutoPot;
        private Button btnAutoClick;
        private Button btnStartClient;
        private Button btnBypassClient;
        private Button btnRemoveEffects;
    }
}