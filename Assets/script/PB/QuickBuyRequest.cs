//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: QuickBuyRequest.proto
// Note: requires additional types generated from: ApiRequest.proto
// Note: requires additional types generated from: Production.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QuickBuyRequest")]
  public partial class QuickBuyRequest : global::ProtoBuf.IExtensible
  {
    public QuickBuyRequest() {}
    
    private ApiRequest _api = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"api", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ApiRequest api
    {
      get { return _api; }
      set { _api = value; }
    }
    private readonly global::System.Collections.Generic.List<Production> _buy = new global::System.Collections.Generic.List<Production>();
    [global::ProtoBuf.ProtoMember(2, Name=@"buy", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Production> buy
    {
      get { return _buy; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}