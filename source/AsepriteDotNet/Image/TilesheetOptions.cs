/* ----------------------------------------------------------------------------
MIT License

Copyright (c) 2022 Christopher Whitley

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
---------------------------------------------------------------------------- */
namespace AsepriteDotNet.Image;

/// <summary>
///     Represents the options to adhere to when generating a new tilesheet.
/// </summary>
public sealed class TilesheetOptions
{
    /// <summary>
    ///     Gets or Sets a value that indicates whether duplicate tiles should
    ///     be merged into a single tile.
    /// </summary>
    public bool MergeDuplicates { get; set; } = true;

    /// <summary>
    ///     Gets or Sets the <see cref="AsepriteDotNet.Image.PackingMethod"/> 
    ///     to use when generating the tilesheets.
    /// </summary>
    public PackingMethod PackingMethod { get; set; } = PackingMethod.SquarePacked;

    /// <summary>
    ///     Gets or Sets the amount of transparent pixels to add between each
    ///     tile and the edge of the tilesheet.
    /// </summary>
    public int BorderPadding { get; set; } = 0;

    /// <summary>
    ///     Gets or Sets the amount of transparent pixels to add between each
    ///     tile.
    /// </summary>
    public int Spacing { get; set; } = 0;

    /// <summary>
    ///     Gets or Sets the amount of transparent pixels to add to the inside
    ///     of each tiles edge. 
    /// </summary>
    public int InnerPadding { get; set; } = 0;
}