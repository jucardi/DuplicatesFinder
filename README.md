Jucardi Duplicates Finder
=========================

> Copyright 2013



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

#### How to use

1) Select the path where duplicates might be present and start the process by clicking on `Find`
![alt text](http://66.media.tumblr.com/a6d9b3496037bbc8060fb5f1de111a60/tumblr_ofq3ce4sDY1vjx81ko2_1280.png "Main Window")

2) The progress is shown, first the size comparison, and then the duplicates confirmation by hash.
![alt text](http://65.media.tumblr.com/4cafed477be4431f65d8a48061247df8/tumblr_ofq3ce4sDY1vjx81ko1_1280.png "Find in progress")

3) The results for duplicates are found. Notice the color grouping for duplicates, in this case we have `Arizona Luxury Hones-0.jpg` and `some-other-house.jpg` that are duplicates, grouped and colored the same for distinction.

Same thing with `Harmony-Mountain-Estate...` and `mountain-house.jpg`

And finally the third duplicate group would be `Luxury-Absolute-Auction...`, `some-house.jpg` and `some-folder\Luxury-Absolute-Auction...`
![alt text](http://67.media.tumblr.com/09756b50857ac7d6857fd58b8653a4d5/tumblr_ofq3ce4sDY1vjx81ko3_1280.png "Results found")

4) Preview. For some file types, (images, text files, office files, pdf), the files may be previewed on the right side panel when selecting.
![alt text](http://67.media.tumblr.com/68c6416bdf67479001e0d4970111f5b8/tumblr_ofq3ce4sDY1vjx81ko4_1280.png "Image preview")

5) Taking action in a duplicate file. When selecting one duplicate, the `DELETE` key may be pressed to delete a duplicate file, a confirmation will be displayed.
![alt text](http://65.media.tumblr.com/2b74cae0a4437a69385b4de165e77982/tumblr_ofq3ce4sDY1vjx81ko5_1280.png "Delete confirmation")
