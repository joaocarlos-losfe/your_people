namespace Agenda_telefonica
{
    partial class frm_home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.label1 = new System.Windows.Forms.Label();
            this.lvw_pessoas = new System.Windows.Forms.ListView();
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_whatsapp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_adiconar = new System.Windows.Forms.Button();
            this.btn_exluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your people";
            // 
            // lvw_pessoas
            // 
            this.lvw_pessoas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvw_pessoas.BackColor = System.Drawing.Color.White;
            this.lvw_pessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvw_pessoas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nome,
            this.col_whatsapp,
            this.col_email});
            this.lvw_pessoas.ForeColor = System.Drawing.Color.DimGray;
            this.lvw_pessoas.HideSelection = false;
            this.lvw_pessoas.LabelEdit = true;
            this.lvw_pessoas.LabelWrap = false;
            this.lvw_pessoas.Location = new System.Drawing.Point(12, 61);
            this.lvw_pessoas.MultiSelect = false;
            this.lvw_pessoas.Name = "lvw_pessoas";
            this.lvw_pessoas.Size = new System.Drawing.Size(860, 388);
            this.lvw_pessoas.TabIndex = 1;
            this.lvw_pessoas.TileSize = new System.Drawing.Size(208, 50);
            this.lvw_pessoas.UseCompatibleStateImageBehavior = false;
            this.lvw_pessoas.View = System.Windows.Forms.View.Details;
            this.lvw_pessoas.SelectedIndexChanged += new System.EventHandler(this.lvw_pessoas_SelectedIndexChanged);
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 285;
            // 
            // col_whatsapp
            // 
            this.col_whatsapp.Text = "Whatsapp";
            this.col_whatsapp.Width = 280;
            // 
            // col_email
            // 
            this.col_email.Text = "Email";
            this.col_email.Width = 285;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(743, 14);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(25, 25);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Visible = false;
            // 
            // btn_adiconar
            // 
            this.btn_adiconar.BackColor = System.Drawing.Color.Transparent;
            this.btn_adiconar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adiconar.BackgroundImage")));
            this.btn_adiconar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_adiconar.FlatAppearance.BorderSize = 0;
            this.btn_adiconar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_adiconar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adiconar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adiconar.Location = new System.Drawing.Point(837, 14);
            this.btn_adiconar.Name = "btn_adiconar";
            this.btn_adiconar.Size = new System.Drawing.Size(25, 25);
            this.btn_adiconar.TabIndex = 2;
            this.btn_adiconar.UseVisualStyleBackColor = false;
            this.btn_adiconar.Click += new System.EventHandler(this.btn_adiconar_Click);
            // 
            // btn_exluir
            // 
            this.btn_exluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_exluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exluir.BackgroundImage")));
            this.btn_exluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exluir.FlatAppearance.BorderSize = 0;
            this.btn_exluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exluir.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exluir.Location = new System.Drawing.Point(790, 14);
            this.btn_exluir.Name = "btn_exluir";
            this.btn_exluir.Size = new System.Drawing.Size(25, 25);
            this.btn_exluir.TabIndex = 4;
            this.btn_exluir.UseVisualStyleBackColor = false;
            this.btn_exluir.Visible = false;
            this.btn_exluir.Click += new System.EventHandler(this.btn_exluir_Click);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btn_exluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_adiconar);
            this.Controls.Add(this.lvw_pessoas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_home";
            this.Text = "Your people";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvw_pessoas;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_whatsapp;
        private System.Windows.Forms.ColumnHeader col_email;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_adiconar;
        private System.Windows.Forms.Button btn_exluir;
    }
}

