/*
 * Created by SharpDevelop.
 * User: CC2-PC04
 * Date: 14/11/2024
 * Time: 02:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calcular_precio_de_tapete
{
	partial class MainForm
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
			this.btncomenzar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Snow;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btncomenzar
			// 
			this.btncomenzar.Location = new System.Drawing.Point(86, 72);
			this.btncomenzar.Name = "btncomenzar";
			this.btncomenzar.Size = new System.Drawing.Size(116, 31);
			this.btncomenzar.TabIndex = 1;
			this.btncomenzar.Text = "Comenzar";
			this.btncomenzar.UseVisualStyleBackColor = true;
			this.btncomenzar.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SandyBrown;
			this.ClientSize = new System.Drawing.Size(284, 115);
			this.Controls.Add(this.btncomenzar);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calcular precio de tapete";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btncomenzar;
		private System.Windows.Forms.Label label1;
	}
}
