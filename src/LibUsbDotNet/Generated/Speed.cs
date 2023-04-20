//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright © 2006-2010 Travis Robinson. All rights reserved.
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

namespace LibUsbDotNet
{
    /// <summary>
    ///  Speed codes. Indicates the speed at which the device is operating.
    /// </summary>
    [Flags]
    public enum Speed : byte
    {
        /// <summary>
        ///  The OS doesn't report or know the device speed. 
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///  The device is operating at low speed (1.5MBit/s). 
        /// </summary>
        Low = 0x1,

        /// <summary>
        ///  The device is operating at full speed (12MBit/s). 
        /// </summary>
        Full = 0x2,

        /// <summary>
        ///  The device is operating at high speed (480MBit/s). 
        /// </summary>
        High = 0x3,

        /// <summary>
        ///  The device is operating at super speed (5000MBit/s). 
        /// </summary>
        Super = 0x4,

    }
}
