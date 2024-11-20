/*
 * Created by SharpDevelop.
 * User: CC2-PC04
 * Date: 14/11/2024
 * Time: 02:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calcular_precio_de_tapete
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Calcular : Form
	{
		public Calcular()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			int preaserrin = 750;
			int prepintura = 280;
			int prefrutos = 235;
			int preflores = 85;
			int preagua = 2;
			int tiempo = 7;
			int area;
			int cosdiseñador = 55;
			int comida = 35;
			int total;
			int totaltiempo;
			int obra;
			string cbultos = txtbultos.Text;
			int bultos = Int32.Parse(cbultos);
			string cpintura = txtpintura.Text;
			int pintura = Int32.Parse(cpintura);
			string cfrutos = txtfrutos.Text;
			int frutos = Int32.Parse(cfrutos);
			string cflores = txtflores.Text;
			int flores = Int32.Parse(cflores);
			string cnagua = txtagua.Text;
			int agua = Int32.Parse(cnagua);
			string ctiempo = txtdiseño.Text;
			int diseño = Int32.Parse(ctiempo);
			string largo = txtlargo.Text;
			int lm = Int32.Parse(largo);
			string ancho = txtancho.Text;
			int am = Int32.Parse(ancho);
			string mano = txtalfombristas.Text;
			int mo = Int32.Parse(mano);
			area = lm * am;
			totaltiempo = (area/10)*tiempo;
			obra = mo*totaltiempo;
			int cc = mo*comida;
			total = cc + obra;
			total = total +(preaserrin * bultos);
			total = total +(prepintura * pintura);
			total = total +(prefrutos * frutos);
			total = total +(preflores * flores);
			total = total +(preagua * agua);
			total = total +(cosdiseñador * diseño);
			MessageBox.Show("El costo aproximado del tapete es de: " + total);
		}
	}
}
