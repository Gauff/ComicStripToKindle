using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ComicStripToKindle.Controls
{
    public partial class CollapsibleControl : UserControl
    {

        /*
         * Basically you add this control onto your form, then attach a panel which should contain all of your subcontrols. 
         * Then you assign the Panel control to it like this:

            this.collapsibleControl1.LowerPanel = this.panel1;

            This was just for some small personal project, so it is not tested a lot and might contain some problems. 
            But it should get your started.*/


        #region Declarations

        /// <summary>
        /// Declarations.
        /// </summary>
        private Control m_LowerPanel;
        private int FixedHeight = 100;
        private int CollapsibleIntervalValue = 5;
        private int HeaderHeightValue = 20;

        public delegate void CollapsedStateChangedEventHanlder(object sender, ControlState controlState);
        public event CollapsedStateChangedEventHanlder CollapsedStateChanged;

        public enum ControlState { Collapsed, Expanded }

        private ControlState _controlCollaspedState = ControlState.Expanded;

        #endregion

        #region Initialize

        public CollapsibleControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Collapsible properties

        [Description("The collasped state of the control, collasped or expanded"),
            Category("Collapsible Control"),
            DefaultValueAttribute(ControlState.Expanded)]
        public ControlState ControlCollaspedState
        {
            get => _controlCollaspedState;
            set
            {
                _controlCollaspedState = value;
                DoCollapsible();
            }
        }

        [Description("The text to show at the top of the control"),
            Category("Collapsible Control")]
        public String DisplayText
        {
            get { return this.lblTop.Text; }
            set { this.lblTop.Text = value; }
        }

        [Description("The background color of the text box"),
            Category("Collapsible Control"),
            DefaultValue(typeof(Color), "Window")]
        public Color TextBackgroundColor
        {
            get { return this.lblTop.BackColor; }
            set { this.lblTop.BackColor = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("The panel which will be minimized"),
            Category("Collapsible Control")]
        public Control LowerPanel
        {
            get
            {
                return this.m_LowerPanel;
            }
            set
            {
                this.m_LowerPanel = value;
            }
        }

        public Image Image
        {
            get
            {
                return picture.Image;
            }
            set
            {
                picture.Image = value;
            }
        }

        /// <summary>
        /// Gets/Sets CollapsibleInterval
        /// </summary>
        [Description("The interval determining how long it takes to open and close"),
            Category("Collapsible Control"),
            DefaultValueAttribute(2)]
        public int CollapsibleInterval
        {
            get
            {
                return this.CollapsibleIntervalValue;
            }
            set
            {
                this.CollapsibleIntervalValue = value;
            }
        }

        /// <summary>
        /// setting values for Header height
        /// </summary>
        [Description("The height of the header"),
            Category("Collapsible Control"),
            DefaultValueAttribute(20)]
        public int HeaderHeight
        {
            get
            {
                return this.HeaderHeightValue;
            }
            set
            {
                this.HeaderHeightValue = value;
                this.lblTop.Height = this.HeaderHeightValue;
            }
        }
        #endregion

        /// <summary>
        /// Method for Collapsible animation.
        /// </summary>
        private void DoCollapsible()
        {
            if (this.m_LowerPanel == null || this.lblTop == null)
                return;

            //if expanded
            if (this.m_LowerPanel.Height > this.lblTop.Height)
            {
                FixedHeight = this.m_LowerPanel.Height;

                while (this.m_LowerPanel.Height > this.lblTop.Height)
                {
                    Application.DoEvents();
                    this.m_LowerPanel.Height -= CollapsibleIntervalValue;
                }
                this.lblTop.ImageIndex = 1;
                this.m_LowerPanel.Height = 0;
                //this.ControlCollaspedState = ControlState.Collapsed;
                _controlCollaspedState = ControlState.Collapsed;
            }
            else if (this.m_LowerPanel.Height < this.lblTop.Height)  //if collapsed
            {
                int x = this.FixedHeight;
                while (this.m_LowerPanel.Height <= (x))
                {
                    Application.DoEvents();
                    this.m_LowerPanel.Height += CollapsibleIntervalValue;
                }
                this.lblTop.ImageIndex = 0;
                this.m_LowerPanel.Height = x;
                //this.ControlCollaspedState = ControlState.Expanded;
                _controlCollaspedState = ControlState.Expanded;
            }


            CollapsedStateChanged?.Invoke(this, this.ControlCollaspedState);
        }

        /// <summary>
        /// CollapsiblePanel usercontrol load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapsibleControl_Load(object sender, EventArgs e)
        {
            this.FixedHeight = this.Height;
            this.lblTop.Height = this.HeaderHeightValue;
        }



        /// <summary>
        /// setting values to label width when resizing the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapsibleControl_Resize(object sender, EventArgs e)
        {
            this.lblTop.Width = this.Width;
            picture.Location = new Point(lblTop.Width - 40, picture.Location.Y);
            panel.Size = new Size(Width, ((CollapsibleControl)sender).Height - lblTop.Height);
        }

        /// <summary>
        /// click event for Collapsible image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTop_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            DoCollapsible();
        }
    }
}