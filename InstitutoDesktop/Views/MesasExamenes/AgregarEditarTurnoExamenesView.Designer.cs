﻿namespace InstitutoDesktop.Views.MesasExamenes
{
    partial class AgregarEditarTurnoExamenesView
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
            txtNombre = new TextBox();
            label1 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            chkActual = new CheckBox();
            chkInscripcionHabilitada = new CheckBox();
            cbmBoxCicloLectivo = new ComboBox();
            label2 = new Label();
            chkSegundoLlamado = new CheckBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);

            txtNombre.Location = new Point(376, 113);

            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 32);
            txtNombre.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);

            label1.Location = new Point(239, 113);

            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 15;
            label1.Text = "Nombre :";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(481, 403);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 40);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnGuardar.IconSize = 30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(312, 403);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 40);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkActual
            // 



            chkActual.AutoSize = true;
            chkActual.Location = new Point(535, 245);
            chkActual.Name = "chkActual";
            chkActual.Size = new Size(73, 24);
            chkActual.TabIndex = 17;
            chkActual.Text = "Actual";
            chkActual.UseVisualStyleBackColor = true;
            // 
            // chkInscripcionHabilitada
            // 
            chkInscripcionHabilitada.AutoSize = true;
            chkInscripcionHabilitada.Location = new Point(264, 245);
            chkInscripcionHabilitada.Name = "chkInscripcionHabilitada";
            chkInscripcionHabilitada.Size = new Size(183, 24);
            chkInscripcionHabilitada.TabIndex = 18;
            chkInscripcionHabilitada.Text = "Inscripccion Habilitada";
            chkInscripcionHabilitada.UseVisualStyleBackColor = true;
            // 
            // cbmBoxCicloLectivo
            // 
            cbmBoxCicloLectivo.FormattingEnabled = true;
            cbmBoxCicloLectivo.Location = new Point(376, 189);
            cbmBoxCicloLectivo.Name = "cbmBoxCicloLectivo";
            cbmBoxCicloLectivo.Size = new Size(257, 28);
            cbmBoxCicloLectivo.TabIndex = 19;
            //cbmBoxCicloLectivo.SelectedIndexChanged += cbmBoxCicloLectivo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(202, 192);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 20;
            label2.Text = "Ciclo Lectivo :";
            // 
            // chkSegundoLlamado
            // 
            chkSegundoLlamado.AutoSize = true;
            chkSegundoLlamado.Location = new Point(358, 300);
            chkSegundoLlamado.Name = "chkSegundoLlamado";
            chkSegundoLlamado.Size = new Size(192, 24);
            chkSegundoLlamado.TabIndex = 21;
            chkSegundoLlamado.Text = "Tiene Segundo Llamado";
            chkSegundoLlamado.UseVisualStyleBackColor = true;

            // 
            // AgregarEditarTurnoExamenesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(chkSegundoLlamado);
            Controls.Add(label2);
            Controls.Add(cbmBoxCicloLectivo);
            Controls.Add(chkInscripcionHabilitada);
            Controls.Add(chkActual);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarEditarTurnoExamenesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarTurnoExamenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private CheckBox chkActual;
        private CheckBox chkInscripcionHabilitada;
        private ComboBox cbmBoxCicloLectivo;
        private Label label2;
        private CheckBox chkSegundoLlamado;
    }
}