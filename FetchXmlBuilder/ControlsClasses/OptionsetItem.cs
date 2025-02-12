﻿using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XTB.XmlEditorUtils;

namespace Rappen.XTB.FetchXmlBuilder.ControlsClasses
{
    internal class OptionsetItem : IComboBoxItem
    {
        private OptionMetadata meta = null;

        public OptionsetItem(OptionMetadata Option)
        {
            meta = Option;
        }

        public override string ToString()
        {
            return meta.Label.UserLocalizedLabel.Label + " (" + meta.Value.ToString() + ")";
        }

        public string GetValue()
        {
            return meta.Value.ToString();
        }
    }
}