
namespace formCrudProject
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
            this.INPUTNOM = new System.Windows.Forms.TextBox();
            this.INPUTPRENOM = new System.Windows.Forms.TextBox();
            this.INPUTADRESSE = new System.Windows.Forms.TextBox();
            this.INPUTID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.INPUTVILLE = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // INPUTNOM
            // 
            this.INPUTNOM.Location = new System.Drawing.Point(307, 113);
            this.INPUTNOM.Name = "INPUTNOM";
            this.INPUTNOM.Size = new System.Drawing.Size(238, 22);
            this.INPUTNOM.TabIndex = 9;
            // 
            // INPUTPRENOM
            // 
            this.INPUTPRENOM.Location = new System.Drawing.Point(307, 155);
            this.INPUTPRENOM.Name = "INPUTPRENOM";
            this.INPUTPRENOM.Size = new System.Drawing.Size(238, 22);
            this.INPUTPRENOM.TabIndex = 11;
            // 
            // INPUTADRESSE
            // 
            this.INPUTADRESSE.Location = new System.Drawing.Point(307, 197);
            this.INPUTADRESSE.Name = "INPUTADRESSE";
            this.INPUTADRESSE.Size = new System.Drawing.Size(238, 22);
            this.INPUTADRESSE.TabIndex = 13;
            // 
            // INPUTID
            // 
            this.INPUTID.Location = new System.Drawing.Point(307, 71);
            this.INPUTID.Name = "INPUTID";
            this.INPUTID.Size = new System.Drawing.Size(238, 22);
            this.INPUTID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "ADRESSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "PRENOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nebtn);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(655, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crud Box";
            // 
            // nebtn
            // 
            this.nebtn.Location = new System.Drawing.Point(147, 83);
            this.nebtn.Name = "nebtn";
            this.nebtn.Size = new System.Drawing.Size(72, 40);
            this.nebtn.TabIndex = 5;
            this.nebtn.Text = "neveau";
            this.nebtn.UseVisualStyleBackColor = true;
            this.nebtn.Click += new System.EventHandler(this.nebtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "modifier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_modifier);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "suprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_supression);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Add);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "MTJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_showData);
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowDrop = true;
            this.dgvPerson.AllowUserToOrderColumns = true;
            this.dgvPerson.AllowUserToResizeRows = false;
            this.dgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerson.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.prénom,
            this.adress,
            this.VILLE});
            this.dgvPerson.Location = new System.Drawing.Point(179, 304);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowHeadersWidth = 51;
            this.dgvPerson.RowTemplate.Height = 24;
            this.dgvPerson.Size = new System.Drawing.Size(721, 144);
            this.dgvPerson.TabIndex = 7;
            this.dgvPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellContentClick);
            this.dgvPerson.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPerson_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // nom
            // 
            this.nom.HeaderText = "NOM";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            // 
            // prénom
            // 
            this.prénom.HeaderText = "PRENOM";
            this.prénom.MinimumWidth = 6;
            this.prénom.Name = "prénom";
            // 
            // adress
            // 
            this.adress.HeaderText = "ADRESSE";
            this.adress.MinimumWidth = 6;
            this.adress.Name = "adress";
            // 
            // VILLE
            // 
            this.VILLE.HeaderText = "VILLE";
            this.VILLE.MinimumWidth = 6;
            this.VILLE.Name = "VILLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "VILLE";
            // 
            // INPUTVILLE
            // 
            this.INPUTVILLE.Location = new System.Drawing.Point(307, 241);
            this.INPUTVILLE.Name = "INPUTVILLE";
            this.INPUTVILLE.Size = new System.Drawing.Size(238, 22);
            this.INPUTVILLE.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 513);
            this.Controls.Add(this.INPUTVILLE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.INPUTNOM);
            this.Controls.Add(this.INPUTPRENOM);
            this.Controls.Add(this.INPUTADRESSE);
            this.Controls.Add(this.INPUTID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox INPUTNOM;
        private System.Windows.Forms.TextBox INPUTPRENOM;
        private System.Windows.Forms.TextBox INPUTADRESSE;
        private System.Windows.Forms.TextBox INPUTID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nebtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox INPUTVILLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLE;
    }
}

