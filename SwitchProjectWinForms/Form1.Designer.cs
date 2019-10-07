namespace SwitchProjectWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Day = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.Button();
            this.Operations = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.panelStartChoise = new System.Windows.Forms.Panel();
            this.panelDay = new System.Windows.Forms.Panel();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.labelDayResult = new System.Windows.Forms.Label();
            this.labelDayMessage = new System.Windows.Forms.Label();
            this.buttonDayIdentify = new System.Windows.Forms.Button();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelMonthResult = new System.Windows.Forms.Label();
            this.labelMonthMessage = new System.Windows.Forms.Label();
            this.buttonMonthIdentify = new System.Windows.Forms.Button();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelOperation = new System.Windows.Forms.Label();
            this.textBoxOperation = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.linkLabelGoBack = new System.Windows.Forms.LinkLabel();
            this.linkLabelEXIT = new System.Windows.Forms.LinkLabel();
            this.linkLabelGo_Back = new System.Windows.Forms.LinkLabel();
            this.linkLabelEXIT2 = new System.Windows.Forms.LinkLabel();
            this.panelStartChoise.SuspendLayout();
            this.panelDay.SuspendLayout();
            this.panelMonth.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // Day
            // 
            this.Day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Day.BackColor = System.Drawing.Color.DarkOrange;
            this.Day.Font = new System.Drawing.Font("Arial", 14F);
            this.Day.Location = new System.Drawing.Point(42, 18);
            this.Day.Margin = new System.Windows.Forms.Padding(4);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(485, 55);
            this.Day.TabIndex = 0;
            this.Day.Text = "Расшифровка дня недели";
            this.Day.UseVisualStyleBackColor = false;
            this.Day.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Month
            // 
            this.Month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Month.BackColor = System.Drawing.Color.DarkOrange;
            this.Month.Font = new System.Drawing.Font("Arial", 14F);
            this.Month.Location = new System.Drawing.Point(42, 80);
            this.Month.Margin = new System.Windows.Forms.Padding(4);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(485, 55);
            this.Month.TabIndex = 1;
            this.Month.Text = "Расшифровка месяца";
            this.Month.UseVisualStyleBackColor = false;
            this.Month.Click += new System.EventHandler(this.Mounth_Click);
            // 
            // Operations
            // 
            this.Operations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Operations.BackColor = System.Drawing.Color.DarkOrange;
            this.Operations.Font = new System.Drawing.Font("Arial", 14F);
            this.Operations.Location = new System.Drawing.Point(42, 143);
            this.Operations.Margin = new System.Windows.Forms.Padding(4);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(485, 55);
            this.Operations.TabIndex = 2;
            this.Operations.Text = "Выполнение операций над числами";
            this.Operations.UseVisualStyleBackColor = false;
            this.Operations.Click += new System.EventHandler(this.Operations_Click);
            // 
            // EXIT
            // 
            this.EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EXIT.BackColor = System.Drawing.Color.DarkOrange;
            this.EXIT.Font = new System.Drawing.Font("Arial", 14F);
            this.EXIT.Location = new System.Drawing.Point(42, 207);
            this.EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(485, 53);
            this.EXIT.TabIndex = 3;
            this.EXIT.Text = "Выход";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // panelStartChoise
            // 
            this.panelStartChoise.Controls.Add(this.Day);
            this.panelStartChoise.Controls.Add(this.EXIT);
            this.panelStartChoise.Controls.Add(this.Month);
            this.panelStartChoise.Controls.Add(this.Operations);
            this.panelStartChoise.Location = new System.Drawing.Point(196, 224);
            this.panelStartChoise.Name = "panelStartChoise";
            this.panelStartChoise.Size = new System.Drawing.Size(571, 285);
            this.panelStartChoise.TabIndex = 4;
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.textBoxDay);
            this.panelDay.Controls.Add(this.labelDayResult);
            this.panelDay.Controls.Add(this.labelDayMessage);
            this.panelDay.Controls.Add(this.buttonDayIdentify);
            this.panelDay.Location = new System.Drawing.Point(12, 12);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(400, 203);
            this.panelDay.TabIndex = 5;
            this.panelDay.Visible = false;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDay.Location = new System.Drawing.Point(83, 69);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(255, 30);
            this.textBoxDay.TabIndex = 3;
            // 
            // labelDayResult
            // 
            this.labelDayResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDayResult.AutoSize = true;
            this.labelDayResult.Location = new System.Drawing.Point(180, 161);
            this.labelDayResult.Name = "labelDayResult";
            this.labelDayResult.Size = new System.Drawing.Size(62, 23);
            this.labelDayResult.TabIndex = 2;
            this.labelDayResult.Text = "label2";
            this.labelDayResult.Visible = false;
            this.labelDayResult.Click += new System.EventHandler(this.LabelDayResult_Click);
            // 
            // labelDayMessage
            // 
            this.labelDayMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDayMessage.AutoSize = true;
            this.labelDayMessage.Location = new System.Drawing.Point(118, 43);
            this.labelDayMessage.Name = "labelDayMessage";
            this.labelDayMessage.Size = new System.Drawing.Size(188, 23);
            this.labelDayMessage.TabIndex = 1;
            this.labelDayMessage.Text = "Введите номер дня";
            this.labelDayMessage.Click += new System.EventHandler(this.Label1_Click);
            // 
            // buttonDayIdentify
            // 
            this.buttonDayIdentify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDayIdentify.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonDayIdentify.Location = new System.Drawing.Point(137, 105);
            this.buttonDayIdentify.Name = "buttonDayIdentify";
            this.buttonDayIdentify.Size = new System.Drawing.Size(157, 32);
            this.buttonDayIdentify.TabIndex = 0;
            this.buttonDayIdentify.Text = "Посчитать";
            this.buttonDayIdentify.UseVisualStyleBackColor = false;
            this.buttonDayIdentify.Click += new System.EventHandler(this.ButtonDayIdentify_Click);
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.textBoxMonth);
            this.panelMonth.Controls.Add(this.labelMonthResult);
            this.panelMonth.Controls.Add(this.labelMonthMessage);
            this.panelMonth.Controls.Add(this.buttonMonthIdentify);
            this.panelMonth.Location = new System.Drawing.Point(527, 12);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(425, 203);
            this.panelMonth.TabIndex = 6;
            this.panelMonth.Visible = false;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(121, 85);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(255, 30);
            this.textBoxMonth.TabIndex = 3;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.TextBoxMounth_TextChanged);
            // 
            // labelMonthResult
            // 
            this.labelMonthResult.AutoSize = true;
            this.labelMonthResult.Location = new System.Drawing.Point(220, 172);
            this.labelMonthResult.Name = "labelMonthResult";
            this.labelMonthResult.Size = new System.Drawing.Size(62, 23);
            this.labelMonthResult.TabIndex = 2;
            this.labelMonthResult.Text = "label2";
            this.labelMonthResult.Visible = false;
            // 
            // labelMonthMessage
            // 
            this.labelMonthMessage.AutoSize = true;
            this.labelMonthMessage.Location = new System.Drawing.Point(140, 59);
            this.labelMonthMessage.Name = "labelMonthMessage";
            this.labelMonthMessage.Size = new System.Drawing.Size(222, 23);
            this.labelMonthMessage.TabIndex = 1;
            this.labelMonthMessage.Text = "Введите номер месяца";
            // 
            // buttonMonthIdentify
            // 
            this.buttonMonthIdentify.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonMonthIdentify.Location = new System.Drawing.Point(175, 121);
            this.buttonMonthIdentify.Name = "buttonMonthIdentify";
            this.buttonMonthIdentify.Size = new System.Drawing.Size(157, 32);
            this.buttonMonthIdentify.TabIndex = 0;
            this.buttonMonthIdentify.Text = "Посчитать";
            this.buttonMonthIdentify.UseVisualStyleBackColor = false;
            this.buttonMonthIdentify.Click += new System.EventHandler(this.ButtonMounthIdentify_Click);
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.textBoxB);
            this.panelOperations.Controls.Add(this.labelOperation);
            this.panelOperations.Controls.Add(this.textBoxOperation);
            this.panelOperations.Controls.Add(this.labelB);
            this.panelOperations.Controls.Add(this.textBoxA);
            this.panelOperations.Controls.Add(this.labelResult);
            this.panelOperations.Controls.Add(this.labelA);
            this.panelOperations.Controls.Add(this.buttonCount);
            this.panelOperations.Location = new System.Drawing.Point(12, 454);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(502, 257);
            this.panelOperations.TabIndex = 6;
            this.panelOperations.Visible = false;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(215, 111);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(255, 30);
            this.textBoxB.TabIndex = 7;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(26, 74);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(183, 23);
            this.labelOperation.TabIndex = 6;
            this.labelOperation.Text = "Введите операцию";
            // 
            // textBoxOperation
            // 
            this.textBoxOperation.Location = new System.Drawing.Point(215, 71);
            this.textBoxOperation.Name = "textBoxOperation";
            this.textBoxOperation.Size = new System.Drawing.Size(126, 30);
            this.textBoxOperation.TabIndex = 5;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(26, 114);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(164, 23);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "Введите число В";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(215, 29);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(255, 30);
            this.textBoxA.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(189, 215);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 23);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "label2";
            this.labelResult.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(26, 32);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(164, 23);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Введите число А";
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonCount.Location = new System.Drawing.Point(149, 161);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(157, 32);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Посчитать";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // linkLabelGoBack
            // 
            this.linkLabelGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGoBack.AutoSize = true;
            this.linkLabelGoBack.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelGoBack.Location = new System.Drawing.Point(657, 1178);
            this.linkLabelGoBack.Name = "linkLabelGoBack";
            this.linkLabelGoBack.Size = new System.Drawing.Size(66, 23);
            this.linkLabelGoBack.TabIndex = 7;
            this.linkLabelGoBack.TabStop = true;
            this.linkLabelGoBack.Text = "Назад";
            this.linkLabelGoBack.Visible = false;
            this.linkLabelGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGoBack_LinkClicked);
            // 
            // linkLabelEXIT
            // 
            this.linkLabelEXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelEXIT.AutoSize = true;
            this.linkLabelEXIT.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelEXIT.Location = new System.Drawing.Point(657, 1228);
            this.linkLabelEXIT.Name = "linkLabelEXIT";
            this.linkLabelEXIT.Size = new System.Drawing.Size(69, 23);
            this.linkLabelEXIT.TabIndex = 8;
            this.linkLabelEXIT.TabStop = true;
            this.linkLabelEXIT.Text = "Выход";
            this.linkLabelEXIT.Visible = false;
            this.linkLabelEXIT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEXIT_LinkClicked);
            // 
            // linkLabelGo_Back
            // 
            this.linkLabelGo_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGo_Back.AutoSize = true;
            this.linkLabelGo_Back.Location = new System.Drawing.Point(650, 537);
            this.linkLabelGo_Back.Name = "linkLabelGo_Back";
            this.linkLabelGo_Back.Size = new System.Drawing.Size(66, 23);
            this.linkLabelGo_Back.TabIndex = 9;
            this.linkLabelGo_Back.TabStop = true;
            this.linkLabelGo_Back.Text = "Назад";
            this.linkLabelGo_Back.Visible = false;
            this.linkLabelGo_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGo_Back_LinkClicked);
            // 
            // linkLabelEXIT2
            // 
            this.linkLabelEXIT2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelEXIT2.AutoSize = true;
            this.linkLabelEXIT2.Location = new System.Drawing.Point(650, 568);
            this.linkLabelEXIT2.Name = "linkLabelEXIT2";
            this.linkLabelEXIT2.Size = new System.Drawing.Size(69, 23);
            this.linkLabelEXIT2.TabIndex = 10;
            this.linkLabelEXIT2.TabStop = true;
            this.linkLabelEXIT2.Text = "Выход";
            this.linkLabelEXIT2.Visible = false;
            this.linkLabelEXIT2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEXIT2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.linkLabelEXIT2);
            this.Controls.Add(this.linkLabelGo_Back);
            this.Controls.Add(this.linkLabelEXIT);
            this.Controls.Add(this.linkLabelGoBack);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.panelMonth);
            this.Controls.Add(this.panelStartChoise);
            this.Controls.Add(this.panelDay);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(950, 690);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwitchProjectWinForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStartChoise.ResumeLayout(false);
            this.panelDay.ResumeLayout(false);
            this.panelDay.PerformLayout();
            this.panelMonth.ResumeLayout(false);
            this.panelMonth.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.panelOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Day;
        private System.Windows.Forms.Button Month;
        private System.Windows.Forms.Button Operations;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Panel panelStartChoise;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label labelDayResult;
        private System.Windows.Forms.Label labelDayMessage;
        private System.Windows.Forms.Button buttonDayIdentify;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelMonthResult;
        private System.Windows.Forms.Label labelMonthMessage;
        private System.Windows.Forms.Button buttonMonthIdentify;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.TextBox textBoxOperation;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.LinkLabel linkLabelGoBack;
        private System.Windows.Forms.LinkLabel linkLabelEXIT;
        private System.Windows.Forms.LinkLabel linkLabelGo_Back;
        private System.Windows.Forms.LinkLabel linkLabelEXIT2;
    }
}

