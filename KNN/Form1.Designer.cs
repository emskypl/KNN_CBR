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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxSepalLength = new System.Windows.Forms.TextBox();
            this.textBoxSepalWidth = new System.Windows.Forms.TextBox();
            this.textBoxPetalLength = new System.Windows.Forms.TextBox();
            this.textBoxPetalWidth = new System.Windows.Forms.TextBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
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
            this.logButton = new System.Windows.Forms.Button();
            this.groupBoxID = new System.Windows.Forms.GroupBox();
            this.groupBoxSepal = new System.Windows.Forms.GroupBox();
            this.groupBoxPetal = new System.Windows.Forms.GroupBox();
            this.groupBoxDiagnoze = new System.Windows.Forms.GroupBox();
            this.listButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxID.SuspendLayout();
            this.groupBoxSepal.SuspendLayout();
            this.groupBoxPetal.SuspendLayout();
            this.groupBoxDiagnoze.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 155);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(810, 515);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.MouseLeave += new System.EventHandler(this.dataGridView_MouseLeave);
            this.dataGridView.MouseHover += new System.EventHandler(this.dataGridView_MouseHover);
            // 
            // textBoxSepalLength
            // 
            this.textBoxSepalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSepalLength.BackColor = System.Drawing.Color.White;
            this.textBoxSepalLength.Location = new System.Drawing.Point(3, 34);
            this.textBoxSepalLength.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxSepalLength.Name = "textBoxSepalLength";
            this.textBoxSepalLength.Size = new System.Drawing.Size(158, 22);
            this.textBoxSepalLength.TabIndex = 1;
            this.textBoxSepalLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSepalLength.TextChanged += new System.EventHandler(this.textBoxSepalLength_TextChanged);
            this.textBoxSepalLength.MouseLeave += new System.EventHandler(this.textBoxSepalLength_MouseLeave);
            this.textBoxSepalLength.MouseHover += new System.EventHandler(this.textBoxSepalLength_MouseHover);
            // 
            // textBoxSepalWidth
            // 
            this.textBoxSepalWidth.BackColor = System.Drawing.Color.White;
            this.textBoxSepalWidth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxSepalWidth.Location = new System.Drawing.Point(3, 75);
            this.textBoxSepalWidth.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxSepalWidth.Name = "textBoxSepalWidth";
            this.textBoxSepalWidth.Size = new System.Drawing.Size(158, 22);
            this.textBoxSepalWidth.TabIndex = 2;
            this.textBoxSepalWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSepalWidth.TextChanged += new System.EventHandler(this.textBoxSepalWidth_TextChanged);
            this.textBoxSepalWidth.MouseLeave += new System.EventHandler(this.textBoxSepalWidth_MouseLeave);
            this.textBoxSepalWidth.MouseHover += new System.EventHandler(this.textBoxSepalWidth_MouseHover);
            // 
            // textBoxPetalLength
            // 
            this.textBoxPetalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPetalLength.BackColor = System.Drawing.Color.White;
            this.textBoxPetalLength.Location = new System.Drawing.Point(3, 34);
            this.textBoxPetalLength.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxPetalLength.Name = "textBoxPetalLength";
            this.textBoxPetalLength.Size = new System.Drawing.Size(158, 22);
            this.textBoxPetalLength.TabIndex = 3;
            this.textBoxPetalLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPetalLength.TextChanged += new System.EventHandler(this.textBoxPetalLength_TextChanged);
            this.textBoxPetalLength.MouseLeave += new System.EventHandler(this.textBoxPetalLength_MouseLeave);
            this.textBoxPetalLength.MouseHover += new System.EventHandler(this.textBoxPetalLength_MouseHover);
            // 
            // textBoxPetalWidth
            // 
            this.textBoxPetalWidth.BackColor = System.Drawing.Color.White;
            this.textBoxPetalWidth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxPetalWidth.Location = new System.Drawing.Point(3, 75);
            this.textBoxPetalWidth.Margin = new System.Windows.Forms.Padding(30, 3, 30, 15);
            this.textBoxPetalWidth.Name = "textBoxPetalWidth";
            this.textBoxPetalWidth.Size = new System.Drawing.Size(158, 22);
            this.textBoxPetalWidth.TabIndex = 4;
            this.textBoxPetalWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPetalWidth.TextChanged += new System.EventHandler(this.textBoxPetalWidth_TextChanged);
            this.textBoxPetalWidth.MouseLeave += new System.EventHandler(this.textBoxPetalWidth_MouseLeave);
            this.textBoxPetalWidth.MouseHover += new System.EventHandler(this.textBoxPetalWidth_MouseHover);
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.Gainsboro;
            this.reloadButton.Location = new System.Drawing.Point(12, 118);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(164, 30);
            this.reloadButton.TabIndex = 5;
            this.reloadButton.Text = "Odśwież Bazę";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.Location = new System.Drawing.Point(182, 118);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(334, 30);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Dodaj Kompletny Wpis Do Bazy";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.Gainsboro;
            this.modifyButton.Location = new System.Drawing.Point(3, 41);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(158, 25);
            this.modifyButton.TabIndex = 7;
            this.modifyButton.Text = "Modyfikuj po ID";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(3, 72);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(158, 25);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Usuń po ID";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // diagnozeButton
            // 
            this.diagnozeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.diagnozeButton.Location = new System.Drawing.Point(3, 62);
            this.diagnozeButton.Name = "diagnozeButton";
            this.diagnozeButton.Size = new System.Drawing.Size(208, 25);
            this.diagnozeButton.TabIndex = 9;
            this.diagnozeButton.Text = "Diagnozuj";
            this.diagnozeButton.UseVisualStyleBackColor = false;
            this.diagnozeButton.Click += new System.EventHandler(this.diagnozeButton_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(6, 13);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(155, 22);
            this.textBoxID.TabIndex = 10;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxID.MouseLeave += new System.EventHandler(this.textBoxID_MouseLeave);
            this.textBoxID.MouseHover += new System.EventHandler(this.textBoxID_MouseHover);
            // 
            // textBoxVectorNumber
            // 
            this.textBoxVectorNumber.BackColor = System.Drawing.Color.White;
            this.textBoxVectorNumber.Location = new System.Drawing.Point(3, 34);
            this.textBoxVectorNumber.Name = "textBoxVectorNumber";
            this.textBoxVectorNumber.Size = new System.Drawing.Size(208, 22);
            this.textBoxVectorNumber.TabIndex = 11;
            this.textBoxVectorNumber.Text = "1";
            this.textBoxVectorNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVectorNumber.TextChanged += new System.EventHandler(this.textBoxVectorNumber_TextChanged);
            this.textBoxVectorNumber.MouseLeave += new System.EventHandler(this.textBoxVectorNumber_MouseLeave);
            this.textBoxVectorNumber.MouseHover += new System.EventHandler(this.textBoxVectorNumber_MouseHover);
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
            this.textBoxClassification.BackColor = System.Drawing.Color.White;
            this.textBoxClassification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxClassification.Location = new System.Drawing.Point(3, 112);
            this.textBoxClassification.Name = "textBoxClassification";
            this.textBoxClassification.ReadOnly = true;
            this.textBoxClassification.Size = new System.Drawing.Size(208, 22);
            this.textBoxClassification.TabIndex = 18;
            this.textBoxClassification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxClassification.MouseLeave += new System.EventHandler(this.textBoxClassification_MouseLeave);
            this.textBoxClassification.MouseHover += new System.EventHandler(this.textBoxClassification_MouseHover);
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
            this.logBox.MouseLeave += new System.EventHandler(this.logBox_MouseLeave);
            this.logBox.MouseHover += new System.EventHandler(this.logBox_MouseHover);
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
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.Gainsboro;
            this.logButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logButton.Location = new System.Drawing.Point(745, 106);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 42);
            this.logButton.TabIndex = 22;
            this.logButton.Text = "Ukryj log";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.buttonShowLog_Click);
            // 
            // groupBoxID
            // 
            this.groupBoxID.Controls.Add(this.textBoxID);
            this.groupBoxID.Controls.Add(this.deleteButton);
            this.groupBoxID.Controls.Add(this.modifyButton);
            this.groupBoxID.Location = new System.Drawing.Point(12, 12);
            this.groupBoxID.Name = "groupBoxID";
            this.groupBoxID.Size = new System.Drawing.Size(164, 100);
            this.groupBoxID.TabIndex = 23;
            this.groupBoxID.TabStop = false;
            this.groupBoxID.Text = "ID";
            // 
            // groupBoxSepal
            // 
            this.groupBoxSepal.Controls.Add(this.textBoxSepalWidth);
            this.groupBoxSepal.Controls.Add(this.textBoxSepalLength);
            this.groupBoxSepal.Controls.Add(this.labelSepalWidth);
            this.groupBoxSepal.Controls.Add(this.labelSepalLength);
            this.groupBoxSepal.Location = new System.Drawing.Point(182, 12);
            this.groupBoxSepal.Name = "groupBoxSepal";
            this.groupBoxSepal.Size = new System.Drawing.Size(164, 100);
            this.groupBoxSepal.TabIndex = 24;
            this.groupBoxSepal.TabStop = false;
            this.groupBoxSepal.Text = "Działka Kielicha";
            // 
            // groupBoxPetal
            // 
            this.groupBoxPetal.Controls.Add(this.textBoxPetalWidth);
            this.groupBoxPetal.Controls.Add(this.textBoxPetalLength);
            this.groupBoxPetal.Controls.Add(this.labelPetalLength);
            this.groupBoxPetal.Controls.Add(this.labelPetalWidth);
            this.groupBoxPetal.Location = new System.Drawing.Point(352, 12);
            this.groupBoxPetal.Name = "groupBoxPetal";
            this.groupBoxPetal.Size = new System.Drawing.Size(164, 100);
            this.groupBoxPetal.TabIndex = 25;
            this.groupBoxPetal.TabStop = false;
            this.groupBoxPetal.Text = "Płatek";
            // 
            // groupBoxDiagnoze
            // 
            this.groupBoxDiagnoze.Controls.Add(this.labelVectorNumber);
            this.groupBoxDiagnoze.Controls.Add(this.textBoxVectorNumber);
            this.groupBoxDiagnoze.Controls.Add(this.diagnozeButton);
            this.groupBoxDiagnoze.Controls.Add(this.labelClassification);
            this.groupBoxDiagnoze.Controls.Add(this.textBoxClassification);
            this.groupBoxDiagnoze.Location = new System.Drawing.Point(522, 12);
            this.groupBoxDiagnoze.Name = "groupBoxDiagnoze";
            this.groupBoxDiagnoze.Size = new System.Drawing.Size(214, 137);
            this.groupBoxDiagnoze.TabIndex = 26;
            this.groupBoxDiagnoze.TabStop = false;
            this.groupBoxDiagnoze.Text = "Diagnoza";
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.Gainsboro;
            this.listButton.Location = new System.Drawing.Point(745, 17);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(75, 42);
            this.listButton.TabIndex = 27;
            this.listButton.Text = "Pokaż Listę Odległości";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.buttonListOfDistances_Click);
            // 
            // instructionsButton
            // 
            this.instructionsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.instructionsButton.Location = new System.Drawing.Point(745, 61);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(75, 42);
            this.instructionsButton.TabIndex = 28;
            this.instructionsButton.Text = "Pokaż Instrukcje";
            this.instructionsButton.UseVisualStyleBackColor = false;
            this.instructionsButton.Click += new System.EventHandler(this.buttonInstructions_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.groupBoxDiagnoze);
            this.Controls.Add(this.groupBoxPetal);
            this.Controls.Add(this.groupBoxSepal);
            this.Controls.Add(this.groupBoxID);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(820, 720);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KNN - Diagnoza Kwiatu Irysa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxID.ResumeLayout(false);
            this.groupBoxID.PerformLayout();
            this.groupBoxSepal.ResumeLayout(false);
            this.groupBoxSepal.PerformLayout();
            this.groupBoxPetal.ResumeLayout(false);
            this.groupBoxPetal.PerformLayout();
            this.groupBoxDiagnoze.ResumeLayout(false);
            this.groupBoxDiagnoze.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxSepalLength;
        private System.Windows.Forms.TextBox textBoxSepalWidth;
        private System.Windows.Forms.TextBox textBoxPetalLength;
        private System.Windows.Forms.TextBox textBoxPetalWidth;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button modifyButton;
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
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.GroupBox groupBoxID;
        private System.Windows.Forms.GroupBox groupBoxSepal;
        private System.Windows.Forms.GroupBox groupBoxPetal;
        private System.Windows.Forms.GroupBox groupBoxDiagnoze;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button instructionsButton;
    }
}

