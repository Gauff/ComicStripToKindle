﻿namespace ComicStripToKindle.Profiles
{
    public class ImageEnhancementProfile
    {
        public string Name { get; set; }
        public bool AutomaticRotation { get; set; }
        public float RotationAngle { get; set; }

        public bool AutomaticContrastCorrection { get; set; }

        public bool Sharpen { get; set; }

        public bool GaussianSharpen { get; set; }
        public float Sigma { get; set; }
        public int Kernel { get; set; }

        public int JpegQuality { get; set; }

        public bool LevelThreshold { get; set; }
        public int WhiteLevel { get; set; }
        public int BlackLevel { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
