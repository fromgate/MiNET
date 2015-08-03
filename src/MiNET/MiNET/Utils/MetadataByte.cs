using System.IO;

namespace MiNET.Utils
{
	public class MetadataByte : MetadataEntry
	{
		public override byte Identifier
		{
			get { return 0; }
		}

		public override string FriendlyName
		{
			get { return "byte"; }
		}

		public byte Value { get; set; }

		public static implicit operator MetadataByte(byte value)
		{
			return new MetadataByte(value);
		}

		public MetadataByte()
		{
		}

		public MetadataByte(bool value)
		{
			Value = (byte) (value ? 1 : 0);
		}

		public MetadataByte(byte value)
		{
			Value = value;
		}

		public override void FromStream(BinaryReader stream)
		{
			Value = stream.ReadByte();
		}

		public override void WriteTo(BinaryWriter stream, byte index)
		{
			stream.Write(GetKey(index));
			stream.Write(Value);
		}

		public override string ToString()
		{
			return string.Format("{0} {1} {2}", FriendlyName, Identifier, Value);
		}
	}
}