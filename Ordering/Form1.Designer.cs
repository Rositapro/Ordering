namespace Ordering
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewSteps = new ListView();
            btnMergeSort = new Button();
            btnMezclaNatural = new Button();
            btnMezclaDirecta = new Button();
            btnIngresar = new Button();
            txtInput = new TextBox();
            lblNumbers = new Label();
            btnClearList = new Button();
            cmbOrderType = new ComboBox();
            SuspendLayout();
            // 
            // listViewSteps
            // 
            listViewSteps.FullRowSelect = true;
            listViewSteps.GridLines = true;
            listViewSteps.Location = new Point(346, 12);
            listViewSteps.Name = "listViewSteps";
            listViewSteps.Size = new Size(323, 426);
            listViewSteps.TabIndex = 0;
            listViewSteps.UseCompatibleStateImageBehavior = false;
            listViewSteps.View = View.Details;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Location = new Point(232, 62);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(75, 23);
            btnMergeSort.TabIndex = 1;
            btnMergeSort.Text = "Merge";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // btnMezclaNatural
            // 
            btnMezclaNatural.Location = new Point(232, 124);
            btnMezclaNatural.Name = "btnMezclaNatural";
            btnMezclaNatural.Size = new Size(75, 23);
            btnMezclaNatural.TabIndex = 2;
            btnMezclaNatural.Text = "Natural";
            btnMezclaNatural.UseVisualStyleBackColor = true;
            btnMezclaNatural.Click += btnNaturalMerge_Click;
            // 
            // btnMezclaDirecta
            // 
            btnMezclaDirecta.Location = new Point(232, 91);
            btnMezclaDirecta.Name = "btnMezclaDirecta";
            btnMezclaDirecta.Size = new Size(75, 23);
            btnMezclaDirecta.TabIndex = 3;
            btnMezclaDirecta.Text = "Directa";
            btnMezclaDirecta.UseVisualStyleBackColor = true;
            btnMezclaDirecta.Click += btnDirectMerge_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(232, 30);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(68, 30);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(151, 23);
            txtInput.TabIndex = 5;
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Location = new Point(11, 34);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(56, 15);
            lblNumbers.TabIndex = 6;
            lblNumbers.Text = "Numbers";
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(232, 169);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(75, 23);
            btnClearList.TabIndex = 7;
            btnClearList.Text = "Clear list";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // cmbOrderType
            // 
            cmbOrderType.FormattingEnabled = true;
            cmbOrderType.Location = new Point(177, 247);
            cmbOrderType.Name = "cmbOrderType";
            cmbOrderType.Size = new Size(121, 23);
            cmbOrderType.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 450);
            Controls.Add(cmbOrderType);
            Controls.Add(btnClearList);
            Controls.Add(lblNumbers);
            Controls.Add(txtInput);
            Controls.Add(btnIngresar);
            Controls.Add(btnMezclaDirecta);
            Controls.Add(btnMezclaNatural);
            Controls.Add(btnMergeSort);
            Controls.Add(listViewSteps);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewSteps;
        private Button btnMergeSort;
        private Button btnMezclaNatural;
        private Button btnMezclaDirecta;
        private Button btnIngresar;
        private TextBox txtInput;
        private Label lblNumbers;
        private Button btnClearList;
        private ComboBox cmbOrderType;
    }
}
