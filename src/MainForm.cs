using ComicStripToKindle.ComicsPages;
using ComicStripToKindle.DriveDetection;
using ComicStripToKindle.Extensions;
using ComicStripToKindle.PanelExtraction;
using ComicStripToKindle.PanelOrdering;
using ComicStripToKindle.Pdf;
using ComicStripToKindle.Profiles;
using ComicStripToKindle.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComicStripToKindle
{
    using AForge.Imaging;
    using Controls;
    using System.Configuration;

    public partial class MainForm : Form
    {
        private ImageList IconImageList;
        ElectronicReaderProfile CurrentElectronicReaderProfile;
        ComicConversionProfile CurrentComicConversionProfile;
        private ImageEnhancementProfile CurrentImageEnhancementProfile;
        private OutputProfile CurrentOutputProfile;
        private ProfileFiles ProfileFiles;
        private DriveInfo EReaderDriveInfo;
        private List<CollapsibleControl> collapsibleControls;
        public MainForm()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
            UsbNotification.RegisterUsbDeviceNotification(this.Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_InitialiseCollapsablePanels();

            HidePreview();

            ProfileFiles = new ProfileFiles();

            IconImageList = ImageLists.BuildImageList();
            lvFiles.StateImageList = IconImageList;

            UI_AddEreaderProfiles(ProfileFiles.LoadElectronicReaderProfiles());
            UI_AddComicConvertionProfiles(ProfileFiles.LoadComicConversionProfiles());
            UI_AddImageEnhancementProfiles(ProfileFiles.LoadImageEnhancementProfiles());

            UI_SetEReaderStatus();

            CurrentOutputProfile = ProfileFiles.LoadOutputProfile();
            UI_ApplyOutputProfile(CurrentOutputProfile);

            FileSystemUtilities.ClearTemporaryDirectories();

            collapsibleControls = new List<CollapsibleControl>();
            collapsibleControls.AddRange(this.FindChildControlsOfType<CollapsibleControl>());

            UI_LoadSelectedSettings();
        }



        void UI_InitialiseCollapsablePanels()
        {
            collapsibleControlEreader.LowerPanel = panelEreader;
            collapsibleControlEreader.Image = pVolumeConected.Image;
            collapsibleControlEreader.CollapsedStateChanged += CollapsibleControl_CollapsedStateChanged;
            panelEreader.Location = new Point(collapsibleControlEreader.Location.X, collapsibleControlEreader.Location.Y + collapsibleControlEreader.Height);
            collapsibleControlEreader.ControlCollaspedState = ComicStripToKindle.Controls.CollapsibleControl.ControlState.Collapsed;

            collapsibleControlComic.LowerPanel = panelComic;
            collapsibleControlComic.CollapsedStateChanged += CollapsibleControl_CollapsedStateChanged;
            panelComic.Location = new Point(collapsibleControlComic.Location.X, collapsibleControlComic.Location.Y + collapsibleControlComic.Height);
            collapsibleControlComic.ControlCollaspedState = ComicStripToKindle.Controls.CollapsibleControl.ControlState.Collapsed;

            collapsibleControlEmail.LowerPanel = panelEmailSettings;
            collapsibleControlEmail.CollapsedStateChanged += CollapsibleControl_CollapsedStateChanged;
            panelEmailSettings.Location = new Point(collapsibleControlEmail.Location.X, collapsibleControlEmail.Location.Y + collapsibleControlEmail.Height);
            collapsibleControlEmail.ControlCollaspedState = ComicStripToKindle.Controls.CollapsibleControl.ControlState.Collapsed;

            collapsibleControlImageEnhancement.LowerPanel = panelImageEnhancement;
            collapsibleControlImageEnhancement.CollapsedStateChanged += CollapsibleControl_CollapsedStateChanged;
            panelImageEnhancement.Location = new Point(collapsibleControlImageEnhancement.Location.X, collapsibleControlImageEnhancement.Location.Y + collapsibleControlImageEnhancement.Height);
            collapsibleControlImageEnhancement.ControlCollaspedState = CollapsibleControl.ControlState.Collapsed;
        }

        void UI_ReorganisePanels()
        {
            var x = panelEreader.Location.X;

            var collapsibleControlEreaderLocationY = 0;
            var panelEreaderLocationY = 0;
            var panelEreaderVisible = false;

            var collapsibleControlComicLocationY = 0;
            var panelControlComicLocationY = 0;
            var panelControlComicVisible = false;

            var collapsibleControlEmailLocationY = 0;
            var panelEmailLocationY = 0;
            var panelEmailVisible = false;

            var collapsibleImageEnhancementLocationY = 0;
            var panelImageEnhancementLocationY = 0;
            var panelOutputLocationY = 0;
            var panelImageEnhancementVisible = false;
            //-----------------

            collapsibleControlEreaderLocationY = collapsibleControlEreader.Location.Y;
            if (collapsibleControlEreader.ControlCollaspedState == ComicStripToKindle.Controls.CollapsibleControl.ControlState.Collapsed)
            {
                collapsibleControlComicLocationY = collapsibleControlEreader.Location.Y + collapsibleControlEreader.Height;
            }
            else
            {
                panelEreaderVisible = true;
                panelEreaderLocationY = collapsibleControlEreader.Location.Y + collapsibleControlEreader.Height;

                collapsibleControlComicLocationY = panelEreaderLocationY + panelEreader.Height;
            }

            if (collapsibleControlComic.ControlCollaspedState == ComicStripToKindle.Controls.CollapsibleControl.ControlState.Collapsed)
            {
                collapsibleControlEmailLocationY = collapsibleControlComicLocationY + collapsibleControlComic.Height;
            }
            else
            {
                panelControlComicVisible = true;
                panelControlComicLocationY = collapsibleControlComicLocationY + collapsibleControlComic.Height;

                collapsibleControlEmailLocationY = panelControlComicLocationY + panelComic.Height;
            }

            if (collapsibleControlEmail.ControlCollaspedState == ComicStripToKindle.Controls.CollapsibleControl.ControlState.Collapsed)
            {
                collapsibleImageEnhancementLocationY = collapsibleControlEmailLocationY + collapsibleControlEmail.Height;
            }
            else
            {
                panelEmailVisible = true;
                panelEmailLocationY = collapsibleControlEmailLocationY + collapsibleControlEmail.Height;

                collapsibleImageEnhancementLocationY = panelEmailLocationY + panelEmailSettings.Height;
            }

            if (collapsibleControlImageEnhancement.ControlCollaspedState == CollapsibleControl.ControlState.Collapsed)
            {
                panelOutputLocationY = collapsibleImageEnhancementLocationY + collapsibleControlImageEnhancement.Height;
            }
            else
            {
                panelImageEnhancementVisible = true;
                panelImageEnhancementLocationY = collapsibleImageEnhancementLocationY + collapsibleControlImageEnhancement.Height;

                panelOutputLocationY = panelImageEnhancementLocationY + panelImageEnhancement.Height;
            }


            collapsibleControlEreader.Location = new Point(x, collapsibleControlEreaderLocationY);
            collapsibleControlComic.Location = new Point(x, collapsibleControlComicLocationY);
            collapsibleControlEmail.Location = new Point(x, collapsibleControlEmailLocationY);
            collapsibleControlImageEnhancement.Location = new Point(x, collapsibleImageEnhancementLocationY);

            collapsibleControlEreader.Visible = true;
            collapsibleControlComic.Visible = true;
            collapsibleControlEmail.Visible = true;
            collapsibleControlImageEnhancement.Visible = true;

            panelEreader.Location = new Point(x, panelEreaderLocationY);
            panelComic.Location = new Point(x, panelControlComicLocationY);
            panelEmailSettings.Location = new Point(x, panelEmailLocationY);
            panelImageEnhancement.Location = new Point(x, panelImageEnhancementLocationY);
            panelOutput.Location = new Point(x, panelOutputLocationY);

            panelEreader.Visible = panelEreaderVisible;
            panelComic.Visible = panelControlComicVisible;
            panelEmailSettings.Visible = panelEmailVisible;
            panelImageEnhancement.Visible = panelImageEnhancementVisible;
        }


        private void CollapsibleControl_CollapsedStateChanged(object sender, Controls.CollapsibleControl.ControlState controlState)
        {
            if (collapsibleControls == null)
                return;

            var control = (CollapsibleControl)sender;

            foreach (var collapsibleControl in collapsibleControls.Where(x => x.Name != control.Name))
            {
                if (collapsibleControl.ControlCollaspedState == CollapsibleControl.ControlState.Collapsed)
                    continue;

                collapsibleControl.CollapsedStateChanged -= CollapsibleControl_CollapsedStateChanged;

                collapsibleControl.ControlCollaspedState = CollapsibleControl.ControlState.Collapsed;

                collapsibleControl.CollapsedStateChanged += CollapsibleControl_CollapsedStateChanged;
            }

            UI_ReorganisePanels();
        }


        private void collapsibleControlEreader_Click(object sender, EventArgs e)
        {
            // collapsibleControlComic.ControlCollaspedState = ;
            //collapsibleControlEmail.Visible = false;
        }
        private void collapsibleControlComic_Click(object sender, EventArgs e)
        {
            //collapsibleControlEmail.Visible = false;
        }
        private void collapsibleControlEmail_Click(object sender, EventArgs e)
        {

        }
        private void collapsibleControlImageEnhancement_Click(object sender, EventArgs e)
        {

        }

        #region eReader Status

        private const int WM_DEVICECHANGE = 0x0219;

        // logical volume(A disk has been inserted, such a usb key or external HDD)
        private const int DBT_DEVTYP_VOLUME = 0x00000002;

        // detected a new device
        private const int DBT_DEVICEARRIVAL = 0x8000;

        // preparing to remove
        private const int DBT_DEVICEQUERYREMOVE = 0x8001;

        // removed
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if ((message.Msg != WM_DEVICECHANGE) || (message.LParam == IntPtr.Zero))
                return;

            DeviceNotification.DEV_BROADCAST_VOLUME volume = (DeviceNotification.DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(message.LParam, typeof(DeviceNotification.DEV_BROADCAST_VOLUME));

            if (volume.dbcv_devicetype == DBT_DEVTYP_VOLUME)
            {
                switch (message.WParam.ToInt32())
                {
                    // New device inserted...
                    case DBT_DEVICEARRIVAL:
                        Debug.WriteLine($"A storage device has been inserted; Drive :{DeviceNotification.ToDriveName(volume.dbcv_unitmask)}");

                        //EReaderDriveInfo = GetEreaderDriveInfo();
                        UI_SetEReaderStatus();
                        break;

                    // Device Removed.
                    case DBT_DEVICEREMOVECOMPLETE:
                        Debug.WriteLine("Storage has been removed.");
                        //EReaderDriveInfo = GetEreaderDriveInfo();
                        UI_SetEReaderStatus();
                        break;
                }
            }
        }

        DriveInfo GetEreaderDriveInfo()
        {
            try
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    try
                    {
                        if (drive.IsReady
                            && drive.DriveType == DriveType.Removable
                            && string.Equals(drive.VolumeLabel, txtVolumeName.Text, StringComparison.InvariantCultureIgnoreCase))
                            return drive;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            return null;
        }

        void UI_SetEReaderStatus()
        {
            Task.Factory.StartNew(new Action(() =>
            {
                EReaderDriveInfo = GetEreaderDriveInfo();

                if (null == EReaderDriveInfo)
                    pVolumeConected.Image = IconImageList.Images.Cast<Bitmap>().ToList()[(int)ImageLists.ImageStates.Error];
                else
                    pVolumeConected.Image = IconImageList.Images.Cast<Bitmap>().ToList()[(int)ImageLists.ImageStates.Done];

                collapsibleControlEreader.Image = pVolumeConected.Image;
            }));
        }
        #endregion

        void pbAddComicDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var directories = Directory.EnumerateDirectories(fbd.SelectedPath);

                    if (null == directories || directories.Count() == 0)
                    {
                        AddLVItem(fbd.SelectedPath, new KindleConverter.ConversionProgressEventArgs { SourceFilePath = fbd.SelectedPath });
                    }
                    else
                        foreach (var directory in directories)
                        {
                            AddLVItem(directory,
                                new KindleConverter.ConversionProgressEventArgs { SourceFilePath = directory });
                        }
                }
            }
        }
        private void pbSelectComicArchive_Click(object sender, EventArgs e)
        {
            //tabControl.SelectTab(tabPageConversionErrors);

            using (var openFileDialog1 = new OpenFileDialog
            {
                Filter = @"All files (*.*)|*.*|All comics archive Types|*.cbz;*.cbr|pdf files (*.pdf)|*.pdf",
                FilterIndex = 1,
                RestoreDirectory = true,
                Multiselect = true
            })
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                foreach (var filePath in openFileDialog1.FileNames)
                {
                    if (AlreadyAdded(filePath))
                        continue;

                    var fi = new FileInfo(filePath);
                    AddLVItem(fi.Name, new KindleConverter.ConversionProgressEventArgs { SourceFilePath = filePath });
                    _fileConversionProgress.Add(filePath, 0.0f);
                }
            }
        }
        private void pbClearComicFiles_Click(object sender, EventArgs e)
        {
            _fileConversionProgress.Clear();

            var lvis = lvFiles.Items.Cast<ListViewItem>();

            var i = 0;

            var listViewItems = lvis as IList<ListViewItem> ?? lvis.ToList();
            while (i < listViewItems.Count())
            {
                var filePath = listViewItems[i].SubItems[0].Text;
                RemoveLVITem(filePath);
                i++;
            }
        }

        private void pbConvertToKindlePdf_Click(object sender, EventArgs e)
        {
            HidePreview();

            CurrentImageEnhancementProfile = UI_GetImageEnhancementProfile();
            CurrentComicConversionProfile = UI_GetComicConversionProfile();
            CurrentImageEnhancementProfile = UI_GetImageEnhancementProfile();

            var originalFiles = lvFiles.Items.Cast<ListViewItem>();

            var lvis = originalFiles.ToList();

            if (!Directory.Exists(txtPdfDirectory.Text))
                Directory.CreateDirectory(txtPdfDirectory.Text);

            Task.Factory.StartNew(() =>
            {
                //Parallel.ForEach(
                //    lvis,
                //    new ParallelOptions {  MaxDegreeOfParallelism = Convert.ToInt32(Math.Ceiling((Environment.ProcessorCount * 0.75) * 1.0)) },
                //    (originalFileLvi) =>
                foreach (var lvi in lvis)
                {
                    try
                    {
                        var sourceFilePath = ((KindleConverter.ConversionProgressEventArgs)lvi.Tag).SourceFilePath;

                        var kindlePdfConverter = new KindleConverter(sourceFilePath);
                        kindlePdfConverter.Progression += KindlePdfConverter_Progression;

                        var convertedKindlePdfFilePath =
                        kindlePdfConverter.ConvertComicToKindlePdf(
                            txtPdfDirectory.Text,
                            CurrentElectronicReaderProfile,
                            CurrentComicConversionProfile,
                            CurrentImageEnhancementProfile);

                        FinaliseConversion(CurrentOutputProfile, convertedKindlePdfFilePath, sourceFilePath);
                    }
                    catch (Exception exception)
                    {
                        Debug.WriteLine($"Exception when processing {lvi.Text} {exception}");
                    }
                }
            })
            .ContinueWith(x => { if (chkOpenDirectoryAfterConversion.Checked) Process.Start(txtPdfDirectory.Text); });
        }

        private readonly SynchronizationContext synchronizationContext;
        private void KindlePdfConverter_Progression(object sender, KindleConverter.ConversionProgressEventArgs e)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                UpdateItemValue(e);

                progressBar.Value = (int)(_fileConversionProgress.Values.Sum() / _fileConversionProgress.Count());

                Application.DoEvents();
            }), e);
        }

        private void AddLVItem(string file, object tag)
        {
            var lvi = new ListViewItem();
            var pb = new System.Windows.Forms.ProgressBar();

            lvi.UseItemStyleForSubItems = false;
            lvi.SubItems[0].Text = file;
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");

            lvi.SubItems.Add("");
            lvi.SubItems.Add("");

            lvi.Tag = tag;
            lvi.Checked = true;
            lvi.StateImageIndex = (int)ImageLists.ImageStates.None;
            lvFiles.Items.Add(lvi);

            var r = lvi.SubItems[1].Bounds;
            pb.SetBounds(r.X, r.Y, r.Width, r.Height);
            pb.Minimum = 1;
            pb.Maximum = 100;
            pb.Value = pb.Minimum;
            pb.Name = file;                   // use the key as the name
            lvFiles.Controls.Add(pb);
        }

        private void RemoveLVITem(string file)
        {
            lvFiles.Controls.RemoveByKey(file);

            var lvi = lvFiles.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == file);

            if (null == lvi)
                return;

            lvFiles.Items.Remove(lvi);
        }

        private bool AlreadyAdded(string file)
        {
            var lvi = lvFiles.Items.Cast<ListViewItem>().FirstOrDefault(x => (x.Tag as KindleConverter.ConversionProgressEventArgs).SourceFilePath == file);

            return null != lvi;
        }


        readonly Dictionary<string, float> _fileConversionProgress = new Dictionary<string, float>();

        private void UpdateItemValue(KindleConverter.ConversionProgressEventArgs arg)
        {
            try
            {
                // find the LVI based on the "key" in 
                var lvi = lvFiles.Items.Cast<ListViewItem>().FirstOrDefault(q => ((KindleConverter.ConversionProgressEventArgs)q.Tag).SourceFilePath == arg.SourceFilePath);
                if (lvi != null)
                {
                    lvi.SubItems[1].Text = arg.Percentage.ToString(CultureInfo.InvariantCulture);
                    lvi.SubItems[2].Text = arg.Description;
                    lvi.Tag = arg;
                    var pageExtractionErrors = arg.Pages?.Pages?.Any(x => x.Exception != null);
                    var panelErrors = arg.Panels?.Any(x => x != null && x.ExtractedPanels.Any(y => y.Exception != null));

                    if ((pageExtractionErrors.HasValue && pageExtractionErrors.Value) ||
                        (panelErrors.HasValue && panelErrors.Value))
                    {

                        if (arg.Percentage == 100.0f)
                            lvi.StateImageIndex = (int)ImageLists.ImageStates.DoneWarning;
                        else
                            lvi.StateImageIndex = (int)ImageLists.ImageStates.Warning;
                    }
                    else switch (arg.Percentage)
                        {
                            case 0.0f:
                                lvi.StateImageIndex = (int)ImageLists.ImageStates.None;
                                break;
                            case 100.0f:
                                lvi.StateImageIndex = (int)ImageLists.ImageStates.Done;
                                break;
                            default:
                                lvi.StateImageIndex = (int)ImageLists.ImageStates.Processing;
                                break;
                        }
                }

                var pb = lvFiles.Controls.OfType<System.Windows.Forms.ProgressBar>().FirstOrDefault(q => q.Name == lvi.Text);
                if (pb != null)
                    pb.Value = (int)arg.Percentage > pb.Minimum ? (int)arg.Percentage : pb.Minimum;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e}");
            }

            _fileConversionProgress[arg.SourceFilePath] = arg.Percentage;
        }

        private void lvFiles_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            foreach (var lvi in lvFiles.Items.Cast<ListViewItem>())
            {
                var r = lvi.SubItems[1].Bounds;

                var pb = lvFiles.Controls.OfType<System.Windows.Forms.ProgressBar>().FirstOrDefault(q => q.Name == lvi.Text);
                pb?.SetBounds(r.X, r.Y, r.Width, r.Height);
            }
        }

        private void lvFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count == 0)
                return;

            var fileConversion = (KindleConverter.ConversionProgressEventArgs)lvFiles.SelectedItems[0].Tag;

            var text = new StringBuilder();

            var pageExtractionExceptions = fileConversion.Pages?.Pages?.Where(x => x.Exception != null);

            if (pageExtractionExceptions != null)
                foreach (var pageExtractionException in pageExtractionExceptions)
                    text.AppendLine($"Page {pageExtractionException.PageNumber}: {pageExtractionException.Exception}");

            var panelExtractionExceptions = fileConversion.Panels?.SelectMany(x => x.ExtractedPanels).Where(y => y.Exception != null);
            if (panelExtractionExceptions != null)
                foreach (var panelExtractionException in panelExtractionExceptions)
                    text.AppendLine($"Panel {panelExtractionException.PanelNumber}: {panelExtractionException.Exception}");

            txtErrors.Text = text.ToString();
        }

        void UI_ApplyImageEnhancement(ImageEnhancementProfile profile)
        {
            cbImageEnhancementProfile.Text = profile.Name;

            chkAutomaticRotation.Checked = profile.AutomaticRotation;
            txtRotationAngle.Text = profile.RotationAngle.ToString(CultureInfo.InvariantCulture);

            chkCorrectionSharpen.Checked = profile.Sharpen;

            chkAutomaticContrastCorrection.Checked = profile.AutomaticContrastCorrection;

            txtJpegQuality.Text = profile.JpegQuality.ToString();

            chkLevelThreshold.Checked = profile.LevelThreshold;
            txtWhiteLevel.Text = profile.WhiteLevel.ToString();
            txtBlackLevel.Text = profile.BlackLevel.ToString();

            chkGaussianSharpen.Checked = profile.GaussianSharpen;
            txtGaussianSharpenSigma.Text = profile.Sigma.ToString();
            txtGaussianSharpenKernel.Text = profile.Kernel.ToString();

            chkGaussianBlur.Checked = profile.GaussianBlur;
            txtGaussianBlurSigma.Text = profile.GaussianBlurSigma.ToString();
            txtGaussianBlurKernel.Text = profile.GaussianBlurKernel.ToString();

            chkMedianFilter.Checked = profile.BlurMedianFilter;
        }
        ImageEnhancementProfile UI_GetImageEnhancementProfile()
        {
            ImageEnhancementProfile profile = new ImageEnhancementProfile();

            // Set default values for all properties
            profile.AutomaticRotation = chkAutomaticRotation.Checked;
            profile.AutomaticContrastCorrection = chkAutomaticContrastCorrection.Checked;
            profile.Sharpen = chkCorrectionSharpen.Checked;
            profile.RotationAngle = 90f;
            profile.JpegQuality = 1;
            profile.LevelThreshold = chkLevelThreshold.Checked;
            profile.WhiteLevel = 255;
            profile.BlackLevel = 0;
            profile.GaussianSharpen = chkGaussianSharpen.Checked;
            profile.Sigma = 1f;
            profile.Kernel = 3;
            profile.Name = cbImageEnhancementProfile.Text;
            profile.GaussianBlur = chkGaussianBlur.Checked;
            profile.GaussianBlurSigma = 1f;
            profile.GaussianBlurKernel = 3;
            profile.BlurMedianFilter = chkMedianFilter.Checked;

            try
            {
                if (!string.IsNullOrEmpty(txtRotationAngle.Text))
                    profile.RotationAngle = Convert.ToSingle(txtRotationAngle.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting Rotation Angle: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtJpegQuality.Text))
                    profile.JpegQuality = Convert.ToInt32(txtJpegQuality.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting Jpeg Quality: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtWhiteLevel.Text))
                    profile.WhiteLevel = Convert.ToInt32(txtWhiteLevel.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting White Level: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtBlackLevel.Text))
                    profile.BlackLevel = Convert.ToInt32(txtBlackLevel.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting Black Level: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtGaussianSharpenSigma.Text))
                    profile.Sigma = Convert.ToSingle(txtGaussianSharpenSigma.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting Gaussian Sharpen Sigma: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtGaussianSharpenKernel.Text))
                    profile.Kernel = Convert.ToInt32(txtGaussianSharpenKernel.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting Gaussian Sharpen Kernel: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtGaussianBlurSigma.Text))
                    profile.GaussianBlurSigma = Convert.ToSingle(txtGaussianBlurSigma.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting Gaussian Blur Sigma: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtGaussianBlurKernel.Text))
                    profile.GaussianBlurKernel = Convert.ToInt32(txtGaussianBlurKernel.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while converting Gaussian Blur Kernel: " + ex.Message);
            }

            return profile;
        }

        void UI_ApplyEreaderProfile(ElectronicReaderProfile profile)
        {
            txtResolutionHeight.Text = profile.VerticalResolution.ToString();
            txtResolutionWidth.Text = profile.HorizontalResolution.ToString();

            chkCorrectionGamma.Checked = profile.GammaCorrection.HasValue && profile.GammaCorrection != 0;
            txtCorrectionGamma.Text = profile.GammaCorrection.HasValue ? profile.GammaCorrection.ToString() : "0";

            chkGrayscal.Checked = profile.Grayscale;

            txtVolumeName.Text = profile.VolumeName;
            txtDocumentDirectory.Text = profile.DocumentDirectory;
        }
        ElectronicReaderProfile UI_GetEreaderProfile()
        {
            return new ElectronicReaderProfile
            {
                VerticalResolution = !string.IsNullOrEmpty(txtResolutionHeight.Text) ? Convert.ToInt32(txtResolutionHeight.Text) : 0,
                HorizontalResolution = !string.IsNullOrEmpty(txtResolutionWidth.Text) ? Convert.ToInt32(txtResolutionWidth.Text) : 0,

                Grayscale = chkGrayscal.Checked,

                GammaCorrection = chkCorrectionGamma.Checked && !string.IsNullOrEmpty(txtCorrectionGamma.Text) ? Convert.ToDouble(txtCorrectionGamma.Text) : 0,

                Name = cbEReaderProfile.Text,

                VolumeName = txtVolumeName.Text,
                DocumentDirectory = txtDocumentDirectory.Text
            };
        }

        void UI_ApplyComicConversionProfile(ComicConversionProfile profile)
        {
            chkUnSkew.Checked = profile.UnSkew;
            txtMinimumPanelHeight.Text = profile.MinimumPanelSizeHeightFraction.ToString();
            txtMinimumPanelWidth.Text = profile.MinimumPanelSizeWidthFraction.ToString();

            chkManga.Checked = profile.PanelReadingDirection.HasFlag(PanelReadingDirection.RightToLeft);

            rbAlgoConnectedComponents.Checked = profile.PanelDetectionAlgorithm.HasFlag(PanelDetectionAlgorithm.ByConnectedComponents);
            rbAlgoEmptyLinesAndColumns.Checked = profile.PanelDetectionAlgorithm.HasFlag(PanelDetectionAlgorithm.ByWhiteLinesDetection);
            rbAlgoCombined.Checked = profile.PanelDetectionAlgorithm.HasFlag(PanelDetectionAlgorithm.ByConnectedComponentsAndyWhiteLinesDetection);
            rbAlgoCropOnly.Checked = profile.PanelDetectionAlgorithm.HasFlag(PanelDetectionAlgorithm.CropWhiteBorders);

            txtBackgroundTreshold.Text = profile.WhiteBackgroundTreshold.ToString();
            chkBlackBackground.Checked = profile.BlackBackground;
            chkVerticalSplit.Checked = profile.VerticalSplit;
            chkIncludePageIfNoPanelDetected.Checked = profile.IncludePageIfNoPanelDetected;
            chkInvertPages.Checked = profile.InvertPages;
            cbHorizontalOnly.Checked = profile.HorizontalLinesOnly;
        }
        ComicConversionProfile UI_GetComicConversionProfile()
        {
            PanelReadingDirection panelReadingDirection = PanelReadingDirection.None;
            if (chkManga.Checked)
                panelReadingDirection |= PanelReadingDirection.RightToLeft;
            else
                panelReadingDirection |= PanelReadingDirection.LeftToRight;

            PanelDetectionAlgorithm panelDetectionAlgorithm = PanelDetectionAlgorithm.None;
            if (rbAlgoConnectedComponents.Checked)
                panelDetectionAlgorithm |= PanelDetectionAlgorithm.ByConnectedComponents;
            if (rbAlgoEmptyLinesAndColumns.Checked)
                panelDetectionAlgorithm |= PanelDetectionAlgorithm.ByWhiteLinesDetection;
            if (rbAlgoCombined.Checked)
                panelDetectionAlgorithm |= PanelDetectionAlgorithm.ByConnectedComponentsAndyWhiteLinesDetection;
            if (rbAlgoCropOnly.Checked)
                panelDetectionAlgorithm |= PanelDetectionAlgorithm.CropWhiteBorders;

            return new ComicConversionProfile
            {
                Name = cbComicProfile.Text,
                InvertPages = chkInvertPages.Checked,
                PanelReadingDirection = panelReadingDirection,
                UnSkew = chkUnSkew.Checked,
                MinimumPanelSizeWidthFraction = !string.IsNullOrEmpty(txtMinimumPanelWidth.Text) ? Convert.ToInt32(txtMinimumPanelWidth.Text) : 0,
                MinimumPanelSizeHeightFraction = !string.IsNullOrEmpty(txtMinimumPanelHeight.Text) ? Convert.ToInt32(txtMinimumPanelHeight.Text) : 0,
                PanelDetectionAlgorithm = panelDetectionAlgorithm,
                WhiteBackgroundTreshold = !string.IsNullOrEmpty(txtBackgroundTreshold.Text) ? Convert.ToInt32(txtBackgroundTreshold.Text) : 0,
                BlackBackground = chkBlackBackground.Checked,
                VerticalSplit = chkVerticalSplit.Checked,
                IncludePageIfNoPanelDetected = chkIncludePageIfNoPanelDetected.Checked,
                HorizontalLinesOnly = cbHorizontalOnly.Checked
            };
        }

        void UI_AddPredefinedEreader()
        {
            cbEReaderProfile.DisplayMember = "Name";
            cbEReaderProfile.ValueMember = "Value";

            foreach (var item in PredefinedProfiles.ElectronicReaderProfiles)
                cbEReaderProfile.Items.Add(new ComboboxItem
                {
                    Text = item.ToString(),
                    Value = item
                });
        }
        void UI_AddEreaderProfiles(List<ElectronicReaderProfile> profiles)
        {
            cbEReaderProfile.DisplayMember = "Name";
            cbEReaderProfile.ValueMember = "Value";

            foreach (var item in profiles)
            {
                cbEReaderProfile.Items.Add(new ComboboxItem
                {
                    Text = item.ToString(),
                    Value = item
                });
            }
        }
        void UI_AddEreaderProfile(ElectronicReaderProfile profile)
        {
            cbEReaderProfile.DisplayMember = "Name";
            cbEReaderProfile.ValueMember = "Value";

            if (cbEReaderProfile.SelectedIndex >= 0)
                cbEReaderProfile.Items.RemoveAt(cbEReaderProfile.SelectedIndex);

            cbEReaderProfile.Items.Add(new ComboboxItem
            {
                Text = profile.ToString(),
                Value = profile
            });

        }

        void UI_DeleteEreaderProfile(ElectronicReaderProfile profile)
        {
            var lvi = cbEReaderProfile.Items.Cast<ComboboxItem>().FirstOrDefault(x => x.Text == profile.ToString());

            if (null == lvi)
                return;

            cbEReaderProfile.Items.Remove(lvi);

            if (cbComicProfile.Items.Count == 0)
            {
                CurrentElectronicReaderProfile = null;
                return;
            }

            cbComicProfile.SelectedItem = cbEReaderProfile.Items[0];
            CurrentElectronicReaderProfile = UI_GetEreaderProfile();
        }
        void UI_DeleteComicProfile(ComicConversionProfile profile)
        {
            var lvi = cbComicProfile.Items.Cast<ComboboxItem>().FirstOrDefault(x => x.Text == profile.ToString());

            if (null == lvi)
                return;

            cbComicProfile.Items.Remove(lvi);

            if (cbComicProfile.Items.Count == 0)
            {
                CurrentComicConversionProfile = null;
                return;
            }

            cbComicProfile.SelectedIndex = 0;
            CurrentComicConversionProfile = UI_GetComicConversionProfile();
        }
        private void cbEReaderProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEReaderProfile.SelectedItem == null)
                return;

            var profile = (cbEReaderProfile.SelectedItem as ComboboxItem).Value as ElectronicReaderProfile;

            UI_ApplyEreaderProfile(profile);

            CurrentElectronicReaderProfile = profile;

            collapsibleControlEreader.DisplayText = cbEReaderProfile.Text;

            UI_SetEReaderStatus();
        }

        void UI_AddPredefinedComicConvertionProfiles()
        {
            cbComicProfile.DisplayMember = "Name";
            cbComicProfile.ValueMember = "Value";

            foreach (var item in PredefinedProfiles.ComicConversionProfiles)
                cbComicProfile.Items.Add(new ComboboxItem
                {
                    Text = item.ToString(),
                    Value = item
                });
        }
        void UI_AddComicConvertionProfiles(List<ComicConversionProfile> profiles)
        {
            cbComicProfile.DisplayMember = "Name";
            cbComicProfile.ValueMember = "Value";

            foreach (var item in profiles)
            {
                cbComicProfile.Items.Add(new ComboboxItem
                {
                    Text = item.ToString(),
                    Value = item
                });
            }
        }
        void UI_AddComicConvertionProfile(ComicConversionProfile profile)
        {
            cbComicProfile.DisplayMember = "Name";
            cbComicProfile.ValueMember = "Value";

            if (cbComicProfile.SelectedIndex >= 0)
                cbComicProfile.Items.RemoveAt(cbComicProfile.SelectedIndex);

            cbComicProfile.Items.Add(new ComboboxItem
            {
                Text = profile.ToString(),
                Value = profile
            });
        }
        private void cbComicProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComicProfile.SelectedItem == null)
                return;

            var profile = (cbComicProfile.SelectedItem as ComboboxItem).Value as ComicConversionProfile;

            UI_ApplyComicConversionProfile(profile);

            CurrentComicConversionProfile = profile;

            collapsibleControlComic.DisplayText = profile.Name;
        }

        private void pbSaveEreaderProfile_Click(object sender, EventArgs e)
        {
            var ereaderProfile = UI_GetEreaderProfile();
            ProfileFiles.Save(ereaderProfile);
            UI_AddEreaderProfile(ereaderProfile);
            cbEReaderProfile.SelectedIndex = cbEReaderProfile.Items.Count - 1;
        }
        private void pbDeleteEreaderProfile_Click(object sender, EventArgs e)
        {
            var profile = UI_GetEreaderProfile();
            ProfileFiles.Delete(profile);
            UI_DeleteEreaderProfile(profile);

            if (cbEReaderProfile.Items.Count == 0)
                return;

            cbEReaderProfile.SelectedIndex = 0;
        }

        void UI_AddImageEnhancementProfiles(List<ImageEnhancementProfile> profiles)
        {
            cbImageEnhancementProfile.DisplayMember = "Name";
            cbImageEnhancementProfile.ValueMember = "Value";

            foreach (var item in profiles)
            {
                cbImageEnhancementProfile.Items.Add(new ComboboxItem
                {
                    Text = item.ToString(),
                    Value = item
                });
            }
        }
        void UI_AddImageEnhancementProfile(ImageEnhancementProfile profile)
        {
            cbImageEnhancementProfile.DisplayMember = "Name";
            cbImageEnhancementProfile.ValueMember = "Value";

            if (cbImageEnhancementProfile.SelectedIndex >= 0)
                cbImageEnhancementProfile.Items.RemoveAt(cbImageEnhancementProfile.SelectedIndex);

            cbImageEnhancementProfile.Items.Add(new ComboboxItem
            {
                Text = profile.ToString(),
                Value = profile
            });
        }
        void UI_DeletImageEnhancementProfile(ImageEnhancementProfile profile)
        {
            var lvi = cbImageEnhancementProfile.Items.Cast<ComboboxItem>().FirstOrDefault(x => x.Text == profile.ToString());

            if (null == lvi)
                return;

            cbImageEnhancementProfile.Items.Remove(lvi);

            if (cbImageEnhancementProfile.Items.Count == 0)
            {
                CurrentImageEnhancementProfile = null;
                return;
            }

            cbImageEnhancementProfile.SelectedItem = cbImageEnhancementProfile.Items[0];
            CurrentImageEnhancementProfile = UI_GetImageEnhancementProfile();
        }
        private void pbSaveImageEnhancement_Click(object sender, EventArgs e)
        {
            var imageEnhancementProfile = UI_GetImageEnhancementProfile();
            ProfileFiles.Save(imageEnhancementProfile);
            UI_AddImageEnhancementProfile(imageEnhancementProfile);
            cbImageEnhancementProfile.SelectedIndex = cbImageEnhancementProfile.Items.Count - 1;
        }

        private void pbDleteImageEnhancement_Click(object sender, EventArgs e)
        {
            var profile = UI_GetImageEnhancementProfile();
            ProfileFiles.Delete(profile);
            UI_DeletImageEnhancementProfile(profile);

            if (cbImageEnhancementProfile.Items.Count == 0)
                return;

            cbImageEnhancementProfile.SelectedIndex = 0;
        }

        private void cbImageEnhancementProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbImageEnhancementProfile.SelectedItem == null)
                return;

            var profile = (cbImageEnhancementProfile.SelectedItem as ComboboxItem).Value as ImageEnhancementProfile;

            UI_ApplyImageEnhancement(profile);

            CurrentImageEnhancementProfile = profile;

            collapsibleControlImageEnhancement.DisplayText = profile.Name;
        }



        private void pbSaveComicProfile_Click(object sender, EventArgs e)
        {
            var comicProfile = UI_GetComicConversionProfile();
            ProfileFiles.Save(comicProfile);
            UI_AddComicConvertionProfile(comicProfile);
            cbComicProfile.SelectedIndex = cbComicProfile.Items.Count - 1;
        }
        private void pbDeleteComicProfile_Click(object sender, EventArgs e)
        {
            var comicProfile = UI_GetComicConversionProfile();
            ProfileFiles.Delete(comicProfile);
            UI_DeleteComicProfile(comicProfile);

            if (cbComicProfile.Items.Count == 0)
                return;

            cbComicProfile.SelectedIndex = 0;
        }
        private void UI_SaveImageEnhancementProfile(object sender, EventArgs e)
        {
            //ProfileFiles.Save(UI_GetImageEnhancementProfile());

            if (preview)
                ShowPreviewResult(UI_GetEreaderProfile(), UI_GetImageEnhancementProfile());
        }

        void UI_ApplyOutputProfile(OutputProfile profile)
        {
            txtPdfDirectory.Text = profile.Directory;
            chkCopyToEreader.Checked = profile.UploadOnEreader;
            chkSendByEmail.Checked = profile.SendByEmail;
            chkOpenDirectoryAfterConversion.Checked = profile.OpenDirectoryAfterConversion;
            txtSmtpServer.Text = profile.SmtpServer;
            cbSmtpPort.Text = profile.SmtpPort.ToString();
            txtSmtpPassword.Text = profile.Password;
            txtFrom.Text = profile.From;
            txtTo.Text = profile.To;
        }

        OutputProfile UI_GetOutputProfile()
        {
            return new OutputProfile
            {
                Directory = txtPdfDirectory.Text,
                UploadOnEreader = chkCopyToEreader.Checked,
                OpenDirectoryAfterConversion = chkOpenDirectoryAfterConversion.Checked,
                SendByEmail = chkSendByEmail.Checked,
                From = txtFrom.Text,
                To = txtTo.Text,
                SmtpServer = txtSmtpServer.Text,
                Password = txtSmtpPassword.Text,
                SmtpPort = string.IsNullOrEmpty(cbSmtpPort.Text)
                ? 0
                : Convert.ToInt32(cbSmtpPort.Text)
            };
        }

        private void SaveOutputProfile(object sender, EventArgs e)
        {
            CurrentOutputProfile = UI_GetOutputProfile();
            ProfileFiles.Save(CurrentOutputProfile);
        }

        private void txtPdfDirectory_TextChanged(object sender, EventArgs e)
        {
            SaveOutputProfile(sender, e);

            try
            {
                txtPdfFileName.Text = txtPdfDirectory.Text.Split('\\').LastOrDefault() + ".pdf";
            }
            catch { }
        }


        private void CopyToEreaderResult(string sourceFilePath, bool ok)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                // find the LVI based on the "key" in 
                var lvi = lvFiles.Items.Cast<ListViewItem>().FirstOrDefault(q => ((KindleConverter.ConversionProgressEventArgs)q.Tag).SourceFilePath == sourceFilePath);
                if (lvi != null)
                {
                    lvi.SubItems[3].Text = ok ? "O" : "X";
                    lvi.SubItems[3].BackColor = ok ? Color.Green : Color.Red;
                    lvi.SubItems[3].ForeColor = ok ? Color.Green : Color.Red;

                    Application.DoEvents();
                }
            }), ok);
        }

        private void SendEmailResult(string sourceFilePath, bool ok)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                // find the LVI based on the "key" in 
                var lvi = lvFiles.Items.Cast<ListViewItem>().FirstOrDefault(q => ((KindleConverter.ConversionProgressEventArgs)q.Tag).SourceFilePath == sourceFilePath);
                if (lvi != null)
                {
                    lvi.SubItems[4].Text = ok ? "O" : "X";
                    lvi.SubItems[4].BackColor = ok ? Color.Green : Color.Red;
                    lvi.SubItems[4].ForeColor = ok ? Color.Green : Color.Red;
                    Application.DoEvents();
                }
            }), ok);
        }

        void FinaliseConversion(OutputProfile profile, string convertedKindlePdfFilePath, string sourceFilePath)
        {
            CopyToEreader(profile, convertedKindlePdfFilePath, sourceFilePath);
            SendEmail(profile, convertedKindlePdfFilePath, sourceFilePath);
        }

        void CopyToEreader(OutputProfile profile, string convertedKindlePdfFilePath, string sourceFilePath)
        {
            if (!profile.UploadOnEreader || EReaderDriveInfo == null)
            {
                return;
            }

            try
            {
                var fi = new FileInfo(convertedKindlePdfFilePath);

                var targetDirectory = Path.Combine(EReaderDriveInfo.Name, CurrentElectronicReaderProfile.DocumentDirectory);

                if (!Directory.Exists(targetDirectory))
                    Directory.CreateDirectory(targetDirectory);

                var targetPath = Path.Combine(EReaderDriveInfo.Name, CurrentElectronicReaderProfile.DocumentDirectory, fi.Name);

                if (File.Exists(targetPath))
                    File.Delete(targetPath);

                File.Copy(convertedKindlePdfFilePath, targetPath, true);

                CopyToEreaderResult(sourceFilePath, true);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                CopyToEreaderResult(sourceFilePath, false);
            }
        }
        void SendEmail(OutputProfile profile, string convertedKindlePdfFilePath, string sourceFilePath)
        {
            if (!profile.SendByEmail)
                return;

            var message = new MailMessage(profile.From, profile.To);
            var attachment = new Attachment(convertedKindlePdfFilePath);
            message.Attachments.Add(attachment);
            var fi = new FileInfo(convertedKindlePdfFilePath);
            message.Body = fi.Name;


            var client = new SmtpClient(profile.SmtpServer, profile.SmtpPort)
            {
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            if (profile.SmtpPort == 25)
            {
                client.UseDefaultCredentials = false;
                var credentials = new System.Net.NetworkCredential(profile.From, profile.Password);
                client.EnableSsl = false;
                client.Credentials = credentials;
            }
            if (profile.SmtpPort == 465 || profile.SmtpPort == 587 || profile.SmtpPort == 2525)
            {
                client.UseDefaultCredentials = false;
                var credentials = new System.Net.NetworkCredential(profile.From, profile.Password);
                client.EnableSsl = true;
                client.Credentials = credentials;
            }

            try
            {
                client.Send(message);
                SendEmailResult(sourceFilePath, true);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                SendEmailResult(sourceFilePath, false);
            }

        }

        private void lvFiles_DoubleClick(object sender, EventArgs e)
        {
            //Preview

            ShowPreview();


        }

        private bool preview = false;
        private Bitmap previewPanel;

        void ShowPreview()
        {
            if (lvFiles.SelectedItems.Count != 1)
                return;

            preview = true;
            pPreview.Visible = true;
            pOriginal.Visible = true;
            pPreview.Visible = true;

            CurrentComicConversionProfile = UI_GetComicConversionProfile();
            CurrentElectronicReaderProfile = UI_GetEreaderProfile();
            CurrentImageEnhancementProfile = UI_GetImageEnhancementProfile();


            var sourceFilePath = ((KindleConverter.ConversionProgressEventArgs)lvFiles.SelectedItems[0].Tag).SourceFilePath;

            var sourcePages = ComicPagesFactory.Build(sourceFilePath, false, CurrentComicConversionProfile.VerticalSplit).ExtractRandomPage();

            var panelExtractor = new PanelExtractor(CurrentElectronicReaderProfile, CurrentComicConversionProfile, CurrentImageEnhancementProfile);

            var imagePath = sourcePages.Pages[0];

            if (string.IsNullOrEmpty(imagePath.ExtractedPagePath))
            {
                HidePreview();
                return;
            }

            var panels = panelExtractor.ExtractPanels(imagePath);

            if (panels == null || panels.Count == 0)
            {
                HidePreview();
                return;
            }

            previewPanel = panels[0];

            pOriginal.Image = previewPanel;
            picturePreview.Image = previewPanel;

            ShowPreviewResult(UI_GetEreaderProfile(), UI_GetImageEnhancementProfile());
        }

        void HidePreview()
        {
            pPreview.Visible = false;
            pOriginal.Visible = false;
            pPreview.Visible = false;
            preview = false;
        }

        void ShowPreviewResult(
            ElectronicReaderProfile electronicReaderProfile,
            ImageEnhancementProfile imageEnhancementProfile)
        {
            pOriginal.Image.ApplyToJpegCompression(99, out long originalJpegSize);
            double originalImageSize = (double)originalJpegSize / 1024;
            lOriginalSize.Text = $"{originalImageSize.ToString("####.##")} KB";

            lPreview.Text = "Generating...";

            Application.DoEvents();

            var panelExtractor = new PanelExtractor(electronicReaderProfile, null, imageEnhancementProfile);

            picturePreview.Image = panelExtractor.EnhancePanelImagePreview(previewPanel, out long sizeInBytes);

            lPreview.Text = "Preview Size: ";
            var imageSize = (double)sizeInBytes / 1024;

            var reductionPercentage = 100 - (imageSize / originalImageSize * 100);

            lConvertedSize.Text = $"{imageSize.ToString("####.##")} KB. Reduction: {reductionPercentage.ToString("###.##")} %";
        }

        private void pHidePreview_Click(object sender, EventArgs e)
        {
            HidePreview();
        }

        private void EreaderUpdate(object sender, EventArgs e)
        {
            if (preview)
                ShowPreviewResult(UI_GetEreaderProfile(), CurrentImageEnhancementProfile);
        }

        private void pPreview_Resize(object sender, EventArgs e)
        {

        }

        private void pPreview_SizeChanged(object sender, EventArgs e)
        {
            pOriginal.Size = new Size(pPreview.Size.Width / 2, pPreview.Size.Height - 40);
            pOriginal.Location = new Point(0, 0);

            picturePreview.Size = pOriginal.Size;
            picturePreview.Location = new Point(pOriginal.Location.X + pOriginal.Size.Width, pOriginal.Location.Y);

            pHidePreview.Location = new Point(pOriginal.Location.X + pOriginal.Size.Width - (pHidePreview.Size.Width / 2), pPreview.Size.Height - pHidePreview.Size.Height);
        }

        private void txtCorrectionGamma_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigitAndDecimalChar(sender as System.Windows.Forms.TextBox, e);
            ShowPreviewResult(UI_GetEreaderProfile(), CurrentImageEnhancementProfile);
        }


        void AllowOnlyDigitAndDecimalChar(System.Windows.Forms.TextBox textBox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;

            if (char.IsControl(e.KeyChar))
                return;

            e.Handled = true;

            if (textBox.Text.Contains(
                Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                return;

            textBox.Text += Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            textBox.SelectionStart = txtCorrectionGamma.TextLength;
            textBox.ScrollToCaret();
        }

        private void txtSigma_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigitAndDecimalChar(sender as System.Windows.Forms.TextBox, e);
            ShowPreviewResult(UI_GetEreaderProfile(), CurrentImageEnhancementProfile);
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            FileSystemUtilities.ClearTemporaryDirectories();
        }

        private void pbGenerateGammaScale_Click(object sender, EventArgs e)
        {
            var grayScalePdfFilePath = GammaScale.GenerateGammaLinearGreyGradientPdfPage(UI_GetEreaderProfile());

            var fi = new FileInfo(grayScalePdfFilePath);

            File.Copy(
                grayScalePdfFilePath,
                Path.Combine(txtPdfDirectory.Text, fi.Name),
                true);

            Directory.Delete(fi.Directory.FullName, true);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UI_SaveSelectedSettings();
            FileSystemUtilities.ClearTemporaryDirectories();
        }

        private void pbTest_Click(object sender, EventArgs e)
        {
            //TestBlobExtraction();
        }

        void TestNotEnoughPanelsFound()
        {
            //new PanelExtractor(electronicReaderProfile, comicConversionProfile, imageEnhancementProfile).SavePanelsAsFiles(page)
        }
        //void TestBlobExtraction()
        //{
        //    var profile = new ComicConversionProfile
        //    {
        //        MinimumPanelSizeHeightFraction = 10,
        //        MinimumPanelSizeWidthFraction = 10,
        //        PanelReadingDirection = PanelReadingDirection.RightToLeft,
        //        PanelDetectionAlgorithm = PanelDetectionAlgorithm.ByConnectedComponentsAndyWhiteLinesDetection,
        //        WhiteBackgroundTreshold = 200,
        //        InvertPages = true,
        //    };

        //    //OK: var filePath = @"D:\Dropbox\DEV\Git\Vs2017\ComicStripToKindle\ComicStripToKindle\Documents\PanelsHardToResolve\ByScan_Error_BIG.jpg";
        //    //OK: var filePath = @"D:\Dropbox\DEV\Git\Vs2017\ComicStripToKindle\ComicStripToKindle\Documents\PanelsHardToResolve\ByScanError_TooSmall.jpg";
        //    var filePath = @"D:\Dropbox\DEV\Git\Vs2017\ComicStripToKindle\ComicStripToKindle\Documents\PanelDirections\MangaTopToBottomRightToLeft.png";
        //    var image = Image.FromFile(filePath);

        //    var blobs = BitmapPanelExtractionFactory
        //        .Build(PanelDetectionAlgorithm.ByConnectedComponentsAndyWhiteLinesDetection)
        //        .ExtractBlobPanelsFromComicImagePage(new Bitmap(image), profile);

        //    var orderedBlobs = new PanelOrderingWithBlokkers().OrderPanels(blobs, profile.PanelReadingDirection, 15);

        //    Debug.WriteLine(orderedBlobs.Select(b => b.ID.ToString()).Aggregate((i, j) => i + ", " + j));
        //}

        static void TestPanelOrdering()
        {
            var blobs = new List<Blob>
            {
                //Regular line 3 panels
                {new Blob(1, new Rectangle(0, 0, 250, 200)) },
                {new Blob(2, new Rectangle(260, 0, 250, 200)) },
                {new Blob(3, new Rectangle(520, 0, 410, 200)) },

                //1 line panel
                {new Blob(4, new Rectangle(0, 255, 1000, 200)) },


                //1 column with two panel (up and down)
                {new Blob(5, new Rectangle(0, 460, 200, 300)) },
                {new Blob(6, new Rectangle(0, 770, 200, 210)) },

                //1 panel column
                {new Blob(7, new Rectangle(240, 460, 200, 540)) },//Blokker

                //Last column
                // 2 panels on a line
                {new Blob(8, new Rectangle(450, 460, 200, 200)) },
                {new Blob(9, new Rectangle(660, 460, 200, 200)) },
                // 1 panel on a line
                {new Blob(10, new Rectangle(450, 670, 400, 200)) },
                // 1 panel on a line
                {new Blob(11, new Rectangle(450, 880, 400, 100)) },
            };

            //UP->DOWN, LEFT->RIGHT

            //1st case most up, left
            var tolerance = 15;
            var orderedBlobs = new List<Blob>();
            //OrderPanelsRecursive(blobs, ref orderedBlobs, tolerance);

            Debug.WriteLine(orderedBlobs.Select(b => b.ID.ToString()).Aggregate((i, j) => i + ", " + j));
        }

        static void TestPanelOrdering2()
        {
            var blobs = new List<Blob>
            {
                //1 column, whole page height
                {new Blob(1, new Rectangle(0, 0, 200, 1000)) },

                //2nd column
                {new Blob(2, new Rectangle(202, 0, 200, 800)) },
                {new Blob(3, new Rectangle(202, 802, 200, 196)) },

                //3rd column
                {new Blob(4, new Rectangle(404, 0, 200, 200)) },
                {new Blob(5, new Rectangle(404, 202, 98, 200)) },
                {new Blob(6, new Rectangle(504, 202, 98, 200)) },
                {new Blob(7, new Rectangle(404, 404, 200, 200)) },

                //4st column
                {new Blob(8, new Rectangle(610, 0, 200, 1000)) },

            };

            //UP->DOWN, LEFT->RIGHT

            //1st case most up, left
            var tolerance = 15;
            var orderedBlobs = new PanelOrderingWithBlokkers().OrderPanels(blobs, PanelReadingDirection.RightToLeft, tolerance);

            Debug.WriteLine(orderedBlobs.Select(b => b.ID.ToString()).Aggregate((i, j) => i + ", " + j));
        }

        private void lvFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (var directoryPath in fileList.ToList().Where(x => Directory.Exists(x)).ToList())
            {
                var directories = Directory.EnumerateDirectories(directoryPath).ToList();

                if (null == directories || directories.Count() == 0)
                {
                    AddLVItem(directoryPath, new KindleConverter.ConversionProgressEventArgs { SourceFilePath = directoryPath });
                }
                else
                    foreach (var directory in directories)
                    {
                        AddLVItem(directory,
                            new KindleConverter.ConversionProgressEventArgs { SourceFilePath = directory });
                    }
            }

            foreach (var filePath in fileList.ToList().Where(x => File.Exists(x)))
            {
                if (AlreadyAdded(filePath))
                    continue;

                var fi = new FileInfo(filePath);
                AddLVItem(fi.Name, new KindleConverter.ConversionProgressEventArgs { SourceFilePath = filePath });
                _fileConversionProgress.Add(filePath, 0.0f);
            }
        }

        private void lvFiles_MouseDown(object sender, MouseEventArgs e)
        {
            //lvFiles.DoDragDrop(²


            //this.DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy);
        }

        private void lvFiles_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length > 0 && Directory.Exists(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void lvFiles_DragLeave(object sender, EventArgs e)
        {

        }

        private void pbConcatenate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] pdfFiles = Directory.GetFiles(txtPdfDirectory.Text, "*.pdf")
                                         .OrderBy(filename => filename)
                                         .ToArray();

                List<string> directoryParts = txtPdfDirectory.Text.Split('\\').ToList();

                string directory = string.Join("\\", directoryParts.Take(directoryParts.Count() - 1));
                string pfdFileName = $"{directory}\\{txtPdfFileName.Text}";
                PdfWriter.ConcatenatePdfFiles(pdfFiles, pfdFileName);

                Directory.Delete(txtPdfDirectory.Text, true);

                pbClearComicFiles_Click(sender, e);
            }
            catch { }
        }

        private void UI_SaveSelectedSettings()
        {

            Properties.Settings.Default.cbEReaderProfileSelectedIndex = cbEReaderProfile.SelectedIndex;
            Properties.Settings.Default.cbComicProfileSelectedIndex = cbComicProfile.SelectedIndex;
            Properties.Settings.Default.cbImageEnhancementProfileSelectedIndex = cbImageEnhancementProfile.SelectedIndex;

            Properties.Settings.Default.Save();
        }

        private void UI_LoadSelectedSettings()
        {
            try
            {
                if (PropertiesHasKey("cbEReaderProfileSelectedIndex"))
                    cbEReaderProfile.SelectedIndex = Properties.Settings.Default.cbEReaderProfileSelectedIndex;

                if (PropertiesHasKey("cbComicProfileSelectedIndex"))
                    cbComicProfile.SelectedIndex = Properties.Settings.Default.cbComicProfileSelectedIndex;

                if (PropertiesHasKey("cbImageEnhancementProfileSelectedIndex"))
                    cbImageEnhancementProfile.SelectedIndex = Properties.Settings.Default.cbImageEnhancementProfileSelectedIndex;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static bool PropertiesHasKey(string key)
        {
            foreach (SettingsProperty sp in Properties.Settings.Default.Properties)
            {
                if (sp.Name == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}