using System;
using System.Collections.Generic;
using System.Text;
using Komponent.IO.Attributes;

namespace BraveFilesystemParser.Models
{
    class IndexEntry
    {
        public int NextFileOffset { get; set; }

        public int FileOffset { get; set; }

        public int FileSize { get; set; }

        public uint FileNameHash { get; set; }

        public string FileName { get; set; }
    }
}
