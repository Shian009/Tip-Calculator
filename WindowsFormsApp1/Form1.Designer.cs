
namespace WindowsFormsApp1
{
    partial class TipCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipCalculator));
            this.generateBill = new System.Windows.Forms.Button();
            this.labelBill = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelNoOfPeople = new System.Windows.Forms.Label();
            this.labelTipResult = new System.Windows.Forms.Label();
            this.inputBill = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPerPerson = new System.Windows.Forms.Label();
            this.labelPerPersonResult = new System.Windows.Forms.Label();
            this.plusPeopleButton = new System.Windows.Forms.Button();
            this.inputPerson = new System.Windows.Forms.TextBox();
            this.minusPeopleButton = new System.Windows.Forms.Button();
            this.minusTipButton = new System.Windows.Forms.Button();
            this.plusTipButton = new System.Windows.Forms.Button();
            this.inputTip = new System.Windows.Forms.TextBox();
            this.outputTip = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.ClearEnteriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateBill
            // 
            this.generateBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateBill.BackColor = System.Drawing.Color.LightCoral;
            this.generateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBill.Location = new System.Drawing.Point(307, 254);
            this.generateBill.Margin = new System.Windows.Forms.Padding(2, 2, 3, 2);
            this.generateBill.Name = "generateBill";
            this.generateBill.Size = new System.Drawing.Size(178, 43);
            this.generateBill.TabIndex = 0;
            this.generateBill.Text = "Generate Bill";
            this.generateBill.UseVisualStyleBackColor = false;
            this.generateBill.Click += new System.EventHandler(this.GenerateBill);
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.BackColor = System.Drawing.Color.Transparent;
            this.labelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBill.Location = new System.Drawing.Point(29, 40);
            this.labelBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(33, 20);
            this.labelBill.TabIndex = 1;
            this.labelBill.Text = "Bill";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.BackColor = System.Drawing.Color.Transparent;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(26, 150);
            this.labelTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(48, 20);
            this.labelTip.TabIndex = 2;
            this.labelTip.Text = "Tip%";
            // 
            // labelNoOfPeople
            // 
            this.labelNoOfPeople.AutoSize = true;
            this.labelNoOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfPeople.Location = new System.Drawing.Point(28, 266);
            this.labelNoOfPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoOfPeople.Name = "labelNoOfPeople";
            this.labelNoOfPeople.Size = new System.Drawing.Size(152, 20);
            this.labelNoOfPeople.TabIndex = 3;
            this.labelNoOfPeople.Text = "Number of People";
            // 
            // labelTipResult
            // 
            this.labelTipResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTipResult.AutoSize = true;
            this.labelTipResult.BackColor = System.Drawing.Color.Transparent;
            this.labelTipResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipResult.Location = new System.Drawing.Point(278, 50);
            this.labelTipResult.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.labelTipResult.Name = "labelTipResult";
            this.labelTipResult.Size = new System.Drawing.Size(33, 20);
            this.labelTipResult.TabIndex = 4;
            this.labelTipResult.Text = "Tip";
            // 
            // inputBill
            // 
            this.inputBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBill.Location = new System.Drawing.Point(33, 63);
            this.inputBill.Margin = new System.Windows.Forms.Padding(2);
            this.inputBill.Name = "inputBill";
            this.inputBill.Size = new System.Drawing.Size(110, 28);
            this.inputBill.TabIndex = 5;
            this.inputBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(278, 151);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 20);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            // 
            // labelPerPerson
            // 
            this.labelPerPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPerPerson.AutoSize = true;
            this.labelPerPerson.BackColor = System.Drawing.Color.Transparent;
            this.labelPerPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerPerson.Location = new System.Drawing.Point(278, 71);
            this.labelPerPerson.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.labelPerPerson.Name = "labelPerPerson";
            this.labelPerPerson.Size = new System.Drawing.Size(79, 17);
            this.labelPerPerson.TabIndex = 11;
            this.labelPerPerson.Text = "Per Person";
            // 
            // labelPerPersonResult
            // 
            this.labelPerPersonResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPerPersonResult.AutoSize = true;
            this.labelPerPersonResult.BackColor = System.Drawing.Color.Transparent;
            this.labelPerPersonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerPersonResult.Location = new System.Drawing.Point(276, 174);
            this.labelPerPersonResult.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.labelPerPersonResult.Name = "labelPerPersonResult";
            this.labelPerPersonResult.Size = new System.Drawing.Size(79, 17);
            this.labelPerPersonResult.TabIndex = 12;
            this.labelPerPersonResult.Text = "Per Person";
            // 
            // plusPeopleButton
            // 
            this.plusPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusPeopleButton.Location = new System.Drawing.Point(171, 288);
            this.plusPeopleButton.Margin = new System.Windows.Forms.Padding(2);
            this.plusPeopleButton.Name = "plusPeopleButton";
            this.plusPeopleButton.Size = new System.Drawing.Size(25, 26);
            this.plusPeopleButton.TabIndex = 16;
            this.plusPeopleButton.Text = "+";
            this.plusPeopleButton.UseVisualStyleBackColor = true;
            this.plusPeopleButton.Click += new System.EventHandler(this.PlusPeopleButtonClick);
            // 
            // inputPerson
            // 
            this.inputPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPerson.Location = new System.Drawing.Point(58, 288);
            this.inputPerson.Margin = new System.Windows.Forms.Padding(2);
            this.inputPerson.Name = "inputPerson";
            this.inputPerson.Size = new System.Drawing.Size(110, 26);
            this.inputPerson.TabIndex = 17;
            this.inputPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minusPeopleButton
            // 
            this.minusPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusPeopleButton.Location = new System.Drawing.Point(29, 288);
            this.minusPeopleButton.Margin = new System.Windows.Forms.Padding(2);
            this.minusPeopleButton.Name = "minusPeopleButton";
            this.minusPeopleButton.Size = new System.Drawing.Size(25, 26);
            this.minusPeopleButton.TabIndex = 18;
            this.minusPeopleButton.Text = "-";
            this.minusPeopleButton.UseVisualStyleBackColor = true;
            this.minusPeopleButton.Click += new System.EventHandler(this.MinusPeopleButtonClick);
            // 
            // minusTipButton
            // 
            this.minusTipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusTipButton.Location = new System.Drawing.Point(29, 174);
            this.minusTipButton.Margin = new System.Windows.Forms.Padding(2);
            this.minusTipButton.Name = "minusTipButton";
            this.minusTipButton.Size = new System.Drawing.Size(25, 26);
            this.minusTipButton.TabIndex = 19;
            this.minusTipButton.Text = "-";
            this.minusTipButton.UseVisualStyleBackColor = true;
            this.minusTipButton.Click += new System.EventHandler(this.MinusTipButtonClick);
            // 
            // plusTipButton
            // 
            this.plusTipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusTipButton.Location = new System.Drawing.Point(171, 175);
            this.plusTipButton.Margin = new System.Windows.Forms.Padding(2);
            this.plusTipButton.Name = "plusTipButton";
            this.plusTipButton.Size = new System.Drawing.Size(25, 26);
            this.plusTipButton.TabIndex = 20;
            this.plusTipButton.Text = "+";
            this.plusTipButton.UseVisualStyleBackColor = true;
            this.plusTipButton.Click += new System.EventHandler(this.PlusTipButtonClick);
            // 
            // inputTip
            // 
            this.inputTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTip.Location = new System.Drawing.Point(58, 174);
            this.inputTip.Margin = new System.Windows.Forms.Padding(2);
            this.inputTip.Name = "inputTip";
            this.inputTip.Size = new System.Drawing.Size(110, 26);
            this.inputTip.TabIndex = 21;
            this.inputTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputTip
            // 
            this.outputTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTip.AutoSize = true;
            this.outputTip.BackColor = System.Drawing.Color.Transparent;
            this.outputTip.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.outputTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTip.Location = new System.Drawing.Point(396, 50);
            this.outputTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputTip.Name = "outputTip";
            this.outputTip.Size = new System.Drawing.Size(0, 20);
            this.outputTip.TabIndex = 22;
            // 
            // outputTotal
            // 
            this.outputTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTotal.AutoSize = true;
            this.outputTotal.BackColor = System.Drawing.Color.Transparent;
            this.outputTotal.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.outputTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTotal.Location = new System.Drawing.Point(407, 151);
            this.outputTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(0, 20);
            this.outputTotal.TabIndex = 23;
            // 
            // ClearEnteriesButton
            // 
            this.ClearEnteriesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearEnteriesButton.BackColor = System.Drawing.Color.LightCoral;
            this.ClearEnteriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEnteriesButton.Location = new System.Drawing.Point(307, 308);
            this.ClearEnteriesButton.Margin = new System.Windows.Forms.Padding(2, 2, 3, 2);
            this.ClearEnteriesButton.Name = "ClearEnteriesButton";
            this.ClearEnteriesButton.Size = new System.Drawing.Size(178, 43);
            this.ClearEnteriesButton.TabIndex = 24;
            this.ClearEnteriesButton.Text = "Clear Enteries";
            this.ClearEnteriesButton.UseVisualStyleBackColor = false;
            this.ClearEnteriesButton.Click += new System.EventHandler(this.ClearEnteries);
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 362);
            this.Controls.Add(this.ClearEnteriesButton);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.outputTip);
            this.Controls.Add(this.inputTip);
            this.Controls.Add(this.plusTipButton);
            this.Controls.Add(this.minusTipButton);
            this.Controls.Add(this.minusPeopleButton);
            this.Controls.Add(this.inputPerson);
            this.Controls.Add(this.plusPeopleButton);
            this.Controls.Add(this.labelPerPersonResult);
            this.Controls.Add(this.labelPerPerson);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.inputBill);
            this.Controls.Add(this.labelTipResult);
            this.Controls.Add(this.labelNoOfPeople);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelBill);
            this.Controls.Add(this.generateBill);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipCalculator";
            this.Text = "Tip Calculator by Shivank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBill;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelNoOfPeople;
        private System.Windows.Forms.Label labelTipResult;
        private System.Windows.Forms.TextBox inputBill;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPerPerson;
        private System.Windows.Forms.Label labelPerPersonResult;
        private System.Windows.Forms.Button plusPeopleButton;
        private System.Windows.Forms.TextBox inputPerson;
        private System.Windows.Forms.Button minusPeopleButton;
        private System.Windows.Forms.Button minusTipButton;
        private System.Windows.Forms.Button plusTipButton;
        private System.Windows.Forms.TextBox inputTip;
        private System.Windows.Forms.Label outputTip;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.Button ClearEnteriesButton;
    }
}

