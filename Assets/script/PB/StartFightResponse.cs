//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: StartFightResponse.proto
// Note: requires additional types generated from: ApiResponse.proto
// Note: requires additional types generated from: PVPUser.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StartFightResponse")]
  public partial class StartFightResponse : global::ProtoBuf.IExtensible
  {
    public StartFightResponse() {}
    
    private ApiResponse _response = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"response", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ApiResponse response
    {
      get { return _response; }
      set { _response = value; }
    }
    private int _fightId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private PVPUser _pvpUser = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pvpUser", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PVPUser pvpUser
    {
      get { return _pvpUser; }
      set { _pvpUser = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}