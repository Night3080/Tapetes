/*
 * Created by SharpDevelop.
 * User: CC2-PC04
 * Date: 14/11/2024
 * Time: 02:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calcular_precio_de_tapete
{
	partial class Calcular
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtlargo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtancho = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtpintura = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtagua = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtbultos = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtalfombristas = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtfrutos = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtflores = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtdiseño = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Snow;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inserte los datos solicitados";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(13, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Largo en metros:";
			// 
			// txtlargo
			// 
			this.txtlargo.Location = new System.Drawing.Point(119, 33);
			this.txtlargo.Name = "txtlargo";
			this.txtlargo.Size = new System.Drawing.Size(100, 20);
			this.txtlargo.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label3.Location = new System.Drawing.Point(12, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Bultos de aserrin:";
			// 
			// txtancho
			// 
			this.txtancho.Location = new System.Drawing.Point(119, 60);
			this.txtancho.Name = "txtancho";
			this.txtancho.Size = new System.Drawing.Size(100, 20);
			this.txtancho.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label4.Location = new System.Drawing.Point(12, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Litros de pintura:";
			// 
			// txtpintura
			// 
			this.txtpintura.Location = new System.Drawing.Point(119, 87);
			this.txtpintura.Name = "txtpintura";
			this.txtpintura.Size = new System.Drawing.Size(100, 20);
			this.txtpintura.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(12, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Kg de frutos secos:";
			// 
			// txtagua
			// 
			this.txtagua.Location = new System.Drawing.Point(119, 114);
			this.txtagua.Name = "txtagua";
			this.txtagua.Size = new System.Drawing.Size(100, 20);
			this.txtagua.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label6.Location = new System.Drawing.Point(12, 225);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Docenas de flores:";
			// 
			// txtbultos
			// 
			this.txtbultos.Location = new System.Drawing.Point(119, 141);
			this.txtbultos.Name = "txtbultos";
			this.txtbultos.Size = new System.Drawing.Size(100, 20);
			this.txtbultos.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label7.Location = new System.Drawing.Point(12, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(129, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Cantidad de alfombristas:";
			// 
			// txtalfombristas
			// 
			this.txtalfombristas.Location = new System.Drawing.Point(148, 168);
			this.txtalfombristas.Name = "txtalfombristas";
			this.txtalfombristas.Size = new System.Drawing.Size(100, 20);
			this.txtalfombristas.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label8.Location = new System.Drawing.Point(12, 117);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Litros de agua:";
			// 
			// txtfrutos
			// 
			this.txtfrutos.Location = new System.Drawing.Point(119, 195);
			this.txtfrutos.Name = "txtfrutos";
			this.txtfrutos.Size = new System.Drawing.Size(100, 20);
			this.txtfrutos.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label9.Location = new System.Drawing.Point(13, 251);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Horas de diseño:";
			// 
			// txtflores
			// 
			this.txtflores.Location = new System.Drawing.Point(119, 222);
			this.txtflores.Name = "txtflores";
			this.txtflores.Size = new System.Drawing.Size(100, 20);
			this.txtflores.TabIndex = 16;
			// 
			// btncalcular
			// 
			this.btncalcular.Location = new System.Drawing.Point(12, 290);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(75, 23);
			this.btncalcular.TabIndex = 17;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label10.Location = new System.Drawing.Point(12, 63);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Ancho en metros;";
			// 
			// txtdiseño
			// 
			this.txtdiseño.Location = new System.Drawing.Point(119, 248);
			this.txtdiseño.Name = "txtdiseño";
			this.txtdiseño.Size = new System.Drawing.Size(100, 20);
			this.txtdiseño.TabIndex = 19;
			// 
			// Calcular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SandyBrown;
			this.ClientSize = new System.Drawing.Size(284, 325);
			this.Controls.Add(this.txtdiseño);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtflores);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtfrutos);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtalfombristas);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtbultos);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtagua);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtpintura);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtancho);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtlargo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Calcular";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtdiseño;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.TextBox txtflores;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtfrutos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtalfombristas;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtbultos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtagua;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtpintura;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtancho;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtlargo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
