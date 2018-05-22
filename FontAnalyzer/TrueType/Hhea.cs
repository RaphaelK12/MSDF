﻿// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Hhea : KaitaiStruct
    {
        public static Hhea FromFile(string fileName)
        {
            return new Hhea(new KaitaiStream(fileName));
        }

        public Hhea(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._version = new Fixed(this.m_io, this, this.m_root);
            this._ascender = this.m_io.ReadS2be();
            this._descender = this.m_io.ReadS2be();
            this._lineGap = this.m_io.ReadS2be();
            this._advanceWidthMax = this.m_io.ReadU2be();
            this._minLeftSideBearing = this.m_io.ReadS2be();
            this._minRightSideBearing = this.m_io.ReadS2be();
            this._xMaxExtend = this.m_io.ReadS2be();
            this._caretSlopeRise = this.m_io.ReadS2be();
            this._caretSlopeRun = this.m_io.ReadS2be();
            this._reserved = this.m_io.EnsureFixedContents(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            this._metricDataFormat = this.m_io.ReadS2be();
            this._numberOfHmetrics = this.m_io.ReadU2be();
        }
        private Fixed _version;
        private short _ascender;
        private short _descender;
        private short _lineGap;
        private ushort _advanceWidthMax;
        private short _minLeftSideBearing;
        private short _minRightSideBearing;
        private short _xMaxExtend;
        private short _caretSlopeRise;
        private short _caretSlopeRun;
        private byte[] _reserved;
        private short _metricDataFormat;
        private ushort _numberOfHmetrics;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public Fixed Version { get { return this._version; } }

        /// <summary>
        /// Typographic ascent
        /// </summary>
        public short Ascender { get { return this._ascender; } }

        /// <summary>
        /// Typographic descent
        /// </summary>
        public short Descender { get { return this._descender; } }

        /// <summary>
        /// Typographic line gap. Negative LineGap values are treated as zero in Windows 3.1, System 6, and System 7.
        /// </summary>
        public short LineGap { get { return this._lineGap; } }

        /// <summary>
        /// Maximum advance width value in `hmtx` table.
        /// </summary>
        public ushort AdvanceWidthMax { get { return this._advanceWidthMax; } }

        /// <summary>
        /// Minimum left sidebearing value in `hmtx` table.
        /// </summary>
        public short MinLeftSideBearing { get { return this._minLeftSideBearing; } }

        /// <summary>
        /// Minimum right sidebearing value; calculated as Min(aw - lsb - (xMax - xMin)).
        /// </summary>
        public short MinRightSideBearing { get { return this._minRightSideBearing; } }

        /// <summary>
        /// Max(lsb + (xMax - xMin)).
        /// </summary>
        public short XMaxExtend { get { return this._xMaxExtend; } }
        public short CaretSlopeRise { get { return this._caretSlopeRise; } }
        public short CaretSlopeRun { get { return this._caretSlopeRun; } }
        public byte[] Reserved { get { return this._reserved; } }
        public short MetricDataFormat { get { return this._metricDataFormat; } }
        public ushort NumberOfHmetrics { get { return this._numberOfHmetrics; } }
        public Ttf M_Root { get { return this.m_root; } }
        public DirTableEntry M_Parent { get { return this.m_parent; } }
    }
}