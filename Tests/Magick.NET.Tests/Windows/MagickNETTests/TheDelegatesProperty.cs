﻿// Copyright 2013-2018 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

#if WINDOWS_BUILD

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
    public partial class MagickNETTests
    {
        [TestClass]
        public class TheDelegatesProperty
        {
            [TestMethod]
            public void ShouldReturnAllDelegates()
            {
                Assert.AreEqual("cairo flif freetype gslib heic jng jp2 jpeg lcms lqr openexr pangocairo png ps raw rsvg tiff webp xml zlib", MagickNET.Delegates);
            }
        }
    }
}

#endif