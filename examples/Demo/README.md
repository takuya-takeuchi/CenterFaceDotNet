# Demo

This example demonstrates detecting faces from images file.
This program is ported by C# from https://github.com/Star-Clouds/CenterFace/blob/master/prj-ncnn/demo.cpp.

## How to use?

## 1. Preparation

This example requires test images, model adn parameter files. 
Download test data from the following urls.

- https://github.com/Star-Clouds/CenterFace/tree/master/models/ncnn
  - centerface.bin
  - centerface.param

And copy to these files to &lt;Demo_dir&gt;.

## 2. Build

1. Open command prompt and change to &lt;Demo_dir&gt;
1. Type the following command
````
dotnet build -c Release
````

## 3. Run

1. Open command prompt and change to &lt;Demo_dir&gt;
1. Type the following sample command
````
$ dotnet run -c Release -- centerface.bin centerface.param test.jpg

Processing .\test.jpg
````

![Demo](images/image.jpg "Demo")