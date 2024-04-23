# E-readers Comic Book Adapter

A tool to easily visualize comic books on any e-book reader.

The ideas: 
- Maximize panel size
- Tap the screen to see the next panel!

![screenshot](https://github.com/Gauff/ComicStripToKindle/blob/master/screenshot.png)

This tool processes comic files (PDF, CBR, CBZ, zip archives and directories of them) by: 
- Extracting individual panels
- Adjusting the panels according to your e-reader screen size
- Improve output quality
- Generate a PDF file you can easily read on your device


# In a nutshell

## Define your e-reader profile
![ereader profile](https://github.com/Gauff/ComicStripToKindle/blob/master/resources/screenshots/ereaderProfile.png)
Resolution, gamma, color/grayscale.

## Set up the comic profile
![comic profile](https://github.com/Gauff/ComicStripToKindle/blob/master/resources/screenshots/comicProfile.png)
Panel detection algorithm, skew check, page split, directions, background color, panel minimum side.
 
## Set up the outputs
![output profile](https://github.com/Gauff/ComicStripToKindle/blob/master/resources/screenshots/outputProfile.png)
Local directory, email, upload on ereader by USB
 
## Select the comics files 
PDF, CBR, CBZ, and zip archives or directories
Using 'Add Comic files', 'Add Comic Directory', or simply by drag and grop on the file list area.

## Enter preview mode
Click on a file to enter preview mode
![preview](https://github.com/Gauff/ComicStripToKindle/blob/master/resources/screenshots/preview.png)

## Adjust image in real time
![adjust images](https://github.com/Gauff/ComicStripToKindle/blob/master/resources/screenshots/imageEnhancementProfile.png)
Apply and adjust enhancement profiles in real time: automatic rotation, levels, contrast, sharpening, and JPEG quality.

## Click on "Convert to PDF" when happy with the preview

## Bonus Utility : concatenate all PDF files from a directory
Choose directory, Write output file name, click 'Concatenate'
![concatenate](https://github.com/Gauff/ComicStripToKindle/blob/master/resources/screenshots/concatenate.png)


# About this Project

At times, during the night, I get these silly ideas... like when my daughter was learning to read.
"I wonder if she could read a comic book on that old 6" Kindle?"
This is a past pet project crafted in C# from before the surge of Python machine/deep learning hype.
  
It uses the following  (deprecated) libraries:
- AForge
- iTextSharp
I share it as it was.

## License

This project is licensed under the MIT License.
