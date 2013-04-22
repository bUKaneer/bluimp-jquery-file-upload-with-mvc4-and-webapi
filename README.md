bluimp-jquery-file-upload-with-mvc4-and-webapi
==============================================

This is an implementation of BluImp's jQuery FileUpload widget. This is my first attempt at using Git and was slightly nervous about forking so I've created this repo for the time being until I'm more familiar with Git.

The original BluImp version is here https://github.com/blueimp/jQuery-File-Upload

I've additionally made extensive use of Max Pavlovs MVC3 & HttpHandler code within the WebAPI controller that version can be found here https://github.com/maxpavlov/jQuery-File-Upload.MVC3

By using this you are bound by the T&C's and licenses on the aforementioned projects and pages.

Huge thanks to the BluImp Team and Max Pavlov who really did all the heavy lifting.

This implementation uses a single WebAPI controller to manage the server-side aspects of the code and is a fairly rough cut version which I tested in the latest Firefox, Chrome version and in IE9. Anything else is anyone's guess!

Please feel free to leave me some feedback via Twitter here https://twitter.com/bUKaneer I hope you find this useful and it saves you some time!

**Main Changes from Max Pavlovs' Implementation:**

ClientDependancy 3rd party javascript/css minification removed and replaced with native Bundling where appropriate.

HttpHandler code ported into a basic WebAPI controller with new Thumbnail generation code.

Newer versions of jQuery File Upload script files used.

Newer version of jQuery used - now version 1.9.1 (I think!).

**Other (potential) points of Interest:**

This implementation was created using Visual Studio 2012 using an Empty ASP.NET MVC 4 project type to ensure only the absolute basics were needed to get it working and reduce and confusion or bloat.