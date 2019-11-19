using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace RatingApp
{
    class AppController : Control
    {
        #region Protected Data
        protected int leftMargin = 0;
		protected int rightMargin = 0;
		protected int topMargin = 0;
		protected int bottomMargin = 0;
		protected int starSpacing = 8;
		protected int starCount = 5;
		protected Rectangle[] starAreas;
		protected bool hovering = false;

		protected int hoverStar = 0;
		protected int selectedStar = 0;

		protected Color outlineColor = Color.DarkGray;
		protected Color hoverColor = Color.Yellow;
		protected Color selectedColor = Color.DarkGreen;

		protected int outlineThickness = 1;
		#endregion

		public AppData appData = new AppData();
		public string path = @"Data.txt";

		public AppController()
        {
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, true);

			Height = 31;
			Width = Height * 5 + StarSpacing * 4;

			starAreas = new Rectangle[StarCount];
		}

        #region Properties
        public int LeftMargin
		{
			get
			{
				return leftMargin;
			}
			set
			{
				if (leftMargin != value)
				{
					leftMargin = value;
					Invalidate();
				}
			}
		}

		public int RightMargin
		{
			get
			{
				return rightMargin;
			}
			set
			{
				if (rightMargin != value)
				{
					rightMargin = value;
					Invalidate();
				}
			}
		}

		public int TopMargin
		{
			get
			{
				return topMargin;
			}
			set
			{
				if (topMargin != value)
				{
					topMargin = value;
					Invalidate();
				}
			}
		}

		public int BottomMargin
		{
			get
			{
				return bottomMargin;
			}
			set
			{
				if (bottomMargin != value)
				{
					bottomMargin = value;
					Invalidate();
				}
			}
		}

		public int StarSpacing
		{
			get
			{
				return starSpacing;
			}
			set
			{
				if (starSpacing != value)
				{
					starSpacing = value;
					Invalidate();
				}
			}
		}

		public int StarCount
		{
			get
			{
				return starCount;
			}
			set
			{
				if (starCount != value)
				{
					starCount = value;
					starAreas = new Rectangle[starCount];
					Invalidate();
				}
			}
		}

		public bool IsHovering
		{
			get
			{
				return hovering;
			}
		}

		public Color OutlineColor
		{
			get
			{
				return outlineColor;
			}
			set
			{
				if (outlineColor != value)
				{
					outlineColor = value;
					Invalidate();
				}
			}
		}

		public Color HoverColor
		{
			get
			{
				return hoverColor;
			}
			set
			{
				if (hoverColor != value)
				{
					hoverColor = value;
					Invalidate();
				}
			}
		}

		public Color SelectedColor
		{
			get
			{
				return selectedColor;
			}
			set
			{
				if (selectedColor != value)
				{
					selectedColor = value;
					Invalidate();
				}
			}
		}

		public int OutlineThickness
		{
			get
			{
				return outlineThickness;
			}
			set
			{
				if (outlineThickness != value)
				{
					outlineThickness = value;
					Invalidate();
				}
			}
		}

		public int HoverStar
		{
			get
			{
				return hoverStar;
			}
		}

		public int SelectedStar
		{
			get
			{
				return selectedStar;
			}
			set
			{
				if (selectedStar != value)
				{
					selectedStar = value;
					Invalidate();
				}
			}
		}
		#endregion

		#region Method
		protected override void OnPaint(PaintEventArgs pe)
		{
			pe.Graphics.Clear(BackColor);

			int starWidth = (Width - (LeftMargin + RightMargin + (StarSpacing * (StarCount - 1)))) / StarCount;
			int starHeight = (Height - (TopMargin + BottomMargin));

			Rectangle drawArea = new Rectangle(LeftMargin, TopMargin, starWidth, starHeight);

			for (int i = 0; i < StarCount; ++i)
			{
				starAreas[i].X = drawArea.X - StarSpacing / 2;
				starAreas[i].Y = drawArea.Y;
				starAreas[i].Width = drawArea.Width + StarSpacing / 2;
				starAreas[i].Height = drawArea.Height;

				DrawStar(pe.Graphics, drawArea, i);

				drawArea.X += drawArea.Width + StarSpacing;
			}

			base.OnPaint(pe);
		}

		protected void DrawStar(Graphics g, Rectangle rect, int starAreaIndex)
		{
			Brush fillBrush;
			Pen outlinePen = new Pen(OutlineColor, OutlineThickness);

			if (hovering && hoverStar > starAreaIndex)
			{
				fillBrush = new LinearGradientBrush(rect, HoverColor, BackColor, LinearGradientMode.ForwardDiagonal);
			}
			else if ((!hovering) && selectedStar > starAreaIndex)
			{
				fillBrush = new LinearGradientBrush(rect, SelectedColor, BackColor, LinearGradientMode.ForwardDiagonal);
			}
			else
			{
				fillBrush = new SolidBrush(BackColor);
			}

			PointF[] p = new PointF[10];
			p[0].X = rect.X + (rect.Width / 2); p[0].Y = rect.Y;
			p[1].X = rect.X + (42 * rect.Width / 64); p[1].Y = rect.Y + (19 * rect.Height / 64);
			p[2].X = rect.X + rect.Width; p[2].Y = rect.Y + (22 * rect.Height / 64);
			p[3].X = rect.X + (48 * rect.Width / 64); p[3].Y = rect.Y + (38 * rect.Height / 64);
			p[4].X = rect.X + (52 * rect.Width / 64); p[4].Y = rect.Y + rect.Height;
			p[5].X = rect.X + (rect.Width / 2); p[5].Y = rect.Y + (52 * rect.Height / 64);
			p[6].X = rect.X + (12 * rect.Width / 64); p[6].Y = rect.Y + rect.Height;
			p[7].X = rect.X + rect.Width / 4; p[7].Y = rect.Y + (38 * rect.Height / 64);
			p[8].X = rect.X; p[8].Y = rect.Y + (22 * rect.Height / 64);
			p[9].X = rect.X + (22 * rect.Width / 64); p[9].Y = rect.Y + (19 * rect.Height / 64);

			g.FillPolygon(fillBrush, p);
			g.DrawPolygon(outlinePen, p);
		}

		protected override void OnMouseEnter(System.EventArgs ea)
		{
			hovering = true;
			Invalidate();
			base.OnMouseEnter(ea);
		}

		protected override void OnMouseLeave(System.EventArgs ea)
		{
			hovering = false;
			Invalidate();
			base.OnMouseLeave(ea);
		}

		protected override void OnMouseMove(MouseEventArgs args)
		{
			for (int i = 0; i < StarCount; ++i)
			{
				if (starAreas[i].Contains(args.X, args.Y))
				{
					hoverStar = i + 1;
					Invalidate();
					break;
				}
			}

			base.OnMouseMove(args);
		}

		protected override void OnClick(System.EventArgs args)
		{
			Point p = PointToClient(MousePosition);

			for (int i = 0; i < StarCount; ++i)
			{
				if (starAreas[i].Contains(p))
				{
					hoverStar = i + 1;
					selectedStar = i + 1;

					appData.TotalVote = appData.TotalVote + 1;
					switch (selectedStar)
					{
						case 1:
							appData.OneStarVote = appData.OneStarVote + 1;
							break;
						case 2:
							appData.TwoStarVote = appData.TwoStarVote + 1;
							break;
						case 3:
							appData.ThreeStarVote = appData.ThreeStarVote + 1;
							break;
						case 4:
							appData.FourStarVote = appData.FourStarVote + 1;
							break;
						case 5:
							appData.FiveStarVote = appData.FiveStarVote + 1;
							break;
					}
					Invalidate();
					Program.MainForm.UpdateData();
					SaveData();
					break;
				}
			}

			base.OnClick(args);
		}

		public void SaveData()
		{
			// Create a file to write to.
			using (StreamWriter sw = File.CreateText(path))
			{
				sw.WriteLine("TotalVote:" + appData.TotalVote);
				sw.WriteLine("FiveStar:" + appData.FiveStarVote);
				sw.WriteLine("FourStar:" + appData.FourStarVote);
				sw.WriteLine("ThreeStar:" + appData.ThreeStarVote);
				sw.WriteLine("TwoStar:" + appData.TwoStarVote);
				sw.WriteLine("OneStar:" + appData.OneStarVote);
				sw.Close();
			}
		}

		public void ReadData()
		{
			string[] lines = File.ReadAllLines(path);
			foreach (string line in lines)
			{
				string[] s = line.Split(':');
				switch (s[0])
				{
					case "TotalVote":
						appData.TotalVote = Int32.Parse(s[1]);
						break;
					case "FiveStar":
						appData.FiveStarVote = Int32.Parse(s[1]);
						break;
					case "FourStar":
						appData.FourStarVote = Int32.Parse(s[1]);
						break;
					case "ThreeStar":
						appData.ThreeStarVote = Int32.Parse(s[1]);
						break;
					case "TwoStar":
						appData.TwoStarVote = Int32.Parse(s[1]);
						break;
					case "OneStar":
						appData.OneStarVote = Int32.Parse(s[1]);
						break;
				}
			}
		}
		#endregion
	}
}
