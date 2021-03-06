using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace Transition
{
	public class StaticTile
	{
		private short m_TileID;

		private short m_AltIDMod;

		public short AltIDMod
		{
			get
			{
				return this.m_AltIDMod;
			}
			set
			{
				this.m_AltIDMod = value;
			}
		}

		public short TileID
		{
			get
			{
				return this.m_TileID;
			}
			set
			{
				this.m_TileID = value;
			}
		}

		public StaticTile()
		{
		}

		public StaticTile(short TileID, short AltIDMod)
		{
			this.m_TileID = TileID;
			this.m_AltIDMod = AltIDMod;
		}

		public StaticTile(XmlElement xmlInfo)
		{
			this.m_TileID = XmlConvert.ToInt16(xmlInfo.GetAttribute("TileID"));
			this.m_AltIDMod = XmlConvert.ToInt16(xmlInfo.GetAttribute("AltIDMod"));
		}

		public void Save(XmlTextWriter xmlInfo)
		{
			xmlInfo.WriteStartElement("StaticTile");
			xmlInfo.WriteAttributeString("TileID", StringType.FromInteger(this.m_TileID));
			xmlInfo.WriteAttributeString("AltIDMod", StringType.FromInteger(this.m_AltIDMod));
			xmlInfo.WriteEndElement();
		}

		public override string ToString()
		{
			string str = string.Format("{0:X4} [{1}]", this.m_TileID, this.m_AltIDMod);
			return str;
		}
	}
}