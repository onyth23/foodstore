namespace FoodStore
{
    partial class ValmyndLagerStarfsmadur
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
            this.TextBoxLagerIDvoru = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonLagerTypeIDRefresh = new System.Windows.Forms.Button();
            this.TextBoxLagerTypeIDName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxLagerTypeIDLagerTypeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewLagertypeIDDisplay = new System.Windows.Forms.DataGridView();
            this.LagertypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nafn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteType = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TextBoxLagerLagerTypeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxLagerQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxLagerProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLagerProductName = new System.Windows.Forms.TextBox();
            this.dataGridViewLagerDisplay = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lagertype_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonUppfaeraVoruLager = new System.Windows.Forms.Button();
            this.ButtonSetjaNyjaVoruLager = new System.Windows.Forms.Button();
            this.ButtonBuaTilVoruFlokk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLagertypeIDDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLagerDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLagerIDvoru
            // 
            this.TextBoxLagerIDvoru.Location = new System.Drawing.Point(682, 91);
            this.TextBoxLagerIDvoru.Name = "TextBoxLagerIDvoru";
            this.TextBoxLagerIDvoru.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLagerIDvoru.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "ID vöru :";
            // 
            // ButtonLagerTypeIDRefresh
            // 
            this.ButtonLagerTypeIDRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonLagerTypeIDRefresh.Location = new System.Drawing.Point(682, 539);
            this.ButtonLagerTypeIDRefresh.Name = "ButtonLagerTypeIDRefresh";
            this.ButtonLagerTypeIDRefresh.Size = new System.Drawing.Size(196, 81);
            this.ButtonLagerTypeIDRefresh.TabIndex = 37;
            this.ButtonLagerTypeIDRefresh.Text = "Refresh glugga";
            this.ButtonLagerTypeIDRefresh.UseVisualStyleBackColor = true;
            this.ButtonLagerTypeIDRefresh.Click += new System.EventHandler(this.ButtonLagerTypeIDRefresh_Click);
            // 
            // TextBoxLagerTypeIDName
            // 
            this.TextBoxLagerTypeIDName.Location = new System.Drawing.Point(682, 512);
            this.TextBoxLagerTypeIDName.Name = "TextBoxLagerTypeIDName";
            this.TextBoxLagerTypeIDName.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLagerTypeIDName.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Name";
            // 
            // TextBoxLagerTypeIDLagerTypeID
            // 
            this.TextBoxLagerTypeIDLagerTypeID.Location = new System.Drawing.Point(682, 468);
            this.TextBoxLagerTypeIDLagerTypeID.Name = "TextBoxLagerTypeIDLagerTypeID";
            this.TextBoxLagerTypeIDLagerTypeID.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLagerTypeIDLagerTypeID.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Lagertype ID";
            // 
            // dataGridViewLagertypeIDDisplay
            // 
            this.dataGridViewLagertypeIDDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLagertypeIDDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LagertypeID,
            this.Nafn,
            this.DeleteType});
            this.dataGridViewLagertypeIDDisplay.Location = new System.Drawing.Point(885, 12);
            this.dataGridViewLagertypeIDDisplay.Name = "dataGridViewLagertypeIDDisplay";
            this.dataGridViewLagertypeIDDisplay.Size = new System.Drawing.Size(359, 608);
            this.dataGridViewLagertypeIDDisplay.TabIndex = 32;
            this.dataGridViewLagertypeIDDisplay.SelectionChanged += new System.EventHandler(this.dataGridViewLagerIdDisplay_SelectionChange);
            // 
            // LagertypeID
            // 
            this.LagertypeID.HeaderText = "LagertypeID";
            this.LagertypeID.Name = "LagertypeID";
            // 
            // Nafn
            // 
            this.Nafn.HeaderText = "Nafn";
            this.Nafn.Name = "Nafn";
            // 
            // DeleteType
            // 
            this.DeleteType.HeaderText = "DeleteType";
            this.DeleteType.Name = "DeleteType";
            // 
            // TextBoxLagerLagerTypeID
            // 
            this.TextBoxLagerLagerTypeID.Location = new System.Drawing.Point(682, 267);
            this.TextBoxLagerLagerTypeID.Name = "TextBoxLagerLagerTypeID";
            this.TextBoxLagerLagerTypeID.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLagerLagerTypeID.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "LagertypeID";
            // 
            // TextBoxLagerQuantity
            // 
            this.TextBoxLagerQuantity.Location = new System.Drawing.Point(682, 223);
            this.TextBoxLagerQuantity.Name = "TextBoxLagerQuantity";
            this.TextBoxLagerQuantity.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLagerQuantity.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantity";
            // 
            // TextBoxLagerProductPrice
            // 
            this.TextBoxLagerProductPrice.Location = new System.Drawing.Point(682, 179);
            this.TextBoxLagerProductPrice.Name = "TextBoxLagerProductPrice";
            this.TextBoxLagerProductPrice.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLagerProductPrice.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "ProductPrice :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ProductName :";
            // 
            // TextBoxLagerProductName
            // 
            this.TextBoxLagerProductName.Location = new System.Drawing.Point(682, 135);
            this.TextBoxLagerProductName.Name = "TextBoxLagerProductName";
            this.TextBoxLagerProductName.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLagerProductName.TabIndex = 24;
            // 
            // dataGridViewLagerDisplay
            // 
            this.dataGridViewLagerDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLagerDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName,
            this.ProductPrice,
            this.quantity,
            this.Lagertype_ID,
            this.Delete});
            this.dataGridViewLagerDisplay.Location = new System.Drawing.Point(13, 11);
            this.dataGridViewLagerDisplay.Name = "dataGridViewLagerDisplay";
            this.dataGridViewLagerDisplay.Size = new System.Drawing.Size(663, 609);
            this.dataGridViewLagerDisplay.TabIndex = 23;
            this.dataGridViewLagerDisplay.SelectionChanged += new System.EventHandler(this.dataGridViewLagerDisplay_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // Lagertype_ID
            // 
            this.Lagertype_ID.HeaderText = "Lagertype_ID";
            this.Lagertype_ID.Name = "Lagertype_ID";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // ButtonUppfaeraVoruLager
            // 
            this.ButtonUppfaeraVoruLager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonUppfaeraVoruLager.Location = new System.Drawing.Point(682, 293);
            this.ButtonUppfaeraVoruLager.Name = "ButtonUppfaeraVoruLager";
            this.ButtonUppfaeraVoruLager.Size = new System.Drawing.Size(196, 46);
            this.ButtonUppfaeraVoruLager.TabIndex = 22;
            this.ButtonUppfaeraVoruLager.Text = "Uppfæra vöru (lager)";
            this.ButtonUppfaeraVoruLager.UseVisualStyleBackColor = true;
            this.ButtonUppfaeraVoruLager.Click += new System.EventHandler(this.ButtonUppfaeraVoruLager_Click);
            // 
            // ButtonSetjaNyjaVoruLager
            // 
            this.ButtonSetjaNyjaVoruLager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonSetjaNyjaVoruLager.Location = new System.Drawing.Point(682, 12);
            this.ButtonSetjaNyjaVoruLager.Name = "ButtonSetjaNyjaVoruLager";
            this.ButtonSetjaNyjaVoruLager.Size = new System.Drawing.Size(196, 55);
            this.ButtonSetjaNyjaVoruLager.TabIndex = 21;
            this.ButtonSetjaNyjaVoruLager.Text = "Setja nýja vöru í lager (lager)";
            this.ButtonSetjaNyjaVoruLager.UseVisualStyleBackColor = true;
            this.ButtonSetjaNyjaVoruLager.Click += new System.EventHandler(this.ButtonSetjaNyjaVoruLager_Click);
            // 
            // ButtonBuaTilVoruFlokk
            // 
            this.ButtonBuaTilVoruFlokk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonBuaTilVoruFlokk.Location = new System.Drawing.Point(682, 403);
            this.ButtonBuaTilVoruFlokk.Name = "ButtonBuaTilVoruFlokk";
            this.ButtonBuaTilVoruFlokk.Size = new System.Drawing.Size(196, 45);
            this.ButtonBuaTilVoruFlokk.TabIndex = 20;
            this.ButtonBuaTilVoruFlokk.Text = "Búa til vöruflokk (lagertype)";
            this.ButtonBuaTilVoruFlokk.UseVisualStyleBackColor = true;
            this.ButtonBuaTilVoruFlokk.Click += new System.EventHandler(this.ButtonBuaTilVoruFlokk_Click);
            // 
            // ValmyndLagerStarfsmadur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 630);
            this.Controls.Add(this.TextBoxLagerIDvoru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonLagerTypeIDRefresh);
            this.Controls.Add(this.TextBoxLagerTypeIDName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxLagerTypeIDLagerTypeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewLagertypeIDDisplay);
            this.Controls.Add(this.TextBoxLagerLagerTypeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxLagerQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxLagerProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxLagerProductName);
            this.Controls.Add(this.dataGridViewLagerDisplay);
            this.Controls.Add(this.ButtonUppfaeraVoruLager);
            this.Controls.Add(this.ButtonSetjaNyjaVoruLager);
            this.Controls.Add(this.ButtonBuaTilVoruFlokk);
            this.Name = "ValmyndLagerStarfsmadur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValmyndLagerStarfsmadur";
            this.Load += new System.EventHandler(this.ValmyndLagerStarfsmadur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLagertypeIDDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLagerDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLagerIDvoru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonLagerTypeIDRefresh;
        private System.Windows.Forms.TextBox TextBoxLagerTypeIDName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxLagerTypeIDLagerTypeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewLagertypeIDDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LagertypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nafn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteType;
        private System.Windows.Forms.TextBox TextBoxLagerLagerTypeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxLagerQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLagerProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLagerProductName;
        private System.Windows.Forms.DataGridView dataGridViewLagerDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagertype_ID;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button ButtonUppfaeraVoruLager;
        private System.Windows.Forms.Button ButtonSetjaNyjaVoruLager;
        private System.Windows.Forms.Button ButtonBuaTilVoruFlokk;
    }
}