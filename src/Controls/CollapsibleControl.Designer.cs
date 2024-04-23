namespace ComicStripToKindle.Controls
{
    partial class CollapsibleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollapsibleControl));
            this.lblTop = new System.Windows.Forms.Label();
            this.imageListScroll = new System.Windows.Forms.ImageList(this.components);
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTop.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTop.ImageIndex = 0;
            this.lblTop.ImageList = this.imageListScroll;
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(316, 20);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "label1";
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // imageListScroll
            // 
            this.imageListScroll.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListScroll.ImageStream")));
            this.imageListScroll.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListScroll.Images.SetKeyName(0, "icon_up.GIF");
            this.imageListScroll.Images.SetKeyName(1, "icon_down.GIF");
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(271, 2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(16, 16);
            this.picture.TabIndex = 49;
            this.picture.TabStop = false;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(4, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(310, 319);
            this.panel.TabIndex = 50;
            // 
            // CollapsibleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.lblTop);
            this.Name = "CollapsibleControl";
            this.Size = new System.Drawing.Size(317, 346);
            this.Load += new System.EventHandler(this.CollapsibleControl_Load);
            this.Resize += new System.EventHandler(this.CollapsibleControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.ImageList imageListScroll;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel;
    }
}
