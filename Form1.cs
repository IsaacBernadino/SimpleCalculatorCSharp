using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class mainWindow : Form
    {
		// String para armazenar o que o usuario digitar
		public string userNum;

		// Numeros que recebem os valores digitados depois de convertido
		private float fNum;
		private float fNum2;

		// 
		private int maxSignalToCalc = 1;
		private bool plusCalc = false;
		private bool minusCalc = false;
		private bool versusCalc = false;
		private bool divCalc = false;


		public mainWindow()
        {
            InitializeComponent();
        }

		private void numberAlpha1_Click(object sender, EventArgs e)
		{
			userNum += "1";
			calcs.Text += "1";
		}

		private void buttonAlpha2_Click(object sender, EventArgs e)
		{
			userNum += "2";
			calcs.Text += "2";
		}

		private void buttonAlpha3_Click(object sender, EventArgs e)
		{
			userNum += "3";
			calcs.Text += "3";
		}

		private void buttonAlpha4_Click(object sender, EventArgs e)
		{
			userNum += "4";
			calcs.Text += "4";
		}

		private void buttonAlpha5_Click(object sender, EventArgs e)
		{
			userNum += "5";
			calcs.Text += "5";
		}

		private void buttonAlpha6_Click(object sender, EventArgs e)
		{
			userNum += "6";
			calcs.Text += "6";
		}

		private void buttonAlpha7_Click(object sender, EventArgs e)
		{
			userNum += "7";
			calcs.Text += "7";
		}

		private void buttonAlpha8_Click(object sender, EventArgs e)
		{
			userNum += "8";
			calcs.Text += "8";
		}

		private void buttonAlpha9_Click(object sender, EventArgs e)
		{
			userNum += "9";
			calcs.Text += "9";
		}

		private void buttonAlpha0_Click(object sender, EventArgs e)
		{
			userNum += "0";
			calcs.Text += "0";
		}

		private void iguals_Click(object sender, EventArgs e)
		{
			if(userNum != null)
			{
				fNum2 = ConvertToFloat(userNum);

				if (plusCalc)
				{
					res.Text = (fNum + fNum2).ToString();
					plusCalc = false;
				}

				if (minusCalc)
				{
					res.Text = (fNum - fNum2).ToString();
					minusCalc = false;
				}

				if (divCalc)
				{
					res.Text = (fNum / fNum2).ToString();
					divCalc = false;
				}

				if (versusCalc)
				{
					res.Text = (fNum * fNum2).ToString();
					versusCalc = false;
				}

				calcs.Text = "";
				userNum = "0";


				fNum = 0;
				fNum2 = 0;
			}
			maxSignalToCalc = 1;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Na inicialização
			res.Text = "       ";
		}

		private void res_Click(object sender, EventArgs e)
		{
			res.Text = "       ";
		}

		private void calcs_Click(object sender, EventArgs e)
		{
			calcs.Text = "";
			userNum = "0";
		}

		private void plus_Click(object sender, EventArgs e)
		{
			if (maxSignalToCalc > 0)
			{
				if (userNum != null)
				{
					plusCalc = true;
					fNum = ConvertToFloat(userNum);
					userNum = "0";
					calcs.Text += " + ";

					maxSignalToCalc = 0;
				}
			}
		}
		private void minus_Click(object sender, EventArgs e)
		{
			if (maxSignalToCalc > 0)
			{
				if (userNum != null)
				{
					minusCalc = true;
					fNum = ConvertToFloat(userNum);
					userNum = "0";
					calcs.Text += " - ";

					maxSignalToCalc = 0;
				}
			}
		}
		private void div_Click(object sender, EventArgs e)
		{
			if (maxSignalToCalc > 0)
			{
				if (userNum != null)
				{
					divCalc = true;
					fNum = ConvertToFloat(userNum);
					userNum = "0";
					calcs.Text += " / ";

					maxSignalToCalc = 0;
				}
			}
		}
		private void versus_Click(object sender, EventArgs e)
		{
			if (maxSignalToCalc > 0)
			{
				if (userNum != null)
				{
					versusCalc = true;
					fNum = ConvertToFloat(userNum);
					userNum = "0";
					calcs.Text += " x ";

					maxSignalToCalc = 0;
				}
			}
		}

		private void title_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Função que retorna a conversão de uma string em float
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private float ConvertToFloat (string value)
		{
			return Convert.ToSingle(value);
		}

	}
}
