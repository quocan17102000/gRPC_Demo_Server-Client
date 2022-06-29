// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/EmployeeCRUD.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServicedemo {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "greet.Greeter";

    static readonly grpc::Marshaller<global::GrpcServicedemo.HelloRequest> __Marshaller_greet_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServicedemo.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServicedemo.HelloReply> __Marshaller_greet_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServicedemo.HelloReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServicedemo.HelloRequest, global::GrpcServicedemo.HelloReply> __Method_SayHello = new grpc::Method<global::GrpcServicedemo.HelloRequest, global::GrpcServicedemo.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_greet_HelloRequest,
        __Marshaller_greet_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServicedemo.EmployeeCRUDReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcServicedemo.HelloReply> SayHello(global::GrpcServicedemo.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServicedemo.HelloRequest, global::GrpcServicedemo.HelloReply>(serviceImpl.SayHello));
    }

  }
  public static partial class EmployeeCRUD
  {
    static readonly string __ServiceName = "greet.EmployeeCRUD";

    static readonly grpc::Marshaller<global::GrpcServicedemo.Empty> __Marshaller_greet_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServicedemo.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServicedemo.Employees> __Marshaller_greet_Employees = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServicedemo.Employees.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServicedemo.EmployeeFilter> __Marshaller_greet_EmployeeFilter = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServicedemo.EmployeeFilter.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServicedemo.Employee> __Marshaller_greet_Employee = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServicedemo.Employee.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServicedemo.Empty, global::GrpcServicedemo.Employees> __Method_SelectAll = new grpc::Method<global::GrpcServicedemo.Empty, global::GrpcServicedemo.Employees>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SelectAll",
        __Marshaller_greet_Empty,
        __Marshaller_greet_Employees);

    static readonly grpc::Method<global::GrpcServicedemo.EmployeeFilter, global::GrpcServicedemo.Employee> __Method_SelectByID = new grpc::Method<global::GrpcServicedemo.EmployeeFilter, global::GrpcServicedemo.Employee>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SelectByID",
        __Marshaller_greet_EmployeeFilter,
        __Marshaller_greet_Employee);

    static readonly grpc::Method<global::GrpcServicedemo.Employee, global::GrpcServicedemo.Empty> __Method_Insert = new grpc::Method<global::GrpcServicedemo.Employee, global::GrpcServicedemo.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Insert",
        __Marshaller_greet_Employee,
        __Marshaller_greet_Empty);

    static readonly grpc::Method<global::GrpcServicedemo.Employee, global::GrpcServicedemo.Empty> __Method_Update = new grpc::Method<global::GrpcServicedemo.Employee, global::GrpcServicedemo.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_greet_Employee,
        __Marshaller_greet_Empty);

    static readonly grpc::Method<global::GrpcServicedemo.EmployeeFilter, global::GrpcServicedemo.Empty> __Method_Delete = new grpc::Method<global::GrpcServicedemo.EmployeeFilter, global::GrpcServicedemo.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_greet_EmployeeFilter,
        __Marshaller_greet_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServicedemo.EmployeeCRUDReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of EmployeeCRUD</summary>
    [grpc::BindServiceMethod(typeof(EmployeeCRUD), "BindService")]
    public abstract partial class EmployeeCRUDBase
    {
      /// <summary>
      ///rpc SayHello (HelloRequest) returns (HelloReply);
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcServicedemo.Employees> SelectAll(global::GrpcServicedemo.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcServicedemo.Employee> SelectByID(global::GrpcServicedemo.EmployeeFilter request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcServicedemo.Empty> Insert(global::GrpcServicedemo.Employee request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcServicedemo.Empty> Update(global::GrpcServicedemo.Employee request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcServicedemo.Empty> Delete(global::GrpcServicedemo.EmployeeFilter request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EmployeeCRUDBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SelectAll, serviceImpl.SelectAll)
          .AddMethod(__Method_SelectByID, serviceImpl.SelectByID)
          .AddMethod(__Method_Insert, serviceImpl.Insert)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EmployeeCRUDBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SelectAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServicedemo.Empty, global::GrpcServicedemo.Employees>(serviceImpl.SelectAll));
      serviceBinder.AddMethod(__Method_SelectByID, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServicedemo.EmployeeFilter, global::GrpcServicedemo.Employee>(serviceImpl.SelectByID));
      serviceBinder.AddMethod(__Method_Insert, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServicedemo.Employee, global::GrpcServicedemo.Empty>(serviceImpl.Insert));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServicedemo.Employee, global::GrpcServicedemo.Empty>(serviceImpl.Update));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServicedemo.EmployeeFilter, global::GrpcServicedemo.Empty>(serviceImpl.Delete));
    }

  }
}
#endregion
