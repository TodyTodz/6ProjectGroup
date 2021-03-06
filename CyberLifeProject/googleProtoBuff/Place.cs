// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: place.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CyberLife.Protobuff {

  /// <summary>Holder for reflection information generated from place.proto</summary>
  public static partial class PlaceReflection {

    #region Descriptor
    /// <summary>File descriptor for place.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlaceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtwbGFjZS5wcm90bxITQ3liZXJMaWZlLlByb3RvYnVmZiIdCgVQb2ludBIJ",
            "CgF4GAEgASgFEgkKAXkYAiABKAUiRgoFUGxhY2USKgoGcG9pbnRzGAEgAygL",
            "MhouQ3liZXJMaWZlLlByb3RvYnVmZi5Qb2ludBIRCglwbGFjZVR5cGUYAiAB",
            "KAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CyberLife.Protobuff.Point), global::CyberLife.Protobuff.Point.Parser, new[]{ "X", "Y" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CyberLife.Protobuff.Place), global::CyberLife.Protobuff.Place.Parser, new[]{ "Points", "PlaceType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Point : pb::IMessage<Point> {
    private static readonly pb::MessageParser<Point> _parser = new pb::MessageParser<Point>(() => new Point());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Point> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CyberLife.Protobuff.PlaceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Point() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Point(Point other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Point Clone() {
      return new Point(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Point);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Point other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Y);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Point other) {
      if (other == null) {
        return;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            X = input.ReadInt32();
            break;
          }
          case 16: {
            Y = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Place : pb::IMessage<Place> {
    private static readonly pb::MessageParser<Place> _parser = new pb::MessageParser<Place>(() => new Place());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Place> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CyberLife.Protobuff.PlaceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Place() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Place(Place other) : this() {
      points_ = other.points_.Clone();
      placeType_ = other.placeType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Place Clone() {
      return new Place(this);
    }

    /// <summary>Field number for the "points" field.</summary>
    public const int PointsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CyberLife.Protobuff.Point> _repeated_points_codec
        = pb::FieldCodec.ForMessage(10, global::CyberLife.Protobuff.Point.Parser);
    private readonly pbc::RepeatedField<global::CyberLife.Protobuff.Point> points_ = new pbc::RepeatedField<global::CyberLife.Protobuff.Point>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CyberLife.Protobuff.Point> Points {
      get { return points_; }
    }

    /// <summary>Field number for the "placeType" field.</summary>
    public const int PlaceTypeFieldNumber = 2;
    private int placeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlaceType {
      get { return placeType_; }
      set {
        placeType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Place);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Place other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!points_.Equals(other.points_)) return false;
      if (PlaceType != other.PlaceType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= points_.GetHashCode();
      if (PlaceType != 0) hash ^= PlaceType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      points_.WriteTo(output, _repeated_points_codec);
      if (PlaceType != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PlaceType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += points_.CalculateSize(_repeated_points_codec);
      if (PlaceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlaceType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Place other) {
      if (other == null) {
        return;
      }
      points_.Add(other.points_);
      if (other.PlaceType != 0) {
        PlaceType = other.PlaceType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            points_.AddEntriesFrom(input, _repeated_points_codec);
            break;
          }
          case 16: {
            PlaceType = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
