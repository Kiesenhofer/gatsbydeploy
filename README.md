# Frame Extruder
[![](https://img.shields.io/github/downloads/lgibson02/FrameExtruder/total.svg?style=social)](https://github.com/lgibson02/FrameExtruder/releases)

Designed for getting around [edge bleeding issues](https://web.archive.org/web/20180411151113/http://rotorz.com/unity/tile-system/docs/edge-correction) found in the [Phaser](https://github.com/photonstorm/phaser) game engine when using spritesheets and tilesets. It works in the same way as the [tile-extruder](https://github.com/sporadic-labs/tile-extruder) by [@mikewesthad](https://github.com/mikewesthad) except it has a gui, does not have to be called from a terminal and doesn't require nodejs.

It is written in C# using Microsoft .NET 2.0 and has been designed and tested for use on Windows systems. However for use on other operating systems, my testing on a Debian system shows that using Mono seems to work [quite nicely](https://i.imgur.com/ivHR2Ln.png) besides some minor control size issues that need to be fixed.

![](ht