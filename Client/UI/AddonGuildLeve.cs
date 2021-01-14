﻿using FFXIVClientStructs.Component.GUI;
using System.Runtime.InteropServices;

namespace FFXIVClientStructs.Client.UI
{
    // Client::UI::AddonGuildLeve
    //   Component::GUI::AtkUnitBase
    //     Component::GUI::AtkEventListener
    [StructLayout(LayoutKind.Explicit, Size = 0x17F0)]
    public unsafe struct AddonGuildLeve
    {
        [FieldOffset(0x0)] public AtkUnitBase AtkUnitBase;
        [FieldOffset(0x228)] public AtkComponentTreeList* AtkComponentTreeList228;
        [FieldOffset(0x230)] public AtkComponentRadioButton* FieldcraftButton;
        [FieldOffset(0x238)] public AtkComponentRadioButton* TradecraftButton;

        [FieldOffset(0x248)] public AtkComponentRadioButton* CarpenterButton;
        [FieldOffset(0x250)] public AtkComponentRadioButton* BlacksmithButton;
        [FieldOffset(0x258)] public AtkComponentRadioButton* ArmorerButton;
        [FieldOffset(0x260)] public AtkComponentRadioButton* GoldsmithButton;
        [FieldOffset(0x268)] public AtkComponentRadioButton* LeatherworkerButton;
        [FieldOffset(0x270)] public AtkComponentRadioButton* WeaverButton;
        [FieldOffset(0x278)] public AtkComponentRadioButton* AlchemistButton;
        [FieldOffset(0x280)] public AtkComponentRadioButton* CulinarianButton;

        [FieldOffset(0x248)] public AtkComponentRadioButton* MinerButton;
        [FieldOffset(0x250)] public AtkComponentRadioButton* BotanistButton;
        [FieldOffset(0x258)] public AtkComponentRadioButton* FisherButton;

        [FieldOffset(0x288)] public AtkResNode* AtkResNode288;

        [FieldOffset(0x290)] public FFXIVString CarpenterString;
        [FieldOffset(0x2F8)] public FFXIVString BlacksmithString;
        [FieldOffset(0x360)] public FFXIVString ArmorerString;
        [FieldOffset(0x3C8)] public FFXIVString GoldsmithString;
        [FieldOffset(0x430)] public FFXIVString LeatherworkerString;
        [FieldOffset(0x498)] public FFXIVString WeaverString;
        [FieldOffset(0x500)] public FFXIVString AlchemistString;
        [FieldOffset(0x568)] public FFXIVString CulinarianString;

        [FieldOffset(0x290)] public FFXIVString MinerString;
        [FieldOffset(0x2F8)] public FFXIVString BotanistString;
        [FieldOffset(0x360)] public FFXIVString FisherString;

        [FieldOffset(0x5D0)] public AtkComponentButton* JournalButton;
        [FieldOffset(0x5D8)] public AtkTextNode* AtkTextNode298;
        [FieldOffset(0x5E0)] public AtkComponentBase* AtkComponentBase290;
        [FieldOffset(0x5E8)] public AtkComponentBase* AtkComponentBase298;
    }
}