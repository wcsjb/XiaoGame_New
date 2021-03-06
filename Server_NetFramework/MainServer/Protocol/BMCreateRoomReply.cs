// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BMCreateRoomReply.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Message {

  /// <summary>Holder for reflection information generated from BMCreateRoomReply.proto</summary>
  public static partial class BMCreateRoomReplyReflection {

    #region Descriptor
    /// <summary>File descriptor for BMCreateRoomReply.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BMCreateRoomReplyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdCTUNyZWF0ZVJvb21SZXBseS5wcm90bxIHbWVzc2FnZRoLSW5mb3MucHJv",
            "dG8iZQoRQk1DcmVhdGVSb29tUmVwbHkSDgoGcm9vbUlEGAEgASgFEi4KDHBs",
            "YXllclRva2VucxgCIAMoCzIYLm1lc3NhZ2UuUGxheWVyVG9rZW5JbmZvEhAK",
            "CHJvb21OYW1lGAMgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Message.InfosReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.BMCreateRoomReply), global::Message.BMCreateRoomReply.Parser, new[]{ "RoomID", "PlayerTokens", "RoomName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 战场 -> 主服 登录请求
  /// </summary>
  public sealed partial class BMCreateRoomReply : pb::IMessage<BMCreateRoomReply> {
    private static readonly pb::MessageParser<BMCreateRoomReply> _parser = new pb::MessageParser<BMCreateRoomReply>(() => new BMCreateRoomReply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BMCreateRoomReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.BMCreateRoomReplyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BMCreateRoomReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BMCreateRoomReply(BMCreateRoomReply other) : this() {
      roomID_ = other.roomID_;
      playerTokens_ = other.playerTokens_.Clone();
      roomName_ = other.roomName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BMCreateRoomReply Clone() {
      return new BMCreateRoomReply(this);
    }

    /// <summary>Field number for the "roomID" field.</summary>
    public const int RoomIDFieldNumber = 1;
    private int roomID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomID {
      get { return roomID_; }
      set {
        roomID_ = value;
      }
    }

    /// <summary>Field number for the "playerTokens" field.</summary>
    public const int PlayerTokensFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Message.PlayerTokenInfo> _repeated_playerTokens_codec
        = pb::FieldCodec.ForMessage(18, global::Message.PlayerTokenInfo.Parser);
    private readonly pbc::RepeatedField<global::Message.PlayerTokenInfo> playerTokens_ = new pbc::RepeatedField<global::Message.PlayerTokenInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Message.PlayerTokenInfo> PlayerTokens {
      get { return playerTokens_; }
    }

    /// <summary>Field number for the "roomName" field.</summary>
    public const int RoomNameFieldNumber = 3;
    private string roomName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomName {
      get { return roomName_; }
      set {
        roomName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BMCreateRoomReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BMCreateRoomReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomID != other.RoomID) return false;
      if(!playerTokens_.Equals(other.playerTokens_)) return false;
      if (RoomName != other.RoomName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomID != 0) hash ^= RoomID.GetHashCode();
      hash ^= playerTokens_.GetHashCode();
      if (RoomName.Length != 0) hash ^= RoomName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomID);
      }
      playerTokens_.WriteTo(output, _repeated_playerTokens_codec);
      if (RoomName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RoomName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomID);
      }
      size += playerTokens_.CalculateSize(_repeated_playerTokens_codec);
      if (RoomName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BMCreateRoomReply other) {
      if (other == null) {
        return;
      }
      if (other.RoomID != 0) {
        RoomID = other.RoomID;
      }
      playerTokens_.Add(other.playerTokens_);
      if (other.RoomName.Length != 0) {
        RoomName = other.RoomName;
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
          case 8: {
            RoomID = input.ReadInt32();
            break;
          }
          case 18: {
            playerTokens_.AddEntriesFrom(input, _repeated_playerTokens_codec);
            break;
          }
          case 26: {
            RoomName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
