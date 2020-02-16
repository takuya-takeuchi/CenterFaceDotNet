# Benchmark

This example demonstrates performance of detecting faces from images file.

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
$ dotnet run -c Release -- centerface.bin centerface.param test.jpg 100

Processing test.jpg
100.00% Step 100 of 100                                                                                                                        00:01:24───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
Total Loop 100
        Convert Image to Mat: Total 30998 ms, Avg 309.98 ms
                 Detect Face: Total 4176183 ms, Avg 41761.83 ms
            Total Throughput: Total 4207181 ms, Avg 42071.81 ms
````