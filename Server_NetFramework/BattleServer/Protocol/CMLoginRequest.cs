// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: CMLoginRequest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Message {

  /// <summary>Holder for reflection information generated from CMLoginRequest.proto</summary>
  public static partial class CMLoginRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for CMLoginRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CMLoginRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDTUxvZ2luUmVxdWVzdC5wcm90bxIHbWVzc2FnZSIiCg5DTUxvZ2luUmVx",
            "dWVzdBIQCghkZXZpY2VJRBgBIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.CMLoginRequest), global::Message.CMLoginRequest.Parser, new[]{ "DeviceID" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 客户端 -> 主服 登录请求
  /// </summary>
  public sealed partial class CMLoginRequest : pb::IMessage<CMLoginRequest> {
    private static readonly pb::MessageParser<CMLoginRequest> _parser = new pb::MessageParser<CMLoginRequest>(() => new CMLoginRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CMLoginRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.CMLoginRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CMLoginRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CMLoginRequest(CMLoginRequest other) : this() {
      deviceID_ = other.deviceID_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CMLoginRequest Clone() {
      return new CMLoginRequest(this);
    }

    /// <summary>Field number for the "deviceID" field.</summary>
    public const int DeviceIDFieldNumber = 1;
    private string deviceID_ = "";
    /// <summary>
    /// 设备ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceID {
      get { return deviceID_; }
      set {
        deviceID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CMLoginRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CMLoginRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeviceID != other.DeviceID) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DeviceID.Length != 0) hash ^= DeviceID.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DeviceID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DeviceID);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DeviceID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceID);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CMLoginRequest other) {
      if (other == null) {
        return;
      }
      if (other.DeviceID.Length != 0) {
        DeviceID = other.DeviceID;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            DeviceID = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
