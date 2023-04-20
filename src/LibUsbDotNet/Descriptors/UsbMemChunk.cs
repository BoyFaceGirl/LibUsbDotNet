﻿// Copyright © 2006-2010 Travis Robinson. All rights reserved.
// Copyright © 2011-2023 LibUsbDotNet contributors. All rights reserved.
// 
// website: http://github.com/libusbdotnet/libusbdotnet
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
//

using System;
using System.Runtime.InteropServices;

namespace LibUsbDotNet.Descriptors
{
    internal abstract class UsbMemChunk
    {
        private readonly int mMaxSize;

        private IntPtr mMemPointer = IntPtr.Zero;

        protected UsbMemChunk(int maxSize)
        {
            this.mMaxSize = maxSize;
            this.mMemPointer = Marshal.AllocHGlobal(maxSize);
        }

        public int MaxSize
        {
            get { return this.mMaxSize; }
        }

        public IntPtr Ptr
        {
            get { return this.mMemPointer; }
        }

        public void Free()
        {
            if (this.mMemPointer != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(this.mMemPointer);
                this.mMemPointer = IntPtr.Zero;
            }
        }

        ~UsbMemChunk()
        {
            this.Free();
        }
    }
}
