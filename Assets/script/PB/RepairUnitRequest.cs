//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RepairUnitRequest.proto
// Note: requires additional types generated from: ApiRequest.proto
// Note: requires additional types generated from: Unit.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RepairUnitRequest")]
  public partial class RepairUnitRequest : global::ProtoBuf.IExtensible
  {
    public RepairUnitRequest() {}
    
    private ApiRequest _api = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"api", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ApiRequest api
    {
      get { return _api; }
      set { _api = value; }
    }
    private readonly global::System.Collections.Generic.List<Unit> _units = new global::System.Collections.Generic.List<Unit>();
    [global::ProtoBuf.ProtoMember(2, Name=@"units", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Unit> units
    {
      get { return _units; }
    }
  
    private int _buyCd = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"buyCd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int buyCd
    {
      get { return _buyCd; }
      set { _buyCd = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}