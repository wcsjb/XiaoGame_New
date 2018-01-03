// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: CBBattleResultSync.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Message {

  /// <summary>Holder for reflection information generated from CBBattleResultSync.proto</summary>
  public static partial class CBBattleResultSyncReflection {

    #region Descriptor
    /// <summary>File descriptor for CBBattleResultSync.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CBBattleResultSyncReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDQkJhdHRsZVJlc3VsdFN5bmMucHJvdG8SB21lc3NhZ2UiJgoSQ0JCYXR0",
            "bGVSZXN1bHRTeW5jEhAKCHdpbm5lcklEGAEgAygFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.CBBattleResultSync), global::Message.CBBattleResultSync.Parser, new[]{ "WinnerID" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CBBattleResultSync : pb::IMessage<CBBattleResultSync> {
    private static readonly pb::MessageParser<CBBattleResultSync> _parser = new pb::MessageParser<CBBattleResultSync>(() => new CBBattleResultSync());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CBBattleResultSync> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.CBBattleResultSyncReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CBBattleResultSync() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CBBattleResultSync(CBBattleResultSync other) : this() {
      winnerID_ = other.winnerID_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CBBattleResultSync Clone() {
      return new CBBattleResultSync(this);
    }

    /// <summary>Field number for the "winnerID" field.</summary>
    public const int WinnerIDFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_winnerID_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> winnerID_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> WinnerID {
      get { return winnerID_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CBBattleResultSync);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CBBattleResultSync other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!winnerID_.Equals(other.winnerID_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= winnerID_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      winnerID_.WriteTo(output, _repeated_winnerID_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += winnerID_.CalculateSize(_repeated_winnerID_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CBBattleResultSync other) {
      if (other == null) {
        return;
      }
      winnerID_.Add(other.winnerID_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            winnerID_.AddEntriesFrom(input, _repeated_winnerID_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code