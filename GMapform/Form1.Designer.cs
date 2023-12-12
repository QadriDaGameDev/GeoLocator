namespace GMapform
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Geolbl = new System.Windows.Forms.Label();
            this.locationbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.contactbtn = new System.Windows.Forms.Button();
            this.namebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.locationbtn);
            this.panel1.Controls.Add(this.viewbtn);
            this.panel1.Controls.Add(this.contactbtn);
            this.panel1.Controls.Add(this.namebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 551);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.Geolbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 100);
            this.panel4.TabIndex = 4;
            // 
            // Geolbl
            // 
            this.Geolbl.AutoSize = true;
            this.Geolbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geolbl.ForeColor = System.Drawing.Color.White;
            this.Geolbl.Location = new System.Drawing.Point(61, 44);
            this.Geolbl.Name = "Geolbl";
            this.Geolbl.Size = new System.Drawing.Size(99, 19);
            this.Geolbl.TabIndex = 0;
            this.Geolbl.Text = "Geo Locater";
            this.Geolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationbtn
            // 
            this.locationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationbtn.ForeColor = System.Drawing.Color.White;
            this.locationbtn.Image = global::GMapform.Properties.Resources.location_png;
            this.locationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationbtn.Location = new System.Drawing.Point(-3, 314);
            this.locationbtn.Margin = new System.Windows.Forms.Padding(2);
            this.locationbtn.Name = "locationbtn";
            this.locationbtn.Size = new System.Drawing.Size(232, 71);
            this.locationbtn.TabIndex = 3;
            this.locationbtn.Text = "Search By Location";
            this.locationbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.locationbtn.UseVisualStyleBackColor = false;
            this.locationbtn.MouseLeave += new System.EventHandler(this.locationbtn_MouseLeave);
            this.locationbtn.MouseHover += new System.EventHandler(this.locationbtn_MouseHover);
            // 
            // viewbtn
            // 
            this.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.ForeColor = System.Drawing.Color.White;
            this.viewbtn.Image = global::GMapform.Properties.Resources.rsz_1rsz_1rsz_1rsz_11view_map_location_icon_modified;
            this.viewbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewbtn.Location = new System.Drawing.Point(-3, 408);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Padding = new System.Windows.Forms.Padding(10);
            this.viewbtn.Size = new System.Drawing.Size(232, 71);
            this.viewbtn.TabIndex = 2;
            this.viewbtn.Text = "    Change View";
            this.viewbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.MouseLeave += new System.EventHandler(this.viewbtn_MouseLeave);
            this.viewbtn.MouseHover += new System.EventHandler(this.viewbtn_MouseHover);
            // 
            // contactbtn
            // 
            this.contactbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactbtn.ForeColor = System.Drawing.Color.White;
            this.contactbtn.Image = global::GMapform.Properties.Resources.contact1;
            this.contactbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactbtn.Location = new System.Drawing.Point(-3, 216);
            this.contactbtn.Name = "contactbtn";
            this.contactbtn.Size = new System.Drawing.Size(232, 71);
            this.contactbtn.TabIndex = 1;
            this.contactbtn.Text = "   Search By Contact";
            this.contactbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contactbtn.UseVisualStyleBackColor = false;
            this.contactbtn.MouseLeave += new System.EventHandler(this.contactbtn_MouseLeave);
            this.contactbtn.MouseHover += new System.EventHandler(this.contactbtn_MouseHover);
            // 
            // namebtn
            // 
            this.namebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namebtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebtn.ForeColor = System.Drawing.Color.White;
            this.namebtn.Image = global::GMapform.Properties.Resources.search_png;
            this.namebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.namebtn.Location = new System.Drawing.Point(-3, 120);
            this.namebtn.Name = "namebtn";
            this.namebtn.Size = new System.Drawing.Size(232, 71);
            this.namebtn.TabIndex = 0;
            this.namebtn.Text = "    Search By Name";
            this.namebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.namebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.namebtn.UseVisualStyleBackColor = false;
            this.namebtn.MouseLeave += new System.EventHandler(this.namebtn_MouseLeave_1);
            this.namebtn.MouseHover += new System.EventHandler(this.namebtn_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 61);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(226, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 66);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEOLOCATER";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button namebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button contactbtn;
        private System.Windows.Forms.Button locationbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Geolbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

