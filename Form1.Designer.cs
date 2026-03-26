namespace PizzaProject1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMideum = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOrderSummry = new System.Windows.Forms.GroupBox();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThinckCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.chkTomito = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkCicken = new System.Windows.Forms.CheckBox();
            this.chkMashrom = new System.Windows.Forms.CheckBox();
            this.chkExtraChess = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeAway = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderIn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbOrderSummry.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMideum);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(12, 102);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(126, 150);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(15, 113);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(69, 22);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMideum
            // 
            this.rbMideum.AutoSize = true;
            this.rbMideum.Location = new System.Drawing.Point(15, 68);
            this.rbMideum.Name = "rbMideum";
            this.rbMideum.Size = new System.Drawing.Size(84, 22);
            this.rbMideum.TabIndex = 1;
            this.rbMideum.TabStop = true;
            this.rbMideum.Tag = "30";
            this.rbMideum.Text = "Mideum";
            this.rbMideum.UseVisualStyleBackColor = true;
            this.rbMideum.CheckedChanged += new System.EventHandler(this.rbMideum_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(15, 25);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(68, 22);
            this.rbSmall.TabIndex = 2;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbOrderSummry
            // 
            this.gbOrderSummry.Controls.Add(this.label7);
            this.gbOrderSummry.Controls.Add(this.numericUpDown1);
            this.gbOrderSummry.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummry.Controls.Add(this.label6);
            this.gbOrderSummry.Controls.Add(this.lblTopping);
            this.gbOrderSummry.Controls.Add(this.label4);
            this.gbOrderSummry.Controls.Add(this.label5);
            this.gbOrderSummry.Controls.Add(this.lblCrustType);
            this.gbOrderSummry.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummry.Controls.Add(this.label3);
            this.gbOrderSummry.Controls.Add(this.lblSize);
            this.gbOrderSummry.Controls.Add(this.label2);
            this.gbOrderSummry.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummry.Location = new System.Drawing.Point(534, 102);
            this.gbOrderSummry.Name = "gbOrderSummry";
            this.gbOrderSummry.Size = new System.Drawing.Size(262, 344);
            this.gbOrderSummry.TabIndex = 3;
            this.gbOrderSummry.TabStop = false;
            this.gbOrderSummry.Text = "OrderSummry";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(140, 181);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(88, 18);
            this.lblWhereToEat.TabIndex = 10;
            this.lblWhereToEat.Text = "Take away";
            this.lblWhereToEat.Click += new System.EventHandler(this.lblWhereToEat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Where To eat:";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(6, 136);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(187, 14);
            this.lblTopping.TabIndex = 8;
            this.lblTopping.Text = " No Topping                            ";
            this.lblTopping.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Topping:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Crust Type:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(118, 79);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(40, 18);
            this.lblCrustType.TabIndex = 6;
            this.lblCrustType.Text = "Thin";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(115, 285);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(48, 34);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "$0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Price:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(67, 31);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 18);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Mideum";
            this.lblSize.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThinckCrust);
            this.gbCrust.Controls.Add(this.rbThinCrust);
            this.gbCrust.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.Location = new System.Drawing.Point(12, 283);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(126, 150);
            this.gbCrust.TabIndex = 2;
            this.gbCrust.TabStop = false;
            this.gbCrust.Tag = "0";
            this.gbCrust.Text = "Crust";
            // 
            // rbThinckCrust
            // 
            this.rbThinckCrust.AutoSize = true;
            this.rbThinckCrust.Location = new System.Drawing.Point(15, 90);
            this.rbThinckCrust.Name = "rbThinckCrust";
            this.rbThinckCrust.Size = new System.Drawing.Size(75, 22);
            this.rbThinckCrust.TabIndex = 2;
            this.rbThinckCrust.TabStop = true;
            this.rbThinckCrust.Tag = "10";
            this.rbThinckCrust.Text = "Thinck";
            this.rbThinckCrust.UseVisualStyleBackColor = true;
            this.rbThinckCrust.CheckedChanged += new System.EventHandler(this.rbThinckCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(15, 40);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(58, 22);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.Controls.Add(this.chkTomito);
            this.gbTopping.Controls.Add(this.chkOlive);
            this.gbTopping.Controls.Add(this.chkOnion);
            this.gbTopping.Controls.Add(this.chkCicken);
            this.gbTopping.Controls.Add(this.chkMashrom);
            this.gbTopping.Controls.Add(this.chkExtraChess);
            this.gbTopping.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.Location = new System.Drawing.Point(207, 102);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(306, 150);
            this.gbTopping.TabIndex = 5;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            // 
            // chkTomito
            // 
            this.chkTomito.AutoSize = true;
            this.chkTomito.Location = new System.Drawing.Point(6, 122);
            this.chkTomito.Name = "chkTomito";
            this.chkTomito.Size = new System.Drawing.Size(78, 22);
            this.chkTomito.TabIndex = 6;
            this.chkTomito.Tag = "5";
            this.chkTomito.Text = "Tomito";
            this.chkTomito.UseVisualStyleBackColor = true;
            this.chkTomito.CheckedChanged += new System.EventHandler(this.chkTomito_CheckedChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Location = new System.Drawing.Point(192, 31);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(67, 22);
            this.chkOlive.TabIndex = 7;
            this.chkOlive.Tag = "5";
            this.chkOlive.Text = "Olive";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.chkOlive_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(192, 79);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(71, 22);
            this.chkOnion.TabIndex = 8;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Oinon";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkCicken
            // 
            this.chkCicken.AutoSize = true;
            this.chkCicken.Location = new System.Drawing.Point(192, 122);
            this.chkCicken.Name = "chkCicken";
            this.chkCicken.Size = new System.Drawing.Size(86, 22);
            this.chkCicken.TabIndex = 9;
            this.chkCicken.Tag = "10";
            this.chkCicken.Text = "Ckicken";
            this.chkCicken.UseVisualStyleBackColor = true;
            this.chkCicken.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // chkMashrom
            // 
            this.chkMashrom.AutoSize = true;
            this.chkMashrom.Location = new System.Drawing.Point(6, 79);
            this.chkMashrom.Name = "chkMashrom";
            this.chkMashrom.Size = new System.Drawing.Size(95, 22);
            this.chkMashrom.TabIndex = 1;
            this.chkMashrom.Tag = "5";
            this.chkMashrom.Text = "Mashrom";
            this.chkMashrom.UseVisualStyleBackColor = true;
            this.chkMashrom.CheckedChanged += new System.EventHandler(this.chkMashrom_CheckedChanged);
            // 
            // chkExtraChess
            // 
            this.chkExtraChess.AutoSize = true;
            this.chkExtraChess.Location = new System.Drawing.Point(6, 31);
            this.chkExtraChess.Name = "chkExtraChess";
            this.chkExtraChess.Size = new System.Drawing.Size(111, 22);
            this.chkExtraChess.TabIndex = 0;
            this.chkExtraChess.Tag = "5";
            this.chkExtraChess.Text = "ExtraChess";
            this.chkExtraChess.UseVisualStyleBackColor = true;
            this.chkExtraChess.CheckedChanged += new System.EventHandler(this.chkExtraChess_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeAway);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(213, 271);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(272, 74);
            this.gbWhereToEat.TabIndex = 6;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Tag = "0";
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeAway
            // 
            this.rbTakeAway.AutoSize = true;
            this.rbTakeAway.Location = new System.Drawing.Point(148, 29);
            this.rbTakeAway.Name = "rbTakeAway";
            this.rbTakeAway.Size = new System.Drawing.Size(106, 22);
            this.rbTakeAway.TabIndex = 2;
            this.rbTakeAway.TabStop = true;
            this.rbTakeAway.Tag = "10";
            this.rbTakeAway.Text = "Take away";
            this.rbTakeAway.UseVisualStyleBackColor = true;
            this.rbTakeAway.CheckedChanged += new System.EventHandler(this.rbTakeAway_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(15, 29);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(70, 22);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderIn
            // 
            this.btnOrderIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderIn.Location = new System.Drawing.Point(207, 387);
            this.btnOrderIn.Name = "btnOrderIn";
            this.btnOrderIn.Size = new System.Drawing.Size(91, 34);
            this.btnOrderIn.TabIndex = 7;
            this.btnOrderIn.Text = "Order In";
            this.btnOrderIn.UseVisualStyleBackColor = true;
            this.btnOrderIn.Click += new System.EventHandler(this.btnOrderIn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(361, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(171, 221);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 33);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of Pizza :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(807, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOrderIn);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbOrderSummry);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbOrderSummry.ResumeLayout(false);
            this.gbOrderSummry.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMideum;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbOrderSummry;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThinckCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.CheckBox chkTomito;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkCicken;
        private System.Windows.Forms.CheckBox chkMashrom;
        private System.Windows.Forms.CheckBox chkExtraChess;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeAway;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Button btnOrderIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

