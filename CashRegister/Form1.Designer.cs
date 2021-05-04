
namespace CashRegister
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.recieptButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.milkshakeLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.milkshakeInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.suboutputLabel = new System.Windows.Forms.Label();
            this.taxoutputLabel = new System.Windows.Forms.Label();
            this.totaloutputLabel = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeoutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(342, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(273, 448);
            this.outputLabel.TabIndex = 0;
            // 
            // neworderButton
            // 
            this.neworderButton.BackColor = System.Drawing.Color.White;
            this.neworderButton.Enabled = false;
            this.neworderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.neworderButton.FlatAppearance.BorderSize = 3;
            this.neworderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neworderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderButton.Location = new System.Drawing.Point(405, 478);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(135, 36);
            this.neworderButton.TabIndex = 1;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // recieptButton
            // 
            this.recieptButton.BackColor = System.Drawing.Color.White;
            this.recieptButton.Enabled = false;
            this.recieptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.recieptButton.FlatAppearance.BorderSize = 3;
            this.recieptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptButton.Location = new System.Drawing.Point(74, 478);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(135, 36);
            this.recieptButton.TabIndex = 2;
            this.recieptButton.Text = "Print Reciept";
            this.recieptButton.UseVisualStyleBackColor = false;
            this.recieptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(326, 41);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Stratford Burger Palace";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // burgerLabel
            // 
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(76, 65);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(84, 29);
            this.burgerLabel.TabIndex = 4;
            this.burgerLabel.Text = "Burgers:";
            // 
            // friesLabel
            // 
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(101, 104);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(59, 29);
            this.friesLabel.TabIndex = 5;
            this.friesLabel.Text = "Fries:";
            // 
            // milkshakeLabel
            // 
            this.milkshakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkshakeLabel.Location = new System.Drawing.Point(51, 142);
            this.milkshakeLabel.Name = "milkshakeLabel";
            this.milkshakeLabel.Size = new System.Drawing.Size(109, 29);
            this.milkshakeLabel.TabIndex = 6;
            this.milkshakeLabel.Text = "Milkshakes:";
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(166, 65);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(100, 20);
            this.burgerInput.TabIndex = 7;
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(166, 104);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(100, 20);
            this.friesInput.TabIndex = 8;
            // 
            // milkshakeInput
            // 
            this.milkshakeInput.Location = new System.Drawing.Point(166, 142);
            this.milkshakeInput.Name = "milkshakeInput";
            this.milkshakeInput.Size = new System.Drawing.Size(100, 20);
            this.milkshakeInput.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.BorderSize = 3;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(74, 184);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(135, 36);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(51, 234);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(76, 23);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(87, 267);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(38, 23);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(76, 299);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(49, 23);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total:";
            // 
            // suboutputLabel
            // 
            this.suboutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suboutputLabel.ForeColor = System.Drawing.Color.Black;
            this.suboutputLabel.Location = new System.Drawing.Point(133, 234);
            this.suboutputLabel.Name = "suboutputLabel";
            this.suboutputLabel.Size = new System.Drawing.Size(100, 23);
            this.suboutputLabel.TabIndex = 14;
            // 
            // taxoutputLabel
            // 
            this.taxoutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxoutputLabel.ForeColor = System.Drawing.Color.Black;
            this.taxoutputLabel.Location = new System.Drawing.Point(133, 267);
            this.taxoutputLabel.Name = "taxoutputLabel";
            this.taxoutputLabel.Size = new System.Drawing.Size(100, 23);
            this.taxoutputLabel.TabIndex = 15;
            // 
            // totaloutputLabel
            // 
            this.totaloutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaloutputLabel.ForeColor = System.Drawing.Color.Black;
            this.totaloutputLabel.Location = new System.Drawing.Point(133, 299);
            this.totaloutputLabel.Name = "totaloutputLabel";
            this.totaloutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totaloutputLabel.TabIndex = 16;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.Black;
            this.lineLabel.Location = new System.Drawing.Point(52, 322);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(249, 10);
            this.lineLabel.TabIndex = 17;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(42, 343);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(83, 23);
            this.tenderedLabel.TabIndex = 18;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Enabled = false;
            this.tenderedInput.Location = new System.Drawing.Point(166, 346);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 19;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeButton.FlatAppearance.BorderSize = 3;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(74, 372);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(135, 36);
            this.changeButton.TabIndex = 20;
            this.changeButton.Text = "Calcluate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(51, 421);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(71, 23);
            this.changeLabel.TabIndex = 21;
            this.changeLabel.Text = "Change:";
            // 
            // changeoutputLabel
            // 
            this.changeoutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeoutputLabel.Location = new System.Drawing.Point(133, 421);
            this.changeoutputLabel.Name = "changeoutputLabel";
            this.changeoutputLabel.Size = new System.Drawing.Size(100, 23);
            this.changeoutputLabel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(627, 536);
            this.Controls.Add(this.changeoutputLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.totaloutputLabel);
            this.Controls.Add(this.taxoutputLabel);
            this.Controls.Add(this.suboutputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.milkshakeInput);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.milkshakeLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label milkshakeLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.TextBox milkshakeInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label suboutputLabel;
        private System.Windows.Forms.Label taxoutputLabel;
        private System.Windows.Forms.Label totaloutputLabel;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeoutputLabel;
    }
}

