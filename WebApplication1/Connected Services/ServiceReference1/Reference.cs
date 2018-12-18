﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/vcfrestd")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((this.BookIdField.Equals(value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/vcfrestd")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBooks", ReplyAction="http://tempuri.org/IService1/GetAllBooksResponse")]
        WebApplication1.ServiceReference1.Book[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBooks", ReplyAction="http://tempuri.org/IService1/GetAllBooksResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.Book[]> GetAllBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookById", ReplyAction="http://tempuri.org/IService1/GetBookByIdResponse")]
        WebApplication1.ServiceReference1.Book GetBookById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookById", ReplyAction="http://tempuri.org/IService1/GetBookByIdResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.Book> GetBookByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewBook", ReplyAction="http://tempuri.org/IService1/AddNewBookResponse")]
        string AddNewBook(WebApplication1.ServiceReference1.Book item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewBook", ReplyAction="http://tempuri.org/IService1/AddNewBookResponse")]
        System.Threading.Tasks.Task<string> AddNewBookAsync(WebApplication1.ServiceReference1.Book item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        string DeleteBook(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        System.Threading.Tasks.Task<string> DeleteBookAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBook", ReplyAction="http://tempuri.org/IService1/UpdateBookResponse")]
        string UpdateBook(WebApplication1.ServiceReference1.Book item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBook", ReplyAction="http://tempuri.org/IService1/UpdateBookResponse")]
        System.Threading.Tasks.Task<string> UpdateBookAsync(WebApplication1.ServiceReference1.Book item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WebApplication1.ServiceReference1.CompositeType GetDataUsingDataContract(WebApplication1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebApplication1.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.IService1>, WebApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication1.ServiceReference1.Book[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.Book[]> GetAllBooksAsync() {
            return base.Channel.GetAllBooksAsync();
        }
        
        public WebApplication1.ServiceReference1.Book GetBookById(string id) {
            return base.Channel.GetBookById(id);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.Book> GetBookByIdAsync(string id) {
            return base.Channel.GetBookByIdAsync(id);
        }
        
        public string AddNewBook(WebApplication1.ServiceReference1.Book item) {
            return base.Channel.AddNewBook(item);
        }
        
        public System.Threading.Tasks.Task<string> AddNewBookAsync(WebApplication1.ServiceReference1.Book item) {
            return base.Channel.AddNewBookAsync(item);
        }
        
        public string DeleteBook(string id) {
            return base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBookAsync(string id) {
            return base.Channel.DeleteBookAsync(id);
        }
        
        public string UpdateBook(WebApplication1.ServiceReference1.Book item) {
            return base.Channel.UpdateBook(item);
        }
        
        public System.Threading.Tasks.Task<string> UpdateBookAsync(WebApplication1.ServiceReference1.Book item) {
            return base.Channel.UpdateBookAsync(item);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WebApplication1.ServiceReference1.CompositeType GetDataUsingDataContract(WebApplication1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebApplication1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
