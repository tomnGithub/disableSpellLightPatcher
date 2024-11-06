using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;
using System.ComponentModel;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Synthesis.Bethesda.Commands;

namespace disableSpellLightPatcher
{
    public record Settings
    {

        [SettingName("Alteration")]
        public bool AltOn { get; set; } = true; // Default is on

        [SettingName("Conjuration")]
        public bool ConjOn { get; set; } = true; // Default is on

        [SettingName("Destruction")]
        public bool DestOn { get; set; } = true; // Default is on

        [SettingName("Illusion")]
        public bool IllOn { get; set; } = true; // Default is on

        [SettingName("Restoration")]
        public bool RestOn { get; set; } = true; // Default is on


    }

    





}

