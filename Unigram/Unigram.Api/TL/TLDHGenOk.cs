// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDHGenOk : TLSetClientDHParamsAnswerBase 
	{
		public TLInt128 NewNonceHash1 { get; set; }

		public TLDHGenOk() { }
		public TLDHGenOk(TLBinaryReader from, TLType type = TLType.DHGenOk)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.DHGenOk; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.DHGenOk)
		{
			Nonce = new TLInt128(from);
			ServerNonce = new TLInt128(from);
			NewNonceHash1 = new TLInt128(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3BCBF734);
			to.WriteObject(Nonce);
			to.WriteObject(ServerNonce);
			to.WriteObject(NewNonceHash1);
		}
	}
}