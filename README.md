Jucardi Duplicates Finder
=========================

Simple desktop application built in .NET using Windows Forms


#### How it works

The process is done in two steps

1. A dictionary of file size and list of file names is generated, to associate
all files with the same size.
2. Once the dictionary is generated, MD5 is calculated per file per list of files
of at least 2 files with matching sizes.
3. The MD5 obtained is compared, if the MD5 matches, the file is considered a duplicated.

#### After the duplicates are found

This application provides a GUI to verify the duplicates with viewers for certain
file types, which allows to take actions on the duplicates, such as delete.

The following displayers are supported:
- Image Displayer
- Office Displayer (for Microsoft Office files).
- Text Displayer (for plain text files).
- Web Displayer.
