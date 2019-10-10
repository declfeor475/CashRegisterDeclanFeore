namespace CashRegisterDeclanFeore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hamburgerTextbox = new System.Windows.Forms.TextBox();
            this.friesTextbox = new System.Windows.Forms.TextBox();
            this.drinksTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Hamburgers:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label2.Location = new System.Drawing.Point(4, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Fries:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label3.Location = new System.Drawing.Point(3, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Drinks:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hamburgerTextbox
            // 
            this.hamburgerTextbox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.hamburgerTextbox.Location = new System.Drawing.Point(430, 94);
            this.hamburgerTextbox.Name = "hamburgerTextbox";
            this.hamburgerTextbox.Size = new System.Drawing.Size(123, 45);
            this.hamburgerTextbox.TabIndex = 3;
            // 
            // friesTextbox
            // 
            this.friesTextbox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.friesTextbox.Location = new System.Drawing.Point(430, 157);
            this.friesTextbox.Name = "friesTextbox";
            this.friesTextbox.Size = new System.Drawing.Size(123, 45);
            this.friesTextbox.TabIndex = 4;
            // 
            // drinksTextbox
            // 
            this.drinksTextbox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.drinksTextbox.Location = new System.Drawing.Point(430, 221);
            this.drinksTextbox.Name = "drinksTextbox";
            this.drinksTextbox.Size = new System.Drawing.Size(123, 45);
            this.drinksTextbox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.LightGray;
            this.CalculateButton.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(94, 285);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(459, 53);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate Totals";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label4.Location = new System.Drawing.Point(87, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 456);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Total: \r\n\r\nTax: \r\n\r\nTotal:\r\n\r\n\r\nTendered:\r\n\r\n\r\n\r\nChange:";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.displayLabel.Location = new System.Drawing.Point(461, 358);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 38);
            this.displayLabel.TabIndex = 8;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(94, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(459, 45);
            this.label5.TabIndex = 9;
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tenderedTextBox.Location = new System.Drawing.Point(430, 625);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(123, 45);
            this.tenderedTextBox.TabIndex = 10;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.changeLabel.Location = new System.Drawing.Point(461, 759);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 38);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LightGray;
            this.changeButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.changeButton.Location = new System.Drawing.Point(94, 682);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(459, 53);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SaddleBrown;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.label6.Location = new System.Drawing.Point(-3, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1177, 85);
            this.label6.TabIndex = 13;
            this.label6.Text = "The Burger Bin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.LightGray;
            this.receiptButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.receiptButton.Location = new System.Drawing.Point(94, 817);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(459, 53);
            this.receiptButton.TabIndex = 14;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.LightGray;
            this.newOrderButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.newOrderButton.Location = new System.Drawing.Point(640, 682);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(459, 53);
            this.newOrderButton.TabIndex = 15;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.White;
            this.messageLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.messageLabel.ForeColor = System.Drawing.Color.Maroon;
            this.messageLabel.Location = new System.Drawing.Point(646, 738);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(468, 172);
            this.messageLabel.TabIndex = 16;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(640, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(640, 598);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(459, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(640, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 459);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1062, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 459);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 939);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.drinksTextbox);
            this.Controls.Add(this.friesTextbox);
            this.Controls.Add(this.hamburgerTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hamburgerTextbox;
        private System.Windows.Forms.TextBox friesTextbox;
        private System.Windows.Forms.TextBox drinksTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

