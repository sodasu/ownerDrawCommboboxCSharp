using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OD_CMB
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		ArrayList colorArray = new ArrayList() ;
		ArrayList fontArray  = new ArrayList() ;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.ItemHeight = 25;
			this.comboBox1.Location = new System.Drawing.Point(16, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(264, 31);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Font Combo Box";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.ItemHeight = 20;
			this.comboBox2.Location = new System.Drawing.Point(16, 104);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(352, 26);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.comboBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox2_DrawItem);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "Color Combo Box";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 149);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.label1,
																		  this.comboBox1,
																		  this.comboBox2});
			this.Name = "Form1";
			this.Text = "OwnerDraw ComboBox";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{	
			colorArray.Add(new SolidBrush(Color.Red));
			colorArray.Add(new SolidBrush(Color.Blue));
			colorArray.Add(new SolidBrush(Color.Green));
			colorArray.Add(new SolidBrush(Color.Yellow));
			colorArray.Add(new SolidBrush(Color.Black));
			colorArray.Add(new SolidBrush(Color.Azure));
			colorArray.Add(new SolidBrush(Color.Firebrick));
			colorArray.Add(new SolidBrush(Color.DarkMagenta));
			colorArray.Add(new SolidBrush(Color.DarkTurquoise));
			colorArray.Add(new SolidBrush(Color.Khaki));

			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");
			comboBox2.Items.Add("");

		
			fontArray .Add(new Font("Ariel" , 15 , FontStyle.Bold ));
			fontArray .Add(new Font("Courier" , 12 , FontStyle.Italic));
			fontArray .Add(new Font("Veranda" , 14 , FontStyle.Bold));
			fontArray .Add(new Font("System" , 10 , FontStyle.Strikeout));
			fontArray .Add(new Font("Century SchoolBook" , 15 , FontStyle.Underline));
			fontArray .Add(new Font("Helevctia" , 14 , FontStyle.Italic));

			comboBox1.Items.Add("Chicago");
			comboBox1.Items.Add("New York");
			comboBox1.Items.Add("Washington");
			comboBox1.Items.Add("Houston");
			comboBox1.Items.Add("Phoenix");
			comboBox1.Items.Add("Dallas");
		}

		private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
			Graphics g = e.Graphics ;
			Rectangle r = e.Bounds ;
			Font fn = null ;
			if ( e.Index >= 0 ) 
			{
				fn = (Font)fontArray[e.Index];
				string s = (string)comboBox1.Items[e.Index];
				StringFormat sf = new StringFormat();
				sf.Alignment = StringAlignment.Near;

				Console.WriteLine(e.State.ToString());
				e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2 ), r );
				if ( e.State == ( DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
				{
					e.Graphics.FillRectangle(new SolidBrush(Color.White) , r);
					e.Graphics.DrawString( s , fn , new SolidBrush(Color.Black), r ,sf);
					e.DrawFocusRectangle();
				}
				else
				{
					e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue) , r);
					e.Graphics.DrawString( s , fn , new SolidBrush(Color.Red), r ,sf);
					e.DrawFocusRectangle();
				}
			}
		}

		private void comboBox2_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
			Graphics g = e.Graphics ;
		    Rectangle r = e.Bounds ;

			if ( e.Index >= 0 ) 
			{
				Rectangle rd = r ; 
				rd.Width = rd.Left + 100 ; 
				
				Rectangle rt = r ;
				r.X = rd.Right ; 

				SolidBrush b = (SolidBrush)colorArray[e.Index];
				g.FillRectangle(b  , rd);
				StringFormat sf = new StringFormat();
				sf.Alignment = StringAlignment.Near;

				Console.WriteLine(e.State.ToString());
				e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2 ), r );
				if ( e.State == ( DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
				{
					e.Graphics.FillRectangle(new SolidBrush(Color.White) , r);
					e.Graphics.DrawString( b.Color.Name, new Font("Ariel" , 8 , FontStyle.Bold  ) , new SolidBrush(Color.Black), r ,sf);
					e.DrawFocusRectangle();
				}
				else
				{
					e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue) , r);
					e.Graphics.DrawString( b.Color.Name, new Font("Veranda" , 12 , FontStyle.Bold  ) , new SolidBrush(Color.Red), r ,sf);
					e.DrawFocusRectangle();
				}
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
