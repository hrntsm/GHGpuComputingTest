# GHGpuComputingTest

Test using CUDA with [Alea GPU](http://www.aleagpu.com/release/3_0_4/doc/) in grasshopper.

The Alea link above seems to be broken, so if you need it, get it from Nuget.

## TestResult

Comparison between using the Sum and Average methods of the Alea GPU and using the components originally in GH.  
Sum is faster with Alea, but Average is not much different.

<img src="./image/test_result.gif" width="500">

## Environment

- Environment of the above image
  - Windows10
  - Memory 32GB
  - CPU i7-6700K
  - GPU GTX1060 3GB
- Also tested to work
  - Windows10
  - Memory 64GB
  - CPU Ryzen 9 3900XT
  - GPU RTX 2080 Ti 11GB

## Use Alea to your component

To use Alea, you need not only the Alea Nuget package, but also the FSharp.Core package.

- [Alea](https://www.nuget.org/packages/Alea/)
- [FSharp.Core](https://www.nuget.org/packages/FSharp.Core/)

After building the Grasshopper component, put the following files from the bin folder into Rhino's System folder.

- Alea.CUDA.CT.LibDevice
- Alea.CUDA.CT.Native.X86.Bxx.xxxxxx
  - chose your pc environment folder.
  - For 64bit Windows, it is X86.B64.Windows.
