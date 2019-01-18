namespace KNN
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSepalLength = new System.Windows.Forms.TextBox();
            this.textBoxSepalWidth = new System.Windows.Forms.TextBox();
            this.textBoxPetalLength = new System.Windows.Forms.TextBox();
            this.textBoxPetalWidth = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.diagnozeButton = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxVectorNumber = new System.Windows.Forms.TextBox();
            this.labelVectorNumber = new System.Windows.Forms.Label();
            this.labelSepalLength = new System.Windows.Forms.Label();
            this.labelSepalWidth = new System.Windows.Forms.Label();
            this.labelPetalLength = new System.Windows.Forms.Label();
            this.labelPetalWidth = new System.Windows.Forms.Label();
            this.textBoxClassification = new System.Windows.Forms.TextBox();
            this.labelClassification = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.buttonShowLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(810, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxSepalLength
            // 
            this.textBoxSepalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSepalLength.Location = new System.Drawing.Point(3, 34);
            this.textBoxSepalLength.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxSepalLength.Name = "textBoxSepalLength";
            this.textBoxSepalLength.Size = new System.Drawing.Size(158, 22);
            this.textBoxSepalLength.TabIndex = 1;
            this.textBoxSepalLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSepalLength.TextChanged += new System.EventHandler(this.textBoxSepalLength_TextChanged);
            // 
            // textBoxSepalWidth
            // 
            this.textBoxSepalWidth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxSepalWidth.Location = new System.Drawing.Point(3, 75);
            this.textBoxSepalWidth.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxSepalWidth.Name = "textBoxSepalWidth";
            this.textBoxSepalWidth.Size = new System.Drawing.Size(158, 22);
            this.textBoxSepalWidth.TabIndex = 2;
            this.textBoxSepalWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSepalWidth.TextChanged += new System.EventHandler(this.textBoxSepalWidth_TextChanged);
            // 
            // textBoxPetalLength
            // 
            this.textBoxPetalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPetalLength.Location = new System.Drawing.Point(3, 34);
            this.textBoxPetalLength.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxPetalLength.Name = "textBoxPetalLength";
            this.textBoxPetalLength.Size = new System.Drawing.Size(158, 22);
            this.textBoxPetalLength.TabIndex = 3;
            this.textBoxPetalLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPetalLength.TextChanged += new System.EventHandler(this.textBoxPetalLength_TextChanged);
            // 
            // textBoxPetalWidth
            // 
            this.textBoxPetalWidth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxPetalWidth.Location = new System.Drawing.Point(3, 75);
            this.textBoxPetalWidth.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxPetalWidth.Name = "textBoxPetalWidth";
            this.textBoxPetalWidth.Size = new System.Drawing.Size(158, 22);
            this.textBoxPetalWidth.TabIndex = 4;
            this.textBoxPetalWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPetalWidth.TextChanged += new System.EventHandler(this.textBoxPetalWidth_TextChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 118);
            this.loadButton.Margin = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(164, 30);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Odśwież Bazę";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(182, 118);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(334, 30);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Dodaj Kompletny Wpis Do Bazy";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modyfikuj po ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(3, 72);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(158, 25);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Usuń po ID";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // diagnozeButton
            // 
            this.diagnozeButton.Location = new System.Drawing.Point(3, 62);
            this.diagnozeButton.Name = "diagnozeButton";
            this.diagnozeButton.Size = new System.Drawing.Size(208, 25);
            this.diagnozeButton.TabIndex = 9;
            this.diagnozeButton.Text = "Diagnozuj";
            this.diagnozeButton.UseVisualStyleBackColor = true;
            this.diagnozeButton.Click += new System.EventHandler(this.diagnozeButton_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(6, 13);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(155, 22);
            this.textBoxID.TabIndex = 10;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVectorNumber
            // 
            this.textBoxVectorNumber.Location = new System.Drawing.Point(3, 34);
            this.textBoxVectorNumber.Name = "textBoxVectorNumber";
            this.textBoxVectorNumber.Size = new System.Drawing.Size(208, 22);
            this.textBoxVectorNumber.TabIndex = 11;
            this.textBoxVectorNumber.Text = "1";
            this.textBoxVectorNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVectorNumber.TextChanged += new System.EventHandler(this.textBoxVectorNumber_TextChanged);
            // 
            // labelVectorNumber
            // 
            this.labelVectorNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVectorNumber.AutoSize = true;
            this.labelVectorNumber.Location = new System.Drawing.Point(28, 18);
            this.labelVectorNumber.Name = "labelVectorNumber";
            this.labelVectorNumber.Size = new System.Drawing.Size(173, 13);
            this.labelVectorNumber.TabIndex = 13;
            this.labelVectorNumber.Text = "Liczba wektorów referencyjnych";
            // 
            // labelSepalLength
            // 
            this.labelSepalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSepalLength.AutoSize = true;
            this.labelSepalLength.Location = new System.Drawing.Point(51, 18);
            this.labelSepalLength.Name = "labelSepalLength";
            this.labelSepalLength.Size = new System.Drawing.Size(54, 13);
            this.labelSepalLength.TabIndex = 14;
            this.labelSepalLength.Text = "Długość";
            // 
            // labelSepalWidth
            // 
            this.labelSepalWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSepalWidth.AutoSize = true;
            this.labelSepalWidth.Location = new System.Drawing.Point(51, 59);
            this.labelSepalWidth.Name = "labelSepalWidth";
            this.labelSepalWidth.Size = new System.Drawing.Size(61, 13);
            this.labelSepalWidth.TabIndex = 15;
            this.labelSepalWidth.Text = "Szerokość";
            // 
            // labelPetalLength
            // 
            this.labelPetalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPetalLength.AutoSize = true;
            this.labelPetalLength.Location = new System.Drawing.Point(57, 18);
            this.labelPetalLength.Name = "labelPetalLength";
            this.labelPetalLength.Size = new System.Drawing.Size(54, 13);
            this.labelPetalLength.TabIndex = 16;
            this.labelPetalLength.Text = "Długość";
            // 
            // labelPetalWidth
            // 
            this.labelPetalWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPetalWidth.AutoSize = true;
            this.labelPetalWidth.Location = new System.Drawing.Point(57, 59);
            this.labelPetalWidth.Name = "labelPetalWidth";
            this.labelPetalWidth.Size = new System.Drawing.Size(61, 13);
            this.labelPetalWidth.TabIndex = 17;
            this.labelPetalWidth.Text = "Szerokość";
            // 
            // textBoxClassification
            // 
            this.textBoxClassification.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxClassification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxClassification.Location = new System.Drawing.Point(3, 112);
            this.textBoxClassification.Name = "textBoxClassification";
            this.textBoxClassification.ReadOnly = true;
            this.textBoxClassification.Size = new System.Drawing.Size(208, 22);
            this.textBoxClassification.TabIndex = 18;
            this.textBoxClassification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelClassification
            // 
            this.labelClassification.AutoSize = true;
            this.labelClassification.Location = new System.Drawing.Point(46, 96);
            this.labelClassification.Name = "labelClassification";
            this.labelClassification.Size = new System.Drawing.Size(125, 13);
            this.labelClassification.TabIndex = 19;
            this.labelClassification.Text = "Otrzymana klasyfikacja";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(836, 27);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.logBox.Size = new System.Drawing.Size(410, 610);
            this.logBox.TabIndex = 20;
            this.logBox.Text = "";
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClearLog.Location = new System.Drawing.Point(836, 644);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(410, 25);
            this.buttonClearLog.TabIndex = 21;
            this.buttonClearLog.Text = "Czyść Log";
            this.buttonClearLog.UseVisualStyleBackColor = false;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // buttonShowLog
            // 
            this.buttonShowLog.Location = new System.Drawing.Point(745, 84);
            this.buttonShowLog.Name = "buttonShowLog";
            this.buttonShowLog.Size = new System.Drawing.Size(75, 65);
            this.buttonShowLog.TabIndex = 22;
            this.buttonShowLog.Text = "Ukryj log";
            this.buttonShowLog.UseVisualStyleBackColor = true;
            this.buttonShowLog.Click += new System.EventHandler(this.buttonShowLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSepalWidth);
            this.groupBox2.Controls.Add(this.textBoxSepalLength);
            this.groupBox2.Controls.Add(this.labelSepalWidth);
            this.groupBox2.Controls.Add(this.labelSepalLength);
            this.groupBox2.Location = new System.Drawing.Point(182, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Działka Kielicha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPetalWidth);
            this.groupBox3.Controls.Add(this.textBoxPetalLength);
            this.groupBox3.Controls.Add(this.labelPetalLength);
            this.groupBox3.Controls.Add(this.labelPetalWidth);
            this.groupBox3.Location = new System.Drawing.Point(352, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Płatek";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelVectorNumber);
            this.groupBox4.Controls.Add(this.textBoxVectorNumber);
            this.groupBox4.Controls.Add(this.diagnozeButton);
            this.groupBox4.Controls.Add(this.labelClassification);
            this.groupBox4.Controls.Add(this.textBoxClassification);
            this.groupBox4.Location = new System.Drawing.Point(522, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 137);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diagnoza";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 65);
            this.button2.TabIndex = 27;
            this.button2.Text = "Pokaż Listę Odległości";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonListOfDistances_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonShowLog);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(820, 720);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KNN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSepalLength;
        private System.Windows.Forms.TextBox textBoxSepalWidth;
        private System.Windows.Forms.TextBox textBoxPetalLength;
        private System.Windows.Forms.TextBox textBoxPetalWidth;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button diagnozeButton;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxVectorNumber;
        private System.Windows.Forms.Label labelVectorNumber;
        private System.Windows.Forms.Label labelSepalLength;
        private System.Windows.Forms.Label labelSepalWidth;
        private System.Windows.Forms.Label labelPetalLength;
        private System.Windows.Forms.Label labelPetalWidth;
        private System.Windows.Forms.TextBox textBoxClassification;
        private System.Windows.Forms.Label labelClassification;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonShowLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
    }
}

