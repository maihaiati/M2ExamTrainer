// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Exam.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Exam.proto</summary>
public static partial class ExamReflection {

  #region Descriptor
  /// <summary>File descriptor for Exam.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ExamReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgpFeGFtLnByb3RvIlUKBEV4YW0SDAoEbmFtZRgBIAEoCRIOCgZhdXRob3IY",
          "AiABKAkSEQoJbnVtT2ZRdWVzGAMgASgFEhwKCXF1ZXN0aW9ucxgEIAMoCzIJ",
          "LlF1ZXN0aW9uIncKCFF1ZXN0aW9uEgoKAmlkGAEgASgDEhIKCnRydWVBbnN3",
          "ZXIYAiABKAMSDQoFaW1hZ2UYAyABKAkSDQoFYXVkaW8YBCABKAkSEwoLbXVs",
          "dGlBbnN3ZXIYBSABKAgSGAoHYW5zd2VycxgGIAMoCzIHLkFuc3dlciIlCgZB",
          "bnN3ZXISCgoCaWQYASABKAMSDwoHY29udGVudBgCIAEoCWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Exam), global::Exam.Parser, new[]{ "Name", "Author", "NumOfQues", "Questions" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Question), global::Question.Parser, new[]{ "Id", "TrueAnswer", "Image", "Audio", "MultiAnswer", "Answers" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Answer), global::Answer.Parser, new[]{ "Id", "Content" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Exam : pb::IMessage<Exam>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Exam> _parser = new pb::MessageParser<Exam>(() => new Exam());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Exam> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ExamReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Exam() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Exam(Exam other) : this() {
    name_ = other.name_;
    author_ = other.author_;
    numOfQues_ = other.numOfQues_;
    questions_ = other.questions_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Exam Clone() {
    return new Exam(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "author" field.</summary>
  public const int AuthorFieldNumber = 2;
  private string author_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Author {
    get { return author_; }
    set {
      author_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "numOfQues" field.</summary>
  public const int NumOfQuesFieldNumber = 3;
  private int numOfQues_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int NumOfQues {
    get { return numOfQues_; }
    set {
      numOfQues_ = value;
    }
  }

  /// <summary>Field number for the "questions" field.</summary>
  public const int QuestionsFieldNumber = 4;
  private static readonly pb::FieldCodec<global::Question> _repeated_questions_codec
      = pb::FieldCodec.ForMessage(34, global::Question.Parser);
  private readonly pbc::RepeatedField<global::Question> questions_ = new pbc::RepeatedField<global::Question>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::Question> Questions {
    get { return questions_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Exam);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Exam other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Author != other.Author) return false;
    if (NumOfQues != other.NumOfQues) return false;
    if(!questions_.Equals(other.questions_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (Author.Length != 0) hash ^= Author.GetHashCode();
    if (NumOfQues != 0) hash ^= NumOfQues.GetHashCode();
    hash ^= questions_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (Author.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Author);
    }
    if (NumOfQues != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(NumOfQues);
    }
    questions_.WriteTo(output, _repeated_questions_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (Author.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Author);
    }
    if (NumOfQues != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(NumOfQues);
    }
    questions_.WriteTo(ref output, _repeated_questions_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (Author.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Author);
    }
    if (NumOfQues != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumOfQues);
    }
    size += questions_.CalculateSize(_repeated_questions_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Exam other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.Author.Length != 0) {
      Author = other.Author;
    }
    if (other.NumOfQues != 0) {
      NumOfQues = other.NumOfQues;
    }
    questions_.Add(other.questions_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 18: {
          Author = input.ReadString();
          break;
        }
        case 24: {
          NumOfQues = input.ReadInt32();
          break;
        }
        case 34: {
          questions_.AddEntriesFrom(input, _repeated_questions_codec);
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 18: {
          Author = input.ReadString();
          break;
        }
        case 24: {
          NumOfQues = input.ReadInt32();
          break;
        }
        case 34: {
          questions_.AddEntriesFrom(ref input, _repeated_questions_codec);
          break;
        }
      }
    }
  }
  #endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Question : pb::IMessage<Question>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Question> _parser = new pb::MessageParser<Question>(() => new Question());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Question> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ExamReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Question() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Question(Question other) : this() {
    id_ = other.id_;
    trueAnswer_ = other.trueAnswer_;
    image_ = other.image_;
    audio_ = other.audio_;
    multiAnswer_ = other.multiAnswer_;
    answers_ = other.answers_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Question Clone() {
    return new Question(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private long id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "trueAnswer" field.</summary>
  public const int TrueAnswerFieldNumber = 2;
  private long trueAnswer_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long TrueAnswer {
    get { return trueAnswer_; }
    set {
      trueAnswer_ = value;
    }
  }

  /// <summary>Field number for the "image" field.</summary>
  public const int ImageFieldNumber = 3;
  private string image_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Image {
    get { return image_; }
    set {
      image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "audio" field.</summary>
  public const int AudioFieldNumber = 4;
  private string audio_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Audio {
    get { return audio_; }
    set {
      audio_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "multiAnswer" field.</summary>
  public const int MultiAnswerFieldNumber = 5;
  private bool multiAnswer_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool MultiAnswer {
    get { return multiAnswer_; }
    set {
      multiAnswer_ = value;
    }
  }

  /// <summary>Field number for the "answers" field.</summary>
  public const int AnswersFieldNumber = 6;
  private static readonly pb::FieldCodec<global::Answer> _repeated_answers_codec
      = pb::FieldCodec.ForMessage(50, global::Answer.Parser);
  private readonly pbc::RepeatedField<global::Answer> answers_ = new pbc::RepeatedField<global::Answer>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::Answer> Answers {
    get { return answers_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Question);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Question other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (TrueAnswer != other.TrueAnswer) return false;
    if (Image != other.Image) return false;
    if (Audio != other.Audio) return false;
    if (MultiAnswer != other.MultiAnswer) return false;
    if(!answers_.Equals(other.answers_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0L) hash ^= Id.GetHashCode();
    if (TrueAnswer != 0L) hash ^= TrueAnswer.GetHashCode();
    if (Image.Length != 0) hash ^= Image.GetHashCode();
    if (Audio.Length != 0) hash ^= Audio.GetHashCode();
    if (MultiAnswer != false) hash ^= MultiAnswer.GetHashCode();
    hash ^= answers_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Id != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(Id);
    }
    if (TrueAnswer != 0L) {
      output.WriteRawTag(16);
      output.WriteInt64(TrueAnswer);
    }
    if (Image.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Image);
    }
    if (Audio.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Audio);
    }
    if (MultiAnswer != false) {
      output.WriteRawTag(40);
      output.WriteBool(MultiAnswer);
    }
    answers_.WriteTo(output, _repeated_answers_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Id != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(Id);
    }
    if (TrueAnswer != 0L) {
      output.WriteRawTag(16);
      output.WriteInt64(TrueAnswer);
    }
    if (Image.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Image);
    }
    if (Audio.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Audio);
    }
    if (MultiAnswer != false) {
      output.WriteRawTag(40);
      output.WriteBool(MultiAnswer);
    }
    answers_.WriteTo(ref output, _repeated_answers_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
    }
    if (TrueAnswer != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(TrueAnswer);
    }
    if (Image.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Image);
    }
    if (Audio.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Audio);
    }
    if (MultiAnswer != false) {
      size += 1 + 1;
    }
    size += answers_.CalculateSize(_repeated_answers_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Question other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0L) {
      Id = other.Id;
    }
    if (other.TrueAnswer != 0L) {
      TrueAnswer = other.TrueAnswer;
    }
    if (other.Image.Length != 0) {
      Image = other.Image;
    }
    if (other.Audio.Length != 0) {
      Audio = other.Audio;
    }
    if (other.MultiAnswer != false) {
      MultiAnswer = other.MultiAnswer;
    }
    answers_.Add(other.answers_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Id = input.ReadInt64();
          break;
        }
        case 16: {
          TrueAnswer = input.ReadInt64();
          break;
        }
        case 26: {
          Image = input.ReadString();
          break;
        }
        case 34: {
          Audio = input.ReadString();
          break;
        }
        case 40: {
          MultiAnswer = input.ReadBool();
          break;
        }
        case 50: {
          answers_.AddEntriesFrom(input, _repeated_answers_codec);
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Id = input.ReadInt64();
          break;
        }
        case 16: {
          TrueAnswer = input.ReadInt64();
          break;
        }
        case 26: {
          Image = input.ReadString();
          break;
        }
        case 34: {
          Audio = input.ReadString();
          break;
        }
        case 40: {
          MultiAnswer = input.ReadBool();
          break;
        }
        case 50: {
          answers_.AddEntriesFrom(ref input, _repeated_answers_codec);
          break;
        }
      }
    }
  }
  #endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Answer : pb::IMessage<Answer>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Answer> _parser = new pb::MessageParser<Answer>(() => new Answer());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Answer> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ExamReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Answer() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Answer(Answer other) : this() {
    id_ = other.id_;
    content_ = other.content_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Answer Clone() {
    return new Answer(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private long id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "content" field.</summary>
  public const int ContentFieldNumber = 2;
  private string content_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Content {
    get { return content_; }
    set {
      content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Answer);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Answer other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Content != other.Content) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0L) hash ^= Id.GetHashCode();
    if (Content.Length != 0) hash ^= Content.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Id != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(Id);
    }
    if (Content.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Content);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Id != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(Id);
    }
    if (Content.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Content);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
    }
    if (Content.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Answer other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0L) {
      Id = other.Id;
    }
    if (other.Content.Length != 0) {
      Content = other.Content;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Id = input.ReadInt64();
          break;
        }
        case 18: {
          Content = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Id = input.ReadInt64();
          break;
        }
        case 18: {
          Content = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
