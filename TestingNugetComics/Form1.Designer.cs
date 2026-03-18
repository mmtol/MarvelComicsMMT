namespace TestingNugetComics
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
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            lnkApi = new LinkLabel();
            lstComics = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(12, 41);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(129, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 83);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lnkApi
            // 
            lnkApi.AutoSize = true;
            lnkApi.Location = new Point(159, 9);
            lnkApi.Name = "lnkApi";
            lnkApi.Size = new Size(386, 15);
            lnkApi.TabIndex = 3;
            lnkApi.TabStop = true;
            lnkApi.Text = "https://marvel.emreparker.com/v1/search/issues?q=secret+wars&limit=5";
            // 
            // lstComics
            // 
            lstComics.FormattingEnabled = true;
            lstComics.Location = new Point(159, 41);
            lstComics.Name = "lstComics";
            lstComics.Size = new Size(529, 364);
            lstComics.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 429);
            Controls.Add(lstComics);
            Controls.Add(lnkApi);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private LinkLabel lnkApi;
        private ListBox lstComics;
    }
}
