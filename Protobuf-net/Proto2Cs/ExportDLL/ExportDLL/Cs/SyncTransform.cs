//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Proto/SyncTransform.proto
namespace ProtoData
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SyncTransformC2S")]
  public partial class SyncTransformC2S : global::ProtoBuf.IExtensible
  {
    public SyncTransformC2S() {}
    
    private float _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private float _angleY;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"angleY", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float angleY
    {
      get { return _angleY; }
      set { _angleY = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SyncTransformEvtS2C")]
  public partial class SyncTransformEvtS2C : global::ProtoBuf.IExtensible
  {
    public SyncTransformEvtS2C() {}
    
    private readonly global::System.Collections.Generic.List<SyncTransformEvtS2C.TransformData> _dataList = new global::System.Collections.Generic.List<SyncTransformEvtS2C.TransformData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dataList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SyncTransformEvtS2C.TransformData> dataList
    {
      get { return _dataList; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TransformData")]
  public partial class TransformData : global::ProtoBuf.IExtensible
  {
    public TransformData() {}
    
    private string _username;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private float _x;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private float _angleY;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"angleY", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float angleY
    {
      get { return _angleY; }
      set { _angleY = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}