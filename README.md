# PodNet.Boxify.Bmp [![NuGet](https://img.shields.io/nuget/v/PodNet.Boxify.Bmp)](https://www.nuget.org/packages/PodNet.Boxify.Bmp/)
An extension for [`PodNet.Boxify`](https://github.com/podNET-Hungary/PodNet.Boxify/) that wraps `System.Drawing.Bitmap` for drawing box-drawings of images to text, files or terminals

## Usage

This NuGet package contains a simple implementation of [`PodNet.Boxify`](https://github.com/podNET-Hungary/PodNet.Boxify/)'s `IBoxBitmapSource`, that wraps a `System.Drawing.Bitmap` from [`System.Drawing.Common`](https://www.nuget.org/packages/System.Drawing.Common/).

This is only used to provide the bridge between `PodNet.Boxify` and a commonly used bitmap source, but you should consider implementing `IBoxBitmapSource` yourself if you already have an image representation in your application to avoid taking a dependency on another image manipulation library.

```csharp
var bmp = new Bitmap("mybmp.bmp");
using var source = new BitmapSource(bmp);
var boxArt = Renderer.Default.Render(source, PixelPalette.Halves);
```

There are no additional options for resizing, colorizing or applying effects. Do note that the renderer will render a character for each pixel into the resulting string, so any additional image manipulation you have to do yourself prior to rendering to the string (or do the manipulation, specifically the resizing and transformations in your custom wrapper).

For details on how to use [`PodNet.Boxify`](https://github.com/podNET-Hungary/PodNet.Boxify/), see the repo at https://github.com/podNET-Hungary/PodNet.Boxify/.

This package is also required by [`PodNet.Boxify.Svg`](https://github.com/podNET-Hungary/PodNet.Boxify.Svg/) that allows converting SVG vector-based images to bitmaps so that they can in turn be converted to box-drawings.

## Contributing and Support

This project is intended to be widely usable, but no warranties are provided. If you want to contact us, feel free to do so in the org's [[Discussions](https://github.com/orgs/podNET-Hungary/discussions/)], at our website at [podnet.hu](https://podnet.hu), or find us anywhere from [LinkedIn](https://www.linkedin.com/company/podnet-hungary/) to [Meetup](https://www.meetup.com/budapest-net-meetup/), [YouTube](https://www.youtube.com/@podNET) or [X](https://twitter.com/podNET_Hungary).

Any kinds of contributions from issues to PRs and open discussions are welcome!

Don't forget to give us a ⭐ if you like this repo (it's free to give kudos!) or share it on socials!

## Sponsorship

If you're using our work or like what you see, consider supporting us. Every bit counts. 🙏 [See here for more info.](https://github.com/podNET-Hungary/PodNet.NuGet.Core/blob/main/src/PodNet.NuGet.Core/build/SPONSORS.md)