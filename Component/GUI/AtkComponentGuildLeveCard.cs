﻿using System.Runtime.InteropServices;

namespace FFXIVClientStructs.Component.GUI
{
    // Component::GUI::AtkComponentGuildLeveCard
    //   Component::GUI::AtkComponentBase
    //     Component::GUI::AtkEventListener

    // size = 0xF0
    // common CreateAtkComponent function 8B FA 33 DB E8 ? ? ? ? 
    // type ?
    [StructLayout(LayoutKind.Explicit, Size = 0xF0)]
    public unsafe struct AtkComponentGuildLeveCard
    {
        [FieldOffset(0x0)] public AtkComponentBase AtkComponentBase;
    }
}