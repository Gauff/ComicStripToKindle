# E-readers Comic Book Adapter

A tool to easily visualize comic books on any e-book reader.

The ideas: 
- Maximize panel size
- Tap the screen to see the next panel!

![screenshot](https://github.com/Gauff/ComicStripToKindle/blob/master/screenshot.png)

This tool processes PDF comic files by: 
- Extracting individual panels
- Adjusting the panels according to your e-reader screen size
- Improve output quality
- Generate a PDF file you can easily read on your device


# In a nutshell

1. Define your e-reader profile
   Resolution, gamma, color/grayscale.
 
2. Set up the panel extraction profile
   Panel detection algorithm, skew check, page split, directions, background color, panel minimum side.
 
3. Set up the outputs
   Directory and email
 
4. Select the comics PDF files

5. Adjust image in preview mode 
   Apply and adjust enhancement profiles in real time: automatic rotation, levels, contrast, sharpening, and JPEG quality.

6. Click on "generate" when happy with the preview


## About this Project

At times, during the night, I get these silly ideas... like when my daughter was learning to read.
"I wonder if she could read a comic book on that old 6" Kindle?"
This is a past pet project crafted in C# from before the surge of Python machine/deep learning hype.
  
It uses the following  (deprecated) libraries:
- AForge
- iTextSharp
I share it as it was.

## License

This project is licensed under the MIT License.
