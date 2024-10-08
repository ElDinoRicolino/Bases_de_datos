using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Base_Datos_II
{
	public class RoundedMaterialButton : MaterialButton
	{
		public int BorderRadius { get; set; } = 5;

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			GraphicsPath path = new GraphicsPath();
			path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
			path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
			path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
			path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
			path.CloseAllFigures();

			e.Graphics.SetClip(path);
			e.Graphics.FillPath(new SolidBrush(BackColor), path);
		}
	}
}
