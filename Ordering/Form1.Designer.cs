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
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewSteps
            // 
            listViewSteps.FullRowSelect = true;
            listViewSteps.GridLines = true;
            listViewSteps.Location = new Point(346, 12);
            listViewSteps.Name = "listViewSteps";
            listViewSteps.Size = new Size(657, 321);
            listViewSteps.TabIndex = 0;
            listViewSteps.UseCompatibleStateImageBehavior = false;
            listViewSteps.View = View.Details;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Location = new Point(242, 83);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(75, 23);
            btnMergeSort.TabIndex = 1;
            btnMergeSort.Text = "Merge";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // btnMezclaNatural
            // 
            btnMezclaNatural.Location = new Point(242, 163);
            btnMezclaNatural.Name = "btnMezclaNatural";
            btnMezclaNatural.Size = new Size(75, 23);
            btnMezclaNatural.TabIndex = 2;
            btnMezclaNatural.Text = "Natural";
            btnMezclaNatural.UseVisualStyleBackColor = true;
            btnMezclaNatural.Click += btnMezclaNatural_Click;
            // 
            // btnMezclaDirecta
            // 
            btnMezclaDirecta.Location = new Point(242, 122);
            btnMezclaDirecta.Name = "btnMezclaDirecta";
            btnMezclaDirecta.Size = new Size(75, 23);
            btnMezclaDirecta.TabIndex = 3;
            btnMezclaDirecta.Text = "Directa";
            btnMezclaDirecta.UseVisualStyleBackColor = true;
            btnMezclaDirecta.Click += btnMezclaDirecta_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(242, 33);
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
            txtInput.Size = new Size(168, 23);
            txtInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 450);
            Controls.Add(label1);
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
        private Label label1;
    }
}
