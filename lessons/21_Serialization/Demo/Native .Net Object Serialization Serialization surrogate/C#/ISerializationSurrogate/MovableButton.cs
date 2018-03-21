using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Drawing.Drawing2D;

namespace ISerializationSurrogate
{
    /// <summary>
    /// It is Used to set Design Mode value
    /// </summary>
    public enum DesignMode
    {
        Design,
        Runtime
    }


    /// <summary>
    /// Created by Ryan
    /// For set the TableMode in the table
    /// </summary>
    public enum TableMode
    {
        Snooker,
        Pool,
        Mahjong,
        Dining,
        Nothing,
        Karaok
    }


    [Serializable()]
    [System.Drawing.ToolboxBitmap(typeof(PictureBox))]
    public class MovableButton : System.Windows.Forms.Button
    {
        public event EventHandler Selected;
        public new event EventHandler DoubleClick;

        /// <summary>
        /// It renew the Name property to set automatically the Text property
        /// </summary>
        public new string Name
        {
            get { return base.Name; }
            set
            {
                base.Text = value;
                base.Name = value;
            }
        }

        /// <summary>
        /// It represents whether the table is selected or not
        /// </summary>
        private bool? m_IsSelected = false;
        public bool? IsSelected
        {
            get { return m_IsSelected; }
            set { m_IsSelected = value; }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MovableButton()
        {
            this.Width = 100;
            this.Height = 45;

            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text = string.Empty;
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = System.Drawing.Image.FromFile("SnookerTable.png");

        }

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="tableMode"></param>
        public MovableButton(TableMode tableMode)
            : this()
        {
            TableMode = tableMode;
        }

        /// <summary>
        /// It measures the padding
        /// </summary>
        private UInt16 m_Deduct = 30;
        public UInt16 Deduct
        {
            get { return m_Deduct; }
            set { m_Deduct = value; }
        }

        /// <summary>
        /// Created by Ryan
        /// Get and Set the TableMode property
        /// </summary>
        private TableMode m_TableMode;
        public TableMode TableMode
        {
            get { return m_TableMode; }
            set { m_TableMode = value; }
        }



        /// <summary>
        /// Movable Button's Mode
        /// </summary>
        private DesignMode m_Mode = ISerializationSurrogate.DesignMode.Design;
        public DesignMode Mode
        {
            get { return m_Mode; }
            set { m_Mode = value; }
        }



        /// <summary>
        /// Overrides the OnClick Event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            if (IsSelected == null)
            {
                IsSelected = false;
                return;
            }
            if (Selected != null)
                Selected(this, e);

            if (Mode == ISerializationSurrogate.DesignMode.Design)
                return;

            base.OnClick(e);
        }

        /// <summary>
        /// Overrides the OnMouseDown Event
        /// </summary>
        /// <param name="mevent"></param>
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (Mode != ISerializationSurrogate.DesignMode.Design)
            {
                if (IsSelected == null)
                    IsSelected = false;

                if (mevent.Button == System.Windows.Forms.MouseButtons.Middle)
                {
                    OnClick(mevent);
                }
                else if (mevent.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    IsSelected = false;
                    OnClick(mevent);
                }
                else
                {
                    if (mevent.Clicks > 1)
                    {
                        if (DoubleClick != null)
                            DoubleClick(this, mevent);
                    }
                    else if (mevent.Clicks == 1 && !IsSelected.Value)
                        IsSelected = true;
                }
            }

            base.OnMouseDown(mevent);
        }

        /// <summary>
        /// Overrides the OnMouseMove Event
        /// </summary>
        /// <param name="mevent"></param>
        protected override void OnMouseMove(MouseEventArgs mevent)
        {

            if (Mode == ISerializationSurrogate.DesignMode.Runtime)
                return;

            if (mevent.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = (Left + mevent.X) - (Width / 2);
                this.Top = (Top + mevent.Y) - (Height / 2);
            }

            SetLocation();

            base.OnMouseMove(mevent);

        }

        /// <summary>
        /// It Set's the Object Location
        /// </summary>
        private void SetLocation()
        {
            if (this.Left <= 1)
                this.Left = 1;
            if (this.Top <= 1)
                this.Top = 5;
            if ((this.Top + this.Height) > (Parent.Height - this.Height))
                this.Top = (Parent.Height - this.Height - Deduct);

            if ((this.Left + this.Width) > (Parent.Width))
                this.Left = (Parent.Width - this.Width - 7);
        }


        /// <summary>
        /// It makes the button as circle button
        /// </summary>
        public void MakeCircle()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width - 2, this.Height - 2);

            this.Region = new System.Drawing.Region(path);
        }

        /// <summary>
        /// It initialize the movable button's component
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MovableButton
            // 
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResumeLayout(false);

            this.TextAlign = System.Drawing.ContentAlignment.TopCenter;


        }






    }


}
