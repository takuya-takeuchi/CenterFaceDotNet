# ![Alt text](nuget/face48.png "CenterFaceDotNet") CenterFaceDotNet [![GitHub license](https://img.shields.io/github/license/mashape/apistatus.svg)]() [![codecov](https://codecov.io/gh/takuya-takeuchi/CenterFaceDotNet/branch/master/graph/badge.svg)](https://codecov.io/gh/takuya-takeuchi/CenterFaceDotNet)

C# version of CenterFace
This repository is porting https://github.com/Star-Clouds/CenterFace by C#.

This package supports cross platform, Windows, Linux and MacOSX!!

|Package|OS|x86|x64|ARM|ARM64|Nuget|
|---|---|---|---|---|---|---|
|CenterFaceDotNet (CPU)|Windows|-|✓|-|-|[![NuGet version](https://img.shields.io/nuget/v/CenterFaceDotNet.svg)](https://www.nuget.org/packages/CenterFaceDotNet)|
||Linux|-|✓|-|-|[![NuGet version](https://img.shields.io/nuget/v/CenterFaceDotNet.svg)](https://www.nuget.org/packages/CenterFaceDotNet)|
||OSX|-|✓|-|-|[![NuGet version](https://img.shields.io/nuget/v/CenterFaceDotNet.svg)](https://www.nuget.org/packages/CenterFaceDotNet)|
|CenterFaceDotNet (GPU)|Windows|-|✓|-|-|[![NuGet version](https://img.shields.io/nuget/v/CenterFaceDotNet.GPU.svg)](https://www.nuget.org/packages/CenterFaceDotNet.GPU)|
||Linux|-|✓|-|-|[![NuGet version](https://img.shields.io/nuget/v/CenterFaceDotNet.GPU.svg)](https://www.nuget.org/packages/CenterFaceDotNet.GPU)|
||OSX|-|✓|-|-|[![NuGet version](https://img.shields.io/nuget/v/CenterFaceDotNet.GPU.svg)](https://www.nuget.org/packages/NcnnDotNet.GPU)|

## Demo

<img src="examples/Demo/images/image.jpg" width="480"/>

## Dependencies Libraries and Products

#### [CenterFace](https://github.com/Star-Clouds/CenterFace/)

> **License:** The MIT License
>
> **Author:** StarClouds
> 
> **Principal Use:** Practical anchor-free face detection and alignment method for edge devices. Main goal of CenterFaceDotNet is what ports CenterFace by C#.

#### [ncnn](https://github.com/Tencent/ncnn/)

> **License:** The BSD 3-Clause License
>
> **Author:** THL A29. Limited, a Tencent company
> 
> **Principal Use:** A high-performance neural network inference framework optimized for the mobile platform in C++. Main goal of NcnnDotNet is what wraps ncnn by C#.

#### [OpenCV](https://opencv.org/)

> **License:** The BSD 3-Clause License
>
> **Author:** Intel Corporation, Willow Garage, Itseez
> 
> **Principal Use:** Uses to read and show image data.

#### [NcnnDotNet](https://github.com/takuya-takeuchi/NcnnDotNet/)

> **License:** The MIT License
>
> **Author:** Takuya Takeuchi
> 
> **Principal Use:** Use ncnn interface via .NET. This library is developed by this owner.

#### [ShellProgressBar](https://github.com/Mpdreamz/shellprogressbar/)

> **License:** The MIT License
>
> **Author:** Martijn Laarman
> 
> **Principal Use:** Visualize progress in Benchmark program.

