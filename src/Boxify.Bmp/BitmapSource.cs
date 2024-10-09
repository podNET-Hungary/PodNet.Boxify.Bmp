using System.Drawing;

namespace PodNet.Boxify.Bmp;

/// <summary>An <see cref="IBoxBitmapSource"/> that wraps (proxies calls to) an underlying bitmap image using System.Drawing, so 
/// that it can be used to render box-art using <see cref="Renderer"/>.</summary>
/// <remarks>Note that this is not a framework component for Boxify but a convenience class to be invoked directly by user code.</remarks>
/// <param name="bitmap">The bitmap instance to wrap.</param>
public sealed class BitmapSource(Bitmap bitmap) : IBoxBitmapSource, IDisposable
{
    /// <summary>The wrapped raw bitmap instance.</summary>
    public Bitmap Bitmap { get; } = bitmap;

    /// <summary>The width of the rasterized bitmap (in pixel count).</summary>
    public int Width => Bitmap.Width;

    /// <summary>The height of the rasterized bitmap (in pixel count).</summary>
    public int Height => Bitmap.Height;

    /// <inheritdoc/>
    public Color GetPixel(int x, int y) => Bitmap.GetPixel(x, y);

    /// <summary>Disposes of the underlying bitmap.</summary>
    public void Dispose() => Bitmap.Dispose();

    /// <summary>Implicitly converts the provided bitmap to a <see cref="BitmapSource"/>.</summary>
    /// <param name="bitmap">The image to wrap.</param>
    public static implicit operator BitmapSource(Bitmap bitmap) => new(bitmap);
}
